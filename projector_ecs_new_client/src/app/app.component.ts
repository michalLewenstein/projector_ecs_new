import { Component, Inject, OnInit, PLATFORM_ID } from '@angular/core';
import { isPlatformBrowser } from '@angular/common';
import { TranslocoService } from '@ngneat/transloco';
import { TranslocoModule } from '@ngneat/transloco';
import { NavbarComponent } from "./nav-bar/nav-bar.component";
import { RouterModule } from '@angular/router';
import { UserAccountService } from './service/userAccount.service';
import { FooterComponent } from './footer/footer.component';
import { MatIconModule } from '@angular/material/icon'; 
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
  standalone: true,
  imports: [TranslocoModule, NavbarComponent, RouterModule, FooterComponent,MatIconModule]
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

  updateDirection(lang: string) {
    const isRTL = lang === 'he';
    if (isPlatformBrowser(this.platformId)) {
      document.body.dir = isRTL ? 'rtl' : 'ltr';
      
    }
  }
}