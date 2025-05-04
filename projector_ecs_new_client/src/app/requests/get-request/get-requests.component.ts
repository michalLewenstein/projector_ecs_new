import { Component, OnInit } from '@angular/core';
import { RequestsService } from '../../service/request.service';
import { Request } from '../../models/request.model';
import { CommonModule } from '@angular/common';
import { ActivatedRoute, Router } from '@angular/router';
import { FormsModule } from '@angular/forms';


@Component({
  selector: 'app-get-requests',
  templateUrl: './get-requests.component.html',
  styleUrls: ['./get-requests.component.scss'],
  imports: [
    CommonModule,
    FormsModule
    
  ],
})
export class GetRequestsComponent implements OnInit {

  id? : number;
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
   this.requestsService.search(this.id, this.street, this.statusId).subscribe({
    next: (res)=>{
      console.log("הסינון הצליח", res);
      this.requests = res;
    },
    error: (err) => {
      console.log("שגיאה אחרת התרחשה:", err);
    }
   })
  }
}
