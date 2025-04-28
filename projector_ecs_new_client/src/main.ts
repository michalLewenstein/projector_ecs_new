import { bootstrapApplication } from '@angular/platform-browser';
import { AppComponent } from './app/app.component';
import { provideHttpClient } from '@angular/common/http';
import { provideTransloco, TRANSLOCO_LOADER } from '@ngneat/transloco';
import { TranslocoLoader } from '@ngneat/transloco';
import { provideRouter } from '@angular/router';
import { routes } from './app/app.routes';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
class TranslocoHttpLoader implements TranslocoLoader {
  constructor(private http: HttpClient) {}

  getTranslation(lang: string) {
    return this.http.get(`/assets/i18n/${lang}.json`);
  }
}

bootstrapApplication(AppComponent, {
  providers: [
    provideHttpClient(),
    provideRouter(routes),

    provideTransloco({
      config: {
        availableLangs: ['en', 'he'],
        fallbackLang: 'en',
        reRenderOnLangChange: true,
        prodMode: false,
      },
    }),

    {
      provide: TRANSLOCO_LOADER,
      useClass: TranslocoHttpLoader,
    },
  ],
});