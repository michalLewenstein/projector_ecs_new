import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Request } from '../models/request.model';

@Injectable({
  providedIn: 'root'
})
export class RequestsService {
  private apiUrl = 'https://localhost:7294/api/Requests'; 

  constructor(
    private _http: HttpClient,
  ) { }

  getRequestsByPage(page: number): Observable<Request[]> {
    return this._http.get<Request[]>(`${this.apiUrl}?page=${page}`,{ withCredentials: true });
  }

  search(number?: number, street?: string, statusId?: number, page? : number): Observable<Request[]> {
    let params: any = {};
    if (number !== undefined) params.number = number;
    if (street) params.street = street;
    if (statusId !== undefined) params.statusId = statusId;
    if(page !==undefined) params.page = page;
    console.log("החיפוש שנשלח:", params);
    
    return this._http.get<Request[]>(`${this.apiUrl}/search`, {
      params,
      withCredentials: true
    });
  }
}
