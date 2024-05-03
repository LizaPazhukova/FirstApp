import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TaskBoardComponent } from './task-board/task-board/task-board.component';
import { ListComponent } from './list/list.component';



@NgModule({
  declarations: [],
  imports: [
    CommonModule, TaskBoardComponent, ListComponent
  ]
})
export class TaskBoardModule { }
