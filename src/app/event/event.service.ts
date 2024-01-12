import { Injectable } from '@angular/core';
import { HttpService } from 'src/service/http.service';

@Injectable({
  providedIn: 'root'
})
export class EventService {
  url = 'https://funky-eternal-alien.ngrok-free.app/predict';

  constructor(public http: HttpService) { }

  getCatalogueItemSuggestions(body: any) {
    return this.http.post(this.url, body);
  }
}
