import { Component, inject } from '@angular/core';
import { ErrorsService } from '../../../services/errors.service';
import { MatIcon } from '@angular/material/icon';
import { DialogRef } from '@angular/cdk/dialog';

@Component({
  selector: 'app-error-dialog',
  standalone: true,
  imports: [MatIcon],
  templateUrl: './error-dialog.component.html',
})
export class ErrorDialogComponent {
  errorsService = inject(ErrorsService);
  private dialogRef = inject(DialogRef);

  close() {
    this.dialogRef.close();
    this.errorsService.clear();
  }
}
