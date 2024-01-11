import { Injectable } from '@angular/core';
import { HttpService } from 'src/service/http.service';

@Injectable({
  providedIn: 'root'
})
export class HomeService {

  constructor(public http: HttpService) { }

  getData() {
    return this.http.get('sajdjsad');
  }
}
