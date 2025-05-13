import { Component, Inject, OnInit, PLATFORM_ID } from '@angular/core';
import { isPlatformBrowser } from '@angular/common';
import { TranslocoService } from '@ngneat/transloco';
import { TranslocoModule } from '@ngneat/transloco';
import { NavbarComponent } from "./nav-bar/nav-bar.component";
import { RouterModule } from '@angular/router';
import { UserAccountService } from './service/userAccount.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
  standalone: true,
  imports: [TranslocoModule, NavbarComponent, RouterModule]
})
export class AppComponent  {
  title = 'ECS-PROJECTOR';

  constructor(
    private translocoService: TranslocoService,
    private userAccountService: UserAccountService,
    @Inject(PLATFORM_ID) private platformId: Object
  ) {
    if (isPlatformBrowser(this.platformId)) {
      const savedLang = window.localStorage.getItem('preferredLang');
      const lang = savedLang ? savedLang : 'en';
      this.translocoService.setActiveLang(lang);
      this.updateDirection(lang);
    }
  }
  // ngOnInit() {
  //   // קודם נבדוק אם המשתמש מחובר ורק אז ננתק אותו
  //   if (isPlatformBrowser(this.platformId)) {
  //     // בדוק אם זה ריענון דף או פתיחה חדשה
  //     const lastActivityTime = sessionStorage.getItem('lastActivityTime');
  //     const currentTime = new Date().getTime();
      
  //     // אם אין זמן פעילות קודם או עברו יותר מ-5 דקות, נחשב זאת כפתיחה חדשה
  //     if (!lastActivityTime || (currentTime - parseInt(lastActivityTime)) > 5 * 60 * 1000) {
  //       // קודם בודקים אם המשתמש מחובר
  //       this.userAccountService.checkLoggedInStatus();
        
  //       // נירשם לאירוע השינוי בסטטוס החיבור
  //       this.userAccountService.isLoggedIn$.subscribe(isLoggedIn => {
  //         if (isLoggedIn) {
  //           // אם המשתמש מחובר, ננתק אותו
  //           this.userAccountService.logout().subscribe({
  //             next: () => {
  //               console.log("המשתמש השמור נמחק בהצלחה");
  //             },
  //             error: (err) => {
  //               console.log("שגיאה במחיקת המשתמש השמור", err);
  //             }
  //           });
  //         }
  //       });
  //     }
      
  //     // עדכן את זמן הפעילות האחרון
  //     sessionStorage.setItem('lastActivityTime', currentTime.toString());
  //   }
  // }
  // ngOnInit() {
  //   // this.userAccountService.checkLoggedInStatus();
  //   // this.subscription = this.userAccountService.isLoggedIn$.subscribe((status) => {
  //   //   console.log("סטטוס התחברות:", status);
  //   //   if(status){
  //   this.userAccountService.logout().subscribe({
  //     next: () => {
  //       console.log("המשתמש השמור נמחק");
  //     },
  //     error: () => {
  //       console.log("שגיאה במחיקת המשתמש השמור");
  //     }
  //   })
    //   }
    //   else{
    //     console.log("אין משתמש שמור במערכת");

    //   }
    // })
  // }

  updateDirection(lang: string) {
    const isRTL = lang === 'he';
    if (isPlatformBrowser(this.platformId)) {
      document.body.dir = isRTL ? 'rtl' : 'ltr';
    }
  }
}