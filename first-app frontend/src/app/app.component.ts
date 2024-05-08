import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { TaskBoardComponent } from './modules/task-board/task-board/task-board.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, TaskBoardComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'first-app';
}
