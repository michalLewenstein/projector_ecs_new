import { Component, Inject, PLATFORM_ID } from '@angular/core';
import { isPlatformBrowser } from '@angular/common';
import { TranslocoService } from '@ngneat/transloco';
import { TranslocoModule } from '@ngneat/transloco';
import { NavbarComponent } from "./nav-bar/nav-bar.component";
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
  standalone: true, 
  imports: [TranslocoModule, NavbarComponent, RouterModule] 
})
export class AppComponent {
  title = 'diunim-client';

  constructor(
    private translocoService: TranslocoService,
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