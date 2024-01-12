import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-event-list',
  templateUrl: './event-list.component.html',
  styleUrls: ['./event-list.component.scss']
})
export class EventListComponent {
  public eventList = [
    {
      eventId: '123',
      eventName: 'Demo Event 1',
      startDate: '01/12/22',
      endDate: '02/12/22'
    },
    {
      eventId: '124',
      eventName: 'Demo Event 2',
      startDate: '01/12/23',
      endDate: '02/12/23'
    },
    {
      eventId: '125',
      eventName: 'Demo Event 3',
      startDate: '01/11/22',
      endDate: '01/12/22'
    },
    {
      eventId: '126',
      eventName: 'Demo Event 4',
      startDate: '02/12/22',
      endDate: '03/12/22'
    },
  ]

  constructor(public router: Router) {}
}
