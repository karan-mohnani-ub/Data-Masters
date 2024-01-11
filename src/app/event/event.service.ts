import { Injectable } from '@angular/core';
import { HttpService } from 'src/service/http.service';

@Injectable({
  providedIn: 'root'
})
export class EventService {

  constructor(public http: HttpService) { }

  getData() {
    return this.http.get('sajdjsad');
  }
}
