import { Component, OnInit } from '@angular/core';
import { RequestsService } from '../../service/request.service';
import { Request } from '../../models/request.model';
import { CommonModule } from '@angular/common';
import { ActivatedRoute, Router } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { TranslocoModule } from '@ngneat/transloco';
import { InfiniteScrollModule } from 'ngx-infinite-scroll';



@Component({
  selector: 'app-get-requests',
  templateUrl: './get-requests.component.html',
  styleUrls: ['./get-requests.component.scss'],
  imports: [
    CommonModule,
    FormsModule,
    TranslocoModule,
    InfiniteScrollModule
  ],
})
export class GetRequestsComponent implements OnInit {

  number?: number;
  street?: string;
  statusId?: number;
  prevNumber?: number;
  prevStreet?: string;
  prevStatusId?: number;
  requests: Request[] = [];
  page = 1;
  searchPage = 0;
  isLoading = false;

  constructor(private requestsService: RequestsService, private route: ActivatedRoute, private router: Router) { }

  ngOnInit(): void {
    this.loadRequests();
  }


  loadRequests(): void {
    if (this.isLoading ) return;

    this.isLoading = true;
    this.requestsService.getRequestsByPage(this.page).subscribe({
      next: (res) => {
        if (res.length === 0) {          return;
        }
        console.log('Request:', res);
        this.requests = [...this.requests, ...res];
        this.isLoading = false;
      },
      error: (err) => {
        console.error('Error fetching requests', err);
        this.isLoading = false;
      }
    });
  }

  onScroll(): void {
    if (this.searchPage > 0) {
      this.searchPage++;
      this.search();
    }
    else {
      this.page++;
      this.loadRequests();
    }
  }

ssearch(){
  this.requests = [];
  this.searchPage = 1;
  this.search();
}
  search() {
    if (this.isLoading ) return;

    this.isLoading = true;
    this.requestsService.search(this.number, this.street, this.statusId, this.searchPage).subscribe({
      next: (res) => {
        console.log("הסינון הצליח", res);
        if (res.length === 0) {
          return;
        }
        this.requests = [...this.requests, ...res];
        this.isLoading = false;

      },
      error: (err) => {
        console.log("שגיאה אחרת התרחשה:", err);
      }
    })
  }
  clean() {
    this.number = undefined;
    this.street = '';
    this.statusId = undefined;
    this.page = 1;
    this.searchPage = 0;
    this.requests = [];
    this.loadRequests();
  }
}
