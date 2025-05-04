import { Injectable } from '@angular/core';
import { Observable, of, throwError } from 'rxjs';
import { UserAccount } from '../models/userAccount.model';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class UserAccountService {
  private apiUrl ='https://localhost:7294/api/User'


  constructor(
    private _http: HttpClient,
    private _router: Router,

  ) { }
  login(userAccount: UserAccount): Observable<UserAccount> {
    return this._http.post<UserAccount>(`${this.apiUrl}/login`, userAccount, { withCredentials: true }); 
  }
  
  register(userAccount:UserAccount): Observable<UserAccount> {
    return this._http.post<UserAccount>(`${this.apiUrl}/register`, userAccount);
  }

  logout(): void {
    localStorage.removeItem('user');
  }

  isLoggedIn(): boolean {
    return !!localStorage.getItem('user');
  }

  getUsername(): string | null {
    return localStorage.getItem('user');
  }
}
