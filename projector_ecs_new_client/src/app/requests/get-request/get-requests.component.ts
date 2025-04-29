import { Component, OnInit } from '@angular/core';
import { RequestsService } from '../../service/request.service';


interface userRequest {
   id: string;
   authNamber:number ;
   workDescription: string;
  // location: string;
  // submitter: string;
  // registration: string;
  // status: string;
  // date: Date;
  // approved: number;
  // totalApprovers: number;
}

@Component({
  selector: 'app-get-requests',
  templateUrl: './get-requests.component.html',
  styleUrls: ['./get-requests.component.scss']
})
export class GetRequestsComponent implements OnInit {

  requests: Request[] = [];

  constructor(private requestsService: RequestsService ) { }

  ngOnInit(): void {
    this.fetchRequests();
  }

  fetchRequests(): void {
    this.requestsService.getAllRequests().subscribe({
      next: (request) => {
        console.log('Request:', request); 
        this.requests = request;
      },
      error: (err) => {
        console.error('Error fetching requests', err);
      }
    });
  }
}
