import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { Request } from '../models/request.model';

@Injectable({
  providedIn: 'root'
})
export class RequestsService {
  private apiUrl = 'https://localhost:7294/api/Requests'; 

  constructor(
    private _http: HttpClient,
    private _router: Router
  ) { }

  getAllRequests(): Observable<Request[]> {
    return this._http.get<Request[]>(this.apiUrl);
  }

  getRequestById(id: number): Observable<Request> {
    return this._http.get<Request>(`${this.apiUrl}/${id}`);
  }

  deleteRequest(id: number): Observable<any> {
    return this._http.delete(`${this.apiUrl}/${id}`);
  }
}
