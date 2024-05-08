import { CommonModule } from '@angular/common';
import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';

@Component({
  selector: 'app-create-card',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './create-card.component.html',
  styleUrl: './create-card.component.css'
})
export class CreateCardComponent {

  constructor(public dialogRef: MatDialogRef<CreateCardComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any){}


  close(){
    this.dialogRef.close();
  }
}
