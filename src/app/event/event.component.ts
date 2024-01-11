import { Component } from '@angular/core';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { EventService } from './event.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: './event.component.html',
  styleUrls: ['./event.component.scss']
})
export class EventComponent {
  public form!: FormGroup;
  category = [
    { value: 'wedding', viewValue: 'Wedding' },
    { value: 'birthday', viewValue: 'Birthday' },
    { value: 'dance', viewValue: 'Dance' },
  ];
  contact = [
    { value: 'wedding', viewValue: 'Wedding' },
    { value: 'birthday', viewValue: 'Birthday' },
    { value: 'dance', viewValue: 'Dance' },
  ];

  constructor(public fb: FormBuilder, public eventService: EventService, public router: Router) { }

  ngOnInit() {
    this.createForm();
  }

  createForm() {
    this.form = this.fb.group({
      eventName: new FormControl(''),
      category: new FormControl(''),
      contact: new FormControl(''),
      startDate: new FormControl(''),
      endDate: new FormControl(''),
    });
  }

  submit() {
    if (this.form.valid) {
      console.log(this.form.value);
      this.eventService.getData().subscribe((data) => {
        console.log(data);
      });
    }
  }
}
