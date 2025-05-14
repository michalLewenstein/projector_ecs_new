// import { Component, OnInit } from '@angular/core';
// import { RequestsService } from '../../service/request.service';
// import { Request } from '../../models/request.model';
// import { CommonModule } from '@angular/common';
// import { ActivatedRoute, Router } from '@angular/router';
// import { FormsModule } from '@angular/forms';
// import { TranslocoModule } from '@ngneat/transloco';
// import { InfiniteScrollModule } from 'ngx-infinite-scroll';

// @Component({
//   selector: 'app-get-requests',
//   templateUrl: './get-requests.component.html',
//   styleUrls: ['./get-requests.component.scss'],
//   imports: [
//     CommonModule,
//     FormsModule,
//     TranslocoModule,
//     InfiniteScrollModule
//   ],
// })
// export class GetRequestsComponent implements OnInit {
//   number?: number;
//   street?: string;
//   statusId?: number;
//   requests: Request[] = [];
//   page = 1;
//   searchPage = 0;
//   isLoading = false;

//   constructor(
//     private requestsService: RequestsService,
//   ) {}

//   ngOnInit(): void {
//     this.loadRequests();
//   }

//   loadRequests(): void {
//     if (this.isLoading && this.requests.length > 0) return;
//     console.log('טעינת בקשות עם דף: ', this.page);

//     this.isLoading = true;
//     this.requestsService.getRequestsByPage(this.page).subscribe({
//       next: (res) => {
//         if (res.length === 0) {
//           this.isLoading = false;
//           return;
//         }
//         console.log('Request:', res);
//         this.requests = [...this.requests, ...res];
//         this.isLoading = false;
//       },
//       error: (err) => {
//         console.error('Error fetching requests', err);
//         this.isLoading = false;
//       }
//     });
//   }

//   onScroll(): void {
//     console.log('Scrolled!');

//     if (this.number || this.street || this.statusId) {
//       this.searchPage++;
//       this.search();
//     } else {
//       this.page++;
//       this.loadRequests();
//     }
//   }

//   newSearch(): void {
//     this.requests = [];
//     this.searchPage = 1;
//     this.page = 1;
//     this.search();
//   }

//   search(): void {
//     if (this.isLoading) return;

//     this.isLoading = true;
//     this.requestsService.search(this.number, this.street, this.statusId, this.searchPage).subscribe({
//       next: (res) => {
//         console.log('הסינון הצליח', res);
//         if (res.length === 0) {
//           this.isLoading = false;
//           return;
//         }
//         this.requests = [...this.requests, ...res];
//         this.isLoading = false;
//       },
//       error: (err) => {
//         console.error('שגיאה אחרת התרחשה:', err);
//         this.isLoading = false;
//       }
//     });
//   }

//   clean(): void {
//     this.number = undefined;
//     this.street = '';
//     this.statusId = undefined;
//     this.page = 1;
//     this.searchPage = 0;
//     this.requests = [];
//     this.loadRequests();
//   }
// }


import { Component, OnInit, OnDestroy } from '@angular/core';
import { RequestsService } from '../../service/request.service';
import { Request } from '../../models/request.model';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { TranslocoModule } from '@ngneat/transloco';
import { InfiniteScrollModule } from 'ngx-infinite-scroll';
import { Subject, Subscription } from 'rxjs';
import { debounceTime } from 'rxjs/operators';
import { MatCard } from '@angular/material/card';

@Component({
  selector: 'app-get-requests',
  templateUrl: './get-requests.component.html',
  styleUrls: ['./get-requests.component.scss'],
  imports: [
    CommonModule,
    FormsModule,
    TranslocoModule,
    InfiniteScrollModule,
    MatCard
  ],
})
export class GetRequestsComponent implements OnInit, OnDestroy {
  number?: number;
  street?: string;
  statusId?: number;
  requests: Request[] = [];
  page = 1;
  searchPage = 0;
  isLoading = false;
  noRequest = false;
  
  private searchSubject = new Subject<void>();
  
  private subscriptions: Subscription[] = [];

  private lastNumber?: number;
  private lastStreet?: string;
  private lastStatusId?: number;

  constructor(
    private requestsService: RequestsService,
  ) {}

  ngOnInit(): void {
    this.loadRequests();
    this.setupAutoSearch();
  }

  ngOnDestroy(): void {
    this.subscriptions.forEach(sub => sub.unsubscribe());
  }

  setupAutoSearch(): void {
    const searchSub = this.searchSubject.pipe(
      debounceTime(500)
    ).subscribe(() => {
      const numberChanged = this.number !== this.lastNumber;
      const streetChanged = this.street !== this.lastStreet;
      const statusChanged = this.statusId !== this.lastStatusId;
      
      if (numberChanged || streetChanged || statusChanged) {
        this.performSearch();
      }
    });

    this.subscriptions.push(searchSub);
  }

  onNumberChange(value: number | undefined): void {
    this.number = value;
    
    if ( String(value).length >= 3) {
      this.triggerSearch();
    }
  }

  onStreetChange(value: string): void {
    this.street = value;
    if ( value.length >= 3) {
      this.triggerSearch();
    }
  }

  onStatusChange(value: number | undefined): void {
    this.statusId = value;
        if ( String(value).length >= 3) {
      this.triggerSearch();
    }
  }
  
  triggerSearch(): void {
    this.searchSubject.next();
  }

  performSearch(): void {
    const hasValidNumber = this.number !== undefined && String(this.number).length >= 3;
    const hasValidStreet = this.street && this.street.length >= 3;
    const hasValidStatus = this.statusId !== undefined && String(this.statusId).length >= 3;
    
    this.lastNumber = this.number;
    this.lastStreet = this.street;
    this.lastStatusId = this.statusId;
    
    if ((hasValidNumber || hasValidStreet || hasValidStatus)&& !(!this.street && !this.number && !this.statusId)) {
      console.log('מבצע חיפוש אוטומטי עם:', { number: this.number, street: this.street, statusId: this.statusId });
      this.requests = [];
      this.searchPage = 1;
      this.search();
    } else if (!this.street && !this.number && !this.statusId) {
      this.requests = [];
      this.page = 1;
      this.searchPage = 0;
      
      this.loadRequests();
    }
  }

  loadRequests(): void {
    if (this.isLoading && this.requests.length > 0) return;
    console.log('טעינת בקשות עם דף: ', this.page);
    this.isLoading = true;
    this.requestsService.getRequestsByPage(this.page).subscribe({
      next: (res) => {
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
    console.log('Scrolled!');
    if (this.number || this.street || this.statusId) {
      this.searchPage++;
      this.search();
    } else {
      this.page++;
      this.loadRequests();
    }
  }

  newSearch(): void {
    this.requests = [];
    this.searchPage = 1;
    this.page = 1;
    this.noRequest = false;
    this.search();
  }

  search(): void {
    if (this.isLoading) return;
    this.isLoading = true;
    this.requestsService.search(this.number, this.street, this.statusId, this.searchPage).subscribe({
      next: (res) => {
        console.log('הסינון הצליח', res);
        res.length === 0? this.noRequest = true : this.noRequest = false;   
        console.log("==================================", this.noRequest);
            
        this.requests = [...this.requests, ...res];
        this.isLoading = false;
      },
      error: (err) => {
        console.error('שגיאה אחרת התרחשה:', err);
        this.isLoading = false;
      }
    });
  }

  clean(): void {
    this.number = undefined;
    this.street = '';
    this.statusId = undefined;
    
    this.lastNumber = undefined;
    this.lastStreet = '';
    this.lastStatusId = undefined;
    
    this.page = 1;
    this.searchPage = 0;
    this.requests = [];
    this.noRequest = false
    this.loadRequests();
  }
}