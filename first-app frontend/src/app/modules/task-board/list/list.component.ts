import { Component, OnInit } from '@angular/core';
import { ListService } from '../../../core/services/list.service';
import { Observable } from 'rxjs';
import { CommonModule } from '@angular/common';
import { ListDTO } from '../../../shared/models/list/list-dto';
import { CardComponent } from '../card/card.component';

@Component({
  selector: 'app-list',
  standalone: true,
  imports: [CommonModule, CardComponent],
  templateUrl: './list.component.html',
  styleUrl: './list.component.css'
})
export class ListComponent implements OnInit {
  lists$!: Observable<ListDTO[]>;
  constructor(private listService: ListService){}
  ngOnInit(): void {
    this.lists$ = this.getLists();
  }

  getLists(){
    return this.listService.getLists();
  }

}
