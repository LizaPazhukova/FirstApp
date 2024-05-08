import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { MatIconModule } from '@angular/material/icon';
import { CreateCardComponent } from './create-card/create-card.component';
import {MatDialog, MatDialogModule} from '@angular/material/dialog';

@Component({
  selector: 'app-card',
  standalone: true,
  imports: [MatIconModule, CommonModule, CreateCardComponent, MatDialogModule],
  templateUrl: './card.component.html',
  styleUrl: './card.component.css'
})
export class CardComponent {

  constructor(public dialog: MatDialog){}


  public openCreateCard(){
    
    const dialogRef = this.dialog.open(CreateCardComponent);

    dialogRef.afterClosed().subscribe(result => {
      console.log(`Dialog result: ${result}`);
    });
  }
}
