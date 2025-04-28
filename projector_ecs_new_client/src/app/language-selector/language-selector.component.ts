import { Component, Inject, PLATFORM_ID } from '@angular/core';
import { isPlatformBrowser } from '@angular/common';
import { TranslocoService } from '@ngneat/transloco';
import { CommonModule } from '@angular/common';
import { TranslocoModule } from '@ngneat/transloco';

@Component({
  selector: 'app-language-selector',
  standalone: true,
  imports: [CommonModule, TranslocoModule],
  templateUrl: './language-selector.component.html',
  styleUrls: ['./language-selector.component.scss'],
})
export class LanguageSelectorComponent {
  isBrowser: boolean;

  constructor(
    private translocoService: TranslocoService,
    @Inject(PLATFORM_ID) private platformId: Object,
  ) {
    this.isBrowser = isPlatformBrowser(this.platformId);
  }

  // פונקציה להחלפת שפה
  setLang(lang: string) {
    this.translocoService.setActiveLang(lang);

    // שמירה ב-localStorage אם אפשר
    if (this.isBrowser && window.localStorage) {
      localStorage.setItem('preferredLang', lang);
    } else {
      console.log('localStorage is not available');
    }
  }

  // בדיקה אם יש שפה שמורה
  ngOnInit() {
    const savedLang = this.isBrowser && window.localStorage
      ? localStorage.getItem('preferredLang')
      : null;

    if (savedLang) {
      this.translocoService.setActiveLang(savedLang);
    } else {
      this.translocoService.setActiveLang('he'); // ברירת מחדל
    }
  }
}