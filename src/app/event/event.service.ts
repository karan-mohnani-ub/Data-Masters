import { Injectable } from '@angular/core';
import { HttpService } from 'src/service/http.service';

@Injectable({
  providedIn: 'root'
})
export class EventService {
  url = 'https://localhost:65336/predict';

  constructor(public http: HttpService) { }

  getCatalogueItemSuggestions(body: any) {
    return this.http.post(this.url, body);
  }
}
