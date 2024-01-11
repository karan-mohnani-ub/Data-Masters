import { Component } from '@angular/core';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { HomeService } from './home.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent {
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

  constructor(public fb: FormBuilder, public home: HomeService) { }

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
      this.home.getData().subscribe((data) => {
        console.log(data);
      });
    }
  }
}
