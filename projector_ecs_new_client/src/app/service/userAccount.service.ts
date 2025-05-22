import { Injectable } from '@angular/core';
import { Observable, of, BehaviorSubject, timer, Subscription } from 'rxjs';
import { UserAccount } from '../models/userAccount.model';
import { HttpClient } from '@angular/common/http';
import { catchError, map, tap } from 'rxjs/operators';
import { MatDialog } from '@angular/material/dialog';
import { SessionTimeoutDialogComponent } from '../SessionTimeoutDialogComponent ';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class UserAccountService {
  private apiUrl = 'https://localhost:7294/api/User';
  private authApiUrl = 'https://localhost:7294/api/Auth';
  private isLoggedInSubject = new BehaviorSubject<boolean>(false);
  isLoggedIn$ = this.isLoggedInSubject.asObservable();
  
  // טיימר למעקב אחרי פקיעת תוקף הטוקן
  private tokenExpiryTimer: Subscription | null = null;
  // משך הזמן בדקות לפני התראה על פקיעת תוקף
  private readonly warningMinutes = 1;
  // משך הזמן בדקות לתוקף מלא של הטוקן (1440 דקות = 24 שעות)
  private readonly tokenDuration = 2;

  constructor(
    private _http: HttpClient,
    private dialog: MatDialog,
    private router: Router, 
  ) {
    
if (typeof window !== 'undefined') {
    // מעקב אחרי סגירת החלון או רענון הדף
    window.addEventListener('beforeunload', this.handleBeforeUnload.bind(this));
}
  }

  //פונקציית התחברות
  login(userAccount: UserAccount): Observable<UserAccount> {
    console.log("מה שנשלח בהתחברות", userAccount);
    return this._http.post<UserAccount>(`${this.authApiUrl}`, userAccount, { withCredentials: true })
    .pipe(
      map(user => {
        this.isLoggedInSubject.next(true);
        // התחלת טיימר לפקיעת תוקף הטוקן
        this.startTokenExpiryTimer();
        return user;
      }),
      catchError(err => {
        this.isLoggedInSubject.next(false);
        return of(null as any);
      })
    );
  }
 
  register(userAccount: UserAccount): Observable<UserAccount> {
    return this._http.post<UserAccount>(`${this.apiUrl}/login`, userAccount, { withCredentials: true })
    .pipe(
      map((user) => {
        this.isLoggedInSubject.next(true);
        // התחלת טיימר לפקיעת תוקף הטוקן
        this.startTokenExpiryTimer();
        return user;
      }),
      catchError((err) => {
        this.isLoggedInSubject.next(false);
        return of(null as any);
      })
    );
  }

  logout(): Observable<void> {
    // ביצוע התנתקות מול השרת
    return this._http.post<any>(`${this.authApiUrl}/logout`, {}, { withCredentials: true })
    .pipe(
      map((res) => {
        this.isLoggedInSubject.next(false);
        // ביטול הטיימר לפקיעת תוקף
        this.stopTokenExpiryTimer();
        return res;
        
      }),
      catchError((err) => {
        return of(err);
      })
    );
  }

  checkLoggedInStatus(): void {
    this._http.get<boolean>(`${this.apiUrl}/getLoggedInUserId`, { withCredentials: true })
      .pipe(
        map((isLoggedIn: boolean) => {
          if (isLoggedIn) {
            this.isLoggedInSubject.next(true);
            this.startTokenExpiryTimer();
          } else {
            this.isLoggedInSubject.next(false);
          }
        }),
        catchError(() => {
          this.isLoggedInSubject.next(false);
          return of(false);          
        })
      ).subscribe();
  }

  // חידוש הטוקן
  refreshToken(): Observable<any> {
    return this._http.post<any>(`${this.authApiUrl}/refresh-token`, {}, { withCredentials: true })
      .pipe(
        tap(() => {
          // התחלת טיימר חדש אחרי חידוש הטוקן
          this.startTokenExpiryTimer();
        }),
        catchError(err => {
          // במקרה של כשלון, נתנתק את המשתמש
          this.isLoggedInSubject.next(false);
          // this.router.navigate(['/']);
          return of(err);
        })
      );
  }

  // התחלת טיימר לפקיעת תוקף הטוקן
  private startTokenExpiryTimer(): void {
    // עצירת טיימר קיים אם יש
    this.stopTokenExpiryTimer();
    
    // התחלת טיימר חדש שיפעל כמה דקות לפני פקיעת התוקף
    const warningTime = (this.tokenDuration - this.warningMinutes) * 60 * 1000;
    this.tokenExpiryTimer = timer(warningTime).subscribe(() => {
      this.showSessionExpiryWarning();
    });
  }

  // עצירת הטיימר של פקיעת תוקף הטוקן
  private stopTokenExpiryTimer(): void {
    if (this.tokenExpiryTimer) {
      this.tokenExpiryTimer.unsubscribe();
      this.tokenExpiryTimer = null;
    }
  }

  // הצגת התראה על פקיעת תוקף הטוקן
  private showSessionExpiryWarning(): void {
    const dialogRef = this.dialog.open( SessionTimeoutDialogComponent, {
      width: '350px',
      disableClose: true,
      data: { minutesLeft: this.warningMinutes }
    });

    dialogRef.afterClosed().subscribe(result => {
      if (result === true) {
        // המשתמש בחר להאריך את הסשן
        this.refreshToken().subscribe();
      } else {
        // המשתמש בחר להתנתק
        this.logout().subscribe();
      }
    });
  }

  // טיפול באירוע סגירת חלון או רענון הדף
  private handleBeforeUnload(): void {
    // בדיקה אם המשתמש מחובר
    if (this.isLoggedInSubject.value) {
      navigator.sendBeacon(`${this.authApiUrl}/logout`);
    }
  }
}