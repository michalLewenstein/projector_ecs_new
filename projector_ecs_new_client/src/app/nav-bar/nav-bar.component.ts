import { Component, OnInit, ChangeDetectorRef, NgZone } from '@angular/core';
import { TranslocoService } from '@ngneat/transloco';
import { DatePipe } from '@angular/common';
import { CommonModule } from '@angular/common';
import { TranslocoModule } from '@ngneat/transloco';
import { LoginComponent } from '../login/login.component';
import { UserSignupComponent } from '../signup/user-signup/user-signup.component';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatMenuModule } from '@angular/material/menu';
import { MatIconModule } from '@angular/material/icon';
import { RouterModule } from '@angular/router';
import { Router } from '@angular/router';



@Component({
  selector: 'app-navbar',
  templateUrl: './nav-bar.component.html',
  standalone: true,
  imports: [
    CommonModule,
    TranslocoModule,
    LoginComponent,
    UserSignupComponent,
    MatToolbarModule,
    MatMenuModule,
    MatIconModule,
    RouterModule
  ],
  styleUrls: ['./nav-bar.component.scss'],
  providers: [DatePipe],
})
export class NavbarComponent implements OnInit {
[x: string]: any;
  logout() {
    throw new Error('Method not implemented.');
  }
  navigateToProfile() {
    throw new Error('Method not implemented.');
  }
  // currentDate: string | undefined;
  currentLang: string | undefined;

  showLogin = false;
  showsignup = false;
  isLoggedIn = false;
  showMobileMenu = false;

  toggleMenu() {
    this.showMobileMenu = !this.showMobileMenu;
  }
  isMobile = false;


  constructor(private translocoService: TranslocoService, private datePipe: DatePipe, private cdr: ChangeDetectorRef, private zone: NgZone, private router: Router) { }

  ngOnInit(): void {
    // this.updateDate();
    this.currentLang = localStorage.getItem('preferredLang') || 'en';
    this.translocoService.langChanges$.subscribe(lang => {
      this.currentLang = lang;
      // this.updateDate();
      this.updateDirection(lang);
    });
    // setTimeout(() => {
    //   this.currentDate = new Date().toLocaleDateString('en-GB');
    //   this.cdr.detectChanges();
    // }, 0);
    // setTimeout(() => {
    //   this.zone.run(() => {
    //     this.currentDate = new Date().toLocaleDateString('en-GB');
    //   });
    // }, 0);

    this.isMobile = window.innerWidth <= 768;
    window.addEventListener('resize', () => {
      this.isMobile = window.innerWidth <= 768;
      if (!this.isMobile) {
        this.showMobileMenu = false;
      }
    });
  }

  // updateDate() {
  //   const now = new Date();
  //   if (this.currentLang === 'he') {
  //     this.currentDate = this.datePipe.transform(now, 'dd/MM/yyyy') || '';
  //   } else {
  //     this.currentDate = this.datePipe.transform(now, 'MMMM dd, yyyy') || '';
  //   }
  // }

  updateDirection(lang: string) {
    const isRTL = lang === 'he';
    document.body.dir = isRTL ? 'rtl' : 'ltr';
  }

  toggleLogin() {
    this.router.navigate(['/loginUser']);
  }

  togglesignup() {
    this.router.navigate(['/usersignup']);
  }

  onLoginSuccess() {
    this.isLoggedIn = true;
    this.showLogin = false;
    this.showsignup = false;
  }
  onSignupSuccess() {
    this.isLoggedIn = true;
    this.showLogin = false;
    this.showsignup = false;
  }

  changeLanguage(lang: string): void {
    this.translocoService.setActiveLang(lang);
    localStorage.setItem('preferredLang', lang);
    this.updateDirection(lang);
  }
}