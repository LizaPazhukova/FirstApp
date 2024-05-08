import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TaskBoardComponent } from './task-board/task-board.component';
import { ListComponent } from './list/list.component';
import { CardComponent } from './card/card.component';
import { CreateCardComponent } from './card/create-card/create-card.component';



@NgModule({
  declarations: [],
  imports: [
    CommonModule, TaskBoardComponent, ListComponent, CardComponent, CreateCardComponent
  ]
})
export class TaskBoardModule { }
