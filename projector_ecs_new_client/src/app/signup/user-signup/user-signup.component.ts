import { Component, EventEmitter, inject, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { CommonModule } from '@angular/common';  
import { MatFormFieldModule } from '@angular/material/form-field';
import { TranslocoModule } from '@ngneat/transloco';
import { ReactiveFormsModule } from '@angular/forms';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { MatSelectChange, MatSelectModule } from '@angular/material/select';
import { UserAccountService } from '../../service/userAccount.service';
import { Router } from '@angular/router';


@Component({
  selector: 'app-signup',
  templateUrl: './user-signup.component.html',
  standalone: true,
  styleUrls: ['./user-signup.component.scss'],
  imports: [
    CommonModule,  
    MatFormFieldModule,
    MatSelectModule,
    TranslocoModule,
    ReactiveFormsModule,
    MatInputModule,     
    MatButtonModule    
  ],
})
export class UserSignupComponent {
  @Output() signupSuccess = new EventEmitter<void>();
  signUpForm!: FormGroup;
  private fb = inject(FormBuilder);
  private router = inject(Router);
  private _accountService = inject(UserAccountService);
  correntType:string = 'private';

  constructor() { }
  ngOnInit() {
    this.signUpForm = this.fb.group({
      userType: [''],
      name: ['', [Validators.required]],
      personalID:['', [Validators.required]],
      address:['', [Validators.required]],
      email: ['', [Validators.email]],
      phone: ['', [Validators.required,Validators.pattern('^[0-9]{9,10}$')]],
      password: ['', [Validators.required]],
    });
  }

  onSubmit() {
    console.log('Submitting form', this.signUpForm.value);
    if (this.signUpForm.valid) {
      this._accountService.register(this.signUpForm.value).subscribe({
        next: () => {
          console.log('!נרשם בהצלחה');
          this.router.navigate(['/login']);
        },
        error: () => {
          console.error('שגיאה ברישום');
        }
      });  
      this.signupSuccess.emit();
    } else {
      console.error('❌ טופס לא תקין');
    }
  }

  onChangeTypeSignUp(event : MatSelectChange){
   const selectedType = event.value;
   console.log("הסוג שממוחזר לי בעת לחצה", selectedType);
   if (selectedType === 'private' && this.correntType!='private') {
    this.router.navigate(['/usersignup']);
  } else if(selectedType === 'company' && this.correntType!='company'){
    this.router.navigate(['/companysignup']);
  }
  }
  }
