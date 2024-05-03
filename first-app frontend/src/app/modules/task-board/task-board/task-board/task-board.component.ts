import { Component } from '@angular/core';
import { ListComponent } from '../../list/list.component';

@Component({
  selector: 'app-task-board',
  standalone: true,
  imports: [ListComponent],
  templateUrl: './task-board.component.html',
  styleUrl: './task-board.component.css'
})
export class TaskBoardComponent {

}
