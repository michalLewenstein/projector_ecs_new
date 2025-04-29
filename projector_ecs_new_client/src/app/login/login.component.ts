import { Component, EventEmitter, inject, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { MatFormFieldModule } from '@angular/material/form-field';
import { TranslocoModule } from '@ngneat/transloco';
import { ReactiveFormsModule } from '@angular/forms';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { Router } from '@angular/router';
import { UserAccountService } from '../service/userAccount.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss'],
  imports: [
    CommonModule,
    MatFormFieldModule,
    TranslocoModule,
    ReactiveFormsModule,
    MatInputModule,
    MatButtonModule,
  ],
  standalone: true,
})
export class LoginComponent {
  @Output() loginSuccess = new EventEmitter<void>();
  loginForm!: FormGroup;
  private fb = inject(FormBuilder);
  private _accountService = inject(UserAccountService);
  private router = inject(Router);

  ngOnInit(): void {
    this.loginForm = this.fb.group({
      contactName: ['', [Validators.required]],
      passwors: ['', [Validators.required]],
      // email: ['', [Validators.required, Validators.email]],
    });
  }

  onSubmit() {
    if (this.loginForm.valid) {
      const userAccount = this.loginForm.value;
      console.log(userAccount);

      this._accountService.login(userAccount).subscribe({
        next: (user) => {
          console.log('התחברות הצליחה:', user);
          localStorage.setItem('user', user.contactName);
          this.router.navigate(['/home']);
          this.loginSuccess.emit();
        },
        error: (err) => {
          console.log('התחברות נכשלה:',err);
        }
      });

    } else {
      console.error('❌ טופס לא תקין');
    }
  }
}
