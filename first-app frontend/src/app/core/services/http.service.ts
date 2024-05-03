import { Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';
import { HttpClient, HttpParams } from '@angular/common/http';

export type Params = HttpParams | { [param: string]: string | string[]; };

@Injectable({
  providedIn: 'root'
})
export class HttpService {
  baseUrl: string = environment.apiUrl;
  
  constructor(private readonly http: HttpClient) { }

  getRequest<T>(url: string, httpParams?: Params) {
    return this.http.get<T>(this.buildUrl(url), {
      params: httpParams,
    });
  }

  postRequest<T>(url: string, payload: object) {
    return this.http.post<T>(this.buildUrl(url), payload);
  }

  putRequest<T>(url: string, payload: object) {
    return this.http.put<T>(this.buildUrl(url), payload);
  }

  deleteRequest<T>(url: string, httpParams?: Params) {
    return this.http.delete<T>(this.buildUrl(url), {
      params: httpParams,
    });
  }

  buildUrl(url: string) {
    return /^https?:\/\/.+/.test(url) ? url : this.baseUrl.concat(url);
  }
}
