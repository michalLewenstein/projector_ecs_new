import { Component } from '@angular/core';
import { RequestDetails } from '../../models/requestDetails.model';
import { RequestsService } from '../../service/request.service';
import { ActivatedRoute } from '@angular/router';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatCardModule } from '@angular/material/card';
import { MatInputModule } from '@angular/material/input';
import { MatSelectModule } from '@angular/material/select';

@Component({
  selector: 'app-request-details',
  standalone: true,
  imports: [
    CommonModule,
    FormsModule,
    MatFormFieldModule,
    MatCardModule,
    MatInputModule,
    MatSelectModule
  ],
  templateUrl: './request-details.component.html',
  styleUrls: ['./request-details.component.scss']
})
export class RequestDetailsComponent {
  id = 0;
  requestDetails!: RequestDetails;

  constructor(
    private requestsService: RequestsService,
    private router: ActivatedRoute
  ) {}

  ngOnInit(): void {
    this.router.params.subscribe((param) => {
      this.id = +param['id'];
      console.log("התקבלה הבקשה של id=", this.id);

      this.requestsService.requestDetailsById(this.id).subscribe({
        next: (res) => {
          console.log("פרטי הבקשה לפי id:", res);
          this.requestDetails = res;
        },
        error: (err) => {
          console.error("שגיאה בקבלת פרטי הבקשה", err);
        }
      });
    });
  }
}
