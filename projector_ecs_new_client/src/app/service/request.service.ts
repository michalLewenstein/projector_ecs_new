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
  ) { }

  getAllRequests(): Observable<Request[]> {
    return this._http.get<Request[]>(this.apiUrl,{ withCredentials: true });
  }

  // getRequestById(id: number): Observable<Request> {
  //   return this._http.get<Request>(`${this.apiUrl}/${id}`);
  // }

  // deleteRequest(id: number): Observable<any> {
  //   return this._http.delete(`${this.apiUrl}/${id}`);
  // }
  search(id?: number, street?: string, statusId?: number): Observable<Request[]> {
    let params: any = {};
  
    if (id !== undefined) params.id = id;
    if (street) params.street = street;
    if (statusId !== undefined) params.statusId = statusId;
  
    return this._http.get<Request[]>(`${this.apiUrl}/search`, {
      params,
      withCredentials: true
    });
  }
}
