import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { CommonModule } from '@angular/common';
import { MatButtonModule } from '@angular/material/button';
import { MatDialogModule } from '@angular/material/dialog';
import { TranslocoModule } from '@ngneat/transloco';

@Component({
  selector: 'app-session-timeout-dialog',
  template: `
    <h2 mat-dialog-title>{{ 'TOKEN_EXPIRY.title' | transloco }}</h2>
    <mat-dialog-content>
      <p>{{ 'TOKEN_EXPIRY.message' | transloco: { minutes: data.minutesLeft } }}</p>
    </mat-dialog-content>
    <mat-dialog-actions align="end">
      <button mat-button (click)="onLogout()">{{ 'TOKEN_EXPIRY.logout' | transloco }}</button>
      <button mat-raised-button color="primary" (click)="onContinue()">{{ 'TOKEN_EXPIRY.continue' | transloco }}</button>
    </mat-dialog-actions>
  `,
  standalone: true,
  imports: [
    CommonModule,
    MatDialogModule,
    MatButtonModule,
    TranslocoModule
  ]
})
export class SessionTimeoutDialogComponent {
  constructor(
    public dialogRef: MatDialogRef<SessionTimeoutDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: { minutesLeft: number }
  ) {}

  onContinue(): void {
    this.dialogRef.close(true);
  }

  onLogout(): void {
    this.dialogRef.close(false);
  }
}