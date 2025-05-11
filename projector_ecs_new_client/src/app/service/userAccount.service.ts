import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { UserAccount } from '../models/userAccount.model';
import { HttpClient } from '@angular/common/http';
import { catchError, map } from 'rxjs/operators';
import {BehaviorSubject} from 'rxjs'

@Injectable({
  providedIn: 'root'
})
export class UserAccountService {
  private apiUrl ='https://localhost:7294/api/User'
  private isLoggedInSubject = new BehaviorSubject<boolean>(false); 
  isLoggedIn$ = this.isLoggedInSubject.asObservable();

  constructor(
    private _http: HttpClient,
  ) { }
  login(userAccount: UserAccount): Observable<UserAccount> {
<<<<<<< HEAD
    console.log("מה שנשלח בהתחברות", userAccount);
    
    return this._http.post<UserAccount>(`${this.apiUrl}/login`, userAccount, { withCredentials: true }); 
  }
  
  register(userAccount:UserAccount): Observable<UserAccount> {
    return this._http.post<UserAccount>(`${this.apiUrl}/register`, userAccount);
=======
    return this._http.post<UserAccount>(`${this.apiUrl}/login`, userAccount, { withCredentials: true })
    .pipe(
      map((user) => {
        this.isLoggedInSubject.next(true); 
        return user;
      }),
      catchError((err) => {
        this.isLoggedInSubject.next(false);
        return of(null as any);
      })
    );
>>>>>>> f958d1aafdcbe9b1f0f086ec7f09cc7070b6d535
  }

  logout(): Observable<any> {
    return this._http.post<any>(`${this.apiUrl}/logout`, {}, { withCredentials: true })
    .pipe(
      map((res) => {
        this.isLoggedInSubject.next(false); 
        return res;
      }),
      catchError((err) => {
        return of(err);
      })
    );
  }

  checkLoggedInStatus(): void {
    this._http.get<any>(`${this.apiUrl}/getLoggedInUserId`, { withCredentials: true })
      .pipe(
        map(() => {
          this.isLoggedInSubject.next(true); 
        }),
        catchError(() => {
          this.isLoggedInSubject.next(false); 
          return of(false);
        })
      ).subscribe();
  }

}
