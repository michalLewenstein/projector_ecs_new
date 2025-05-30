import { Component, OnInit} from '@angular/core';
import { TranslocoService } from '@ngneat/transloco';
import { DatePipe } from '@angular/common';
import { CommonModule } from '@angular/common';
import { TranslocoModule } from '@ngneat/transloco';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatMenuModule } from '@angular/material/menu';
import { MatIconModule } from '@angular/material/icon';
import { RouterModule } from '@angular/router';
import { Router } from '@angular/router';
import { UserAccountService } from '../service/userAccount.service';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-navbar',
  templateUrl: './nav-bar.component.html',
  standalone: true,
  imports: [
    CommonModule,
    TranslocoModule,
    MatToolbarModule,
    MatMenuModule,
    MatIconModule,
    RouterModule,
  ],
  styleUrls: ['./nav-bar.component.scss'],
  providers: [DatePipe],
})
export class NavbarComponent implements OnInit {
[x: string]: any;
  navigateToProfile() {
    throw new Error('Method not implemented.');
  }
  currentLang: string | undefined;

  isLoggedIn = false;
  showMobileMenu = false;
  private subscription!: Subscription;

  toggleMenu() {
    this.showMobileMenu = !this.showMobileMenu;
  }
  isMobile = false;

  constructor(
    private translocoService: TranslocoService, 
    private router: Router, 
    private userAccountService: UserAccountService,
  ) { }

  ngOnInit(): void {
   
    this.userAccountService.checkLoggedInStatus();

    this.subscription = this.userAccountService.isLoggedIn$.subscribe((status) => {
      console.log("סטטוס התחברות:", status);
      this.isLoggedIn = status;
      if(!this.isLoggedIn) 
        this.router.navigate(['/']);
    });
    
    this.currentLang = window.localStorage.getItem('preferredLang') || 'en';
    this.translocoService.langChanges$.subscribe(lang => {
      this.currentLang = lang;
      this.updateDirection(lang);
    });
  
    this.isMobile = window.innerWidth <= 768;
    window.addEventListener('resize', () => {
      this.isMobile = window.innerWidth <= 768;
      if (!this.isMobile) {
        this.showMobileMenu = false;
      }
    });
  
  }

  ngOnDestroy(): void {
    this.subscription.unsubscribe();
  }
  
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

  changeLanguage(lang: string): void {
    this.translocoService.setActiveLang(lang);
    window.localStorage.setItem('preferredLang', lang);
    this.updateDirection(lang);
  }
  
  tologout() {
    this.userAccountService.logout().subscribe({
      next: (res) => {
        console.log("התנתקות בוצעה בהצלחה!", res);
      },
      error: (err) => {
        console.log("בעיה בהתנתקות", err);
      }
    });
  }
}