import { Component, inject } from '@angular/core';
import { MatIcon } from '@angular/material/icon';
import { DIALOG_DATA, DialogRef } from '@angular/cdk/dialog';

@Component({
  selector: 'app-confirm-dialog',
  standalone: true,
  imports: [MatIcon],
  templateUrl: './confirm-dialog.component.html',
})
export class ConfirmDialogComponent {
  private dialogRef = inject(DialogRef);
  public data = inject(DIALOG_DATA);

  close(result: boolean) {
    this.dialogRef.close(result);
  }
}
