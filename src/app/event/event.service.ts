import { Injectable } from '@angular/core';
import { HttpService } from 'src/service/http.service';

@Injectable({
  providedIn: 'root'
})
export class EventService {
  baseUrl = '';

  constructor(public http: HttpService) { }

  getCatalogueItemSuggestions() {
    return this.http.get(this.baseUrl + '/predict');
  }
}
