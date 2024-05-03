import { Injectable } from '@angular/core';
import { HttpService } from './http.service';
import { ListDTO } from '../../shared/models/list/list-dto';
import { List } from '../../shared/models/list/list';

@Injectable({
  providedIn: 'root'
})
export class ListService {
  routePrefix = '/Lists';
  constructor(private httpService: HttpService) { }

  getLists(){
    return this.httpService.getRequest<ListDTO[]>(
      `${this.routePrefix}`
    );
  }

  createList(newList: ListDTO) {
    return this.httpService.postRequest<List>(
      `${this.routePrefix}`,
      newList
    );
  }
}
