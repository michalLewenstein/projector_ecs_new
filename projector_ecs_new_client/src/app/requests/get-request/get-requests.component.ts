import { Component, OnInit } from '@angular/core';
import { RequestsService } from '../../service/request.service';
import { Request } from '../../models/request.model';
import { CommonModule } from '@angular/common';


@Component({
  selector: 'app-get-requests',
  templateUrl: './get-requests.component.html',
  styleUrls: ['./get-requests.component.scss'],
  imports: [
    CommonModule, // הוסף את זה
    
  ],
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
