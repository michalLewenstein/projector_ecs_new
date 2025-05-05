import { Component, OnInit } from '@angular/core';
import { RequestsService } from '../../service/request.service';
import { Request } from '../../models/request.model';
import { CommonModule } from '@angular/common';
import { ActivatedRoute, Router } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { TranslocoModule } from '@ngneat/transloco';


@Component({
  selector: 'app-get-requests',
  templateUrl: './get-requests.component.html',
  styleUrls: ['./get-requests.component.scss'],
  imports: [
    CommonModule,
    FormsModule,
    TranslocoModule
    
  ],
})
export class GetRequestsComponent implements OnInit {

  number? : number;
  street?: string;
  statusId?: number;
  requests: Request[] = [];

  constructor(private requestsService: RequestsService,private route : ActivatedRoute , private router:Router) { }

  ngOnInit(): void {
    // this.route.paramMap.subscribe(params => {
    // const searchType = params.get('search')  ;
    // this.fetchRequests(() => {
    //   if(searchType){
    //     this.search();
    //   }
    // });
    // })
    this.fetchRequests();
  }
  

  fetchRequests(): void {
    console.log("try get all requests");
    this.requestsService.getAllRequests().subscribe({
      next: (res) => {
        console.log('Request:', res); 
        this.requests = res;
        // if (callback) { 
        //   callback();
        // }
      },
      error: (err) => {
        console.error('Error fetching requests', err);
      }
    });
  }
  goToSearch(word: string) {
    this.router.navigate(['/getrequest', word]);

  }
  search(){
    console.log("מספר:", this.number);
    console.log("רחוב:", this.street);
    console.log("מזהה:", this.statusId);
   this.requestsService.search(this.number, this.street, this.statusId).subscribe({
    next: (res)=>{
      console.log("הסינון הצליח", res);
      this.requests = res;
    },
    error: (err) => {
      console.log("שגיאה אחרת התרחשה:", err);
    }
   })
  }
  clean(){
    this.number = undefined;
    this.street = '';
    this.statusId = undefined;
    this.fetchRequests();
  }
}
