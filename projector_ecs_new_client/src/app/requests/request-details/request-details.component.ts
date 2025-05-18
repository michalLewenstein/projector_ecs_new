import { Component } from '@angular/core';
import { RequestDetails } from '../../models/requestDetails.model';
import { RequestsService } from '../../service/request.service';
import { ActivatedRoute } from '@angular/router';
import { MatFormField, MatLabel } from '@angular/material/form-field';
import { MatCard, MatCardContent, MatCardHeader, MatCardSubtitle, MatCardTitle } from '@angular/material/card';
import { MatInputModule } from '@angular/material/input';
import { CommonModule } from '@angular/common';
import { TranslocoModule } from '@ngneat/transloco';

@Component({
  selector: 'app-request-details',
  imports: [
    CommonModule,
    MatFormField,
    MatCard,
    MatCardHeader,
    MatCardTitle,
    MatCardSubtitle,
    MatCardContent,
    MatLabel,
    MatInputModule,
    TranslocoModule
  ],
  templateUrl: './request-details.component.html',
  styleUrl: './request-details.component.scss'
})
export class RequestDetailsComponent {
 id = 0;
 requestDetails!:RequestDetails;

 constructor(
  private requestsService: RequestsService,
  private router: ActivatedRoute
  ){}

 ngOnInit(): void {
  this.router.params.subscribe((param) => {
    this.id = +param['id'];
    console.log("התקבלה הבקשה של id=", this.id);
    
    this.requestsService.requestDetailsById(this.id).subscribe({
      next: (res) => {
        console.log("פרטי הבקשה לפי is:", res);
        
        this.requestDetails = res;
      },
      error: (err) => {
        console.log("err", err);
      }
    });
  });
}
}
