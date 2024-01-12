import { Component } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { EventService } from './event.service';
import { Router } from '@angular/router';
import { MatSnackBar, MatSnackBarVerticalPosition } from '@angular/material/snack-bar';
import { SnackbarComponent } from '../snackbar/snackbar.component';
@Component({
  selector: 'app-home',
  templateUrl: './event.component.html',
  styleUrls: ['./event.component.scss']
})

export class EventComponent {
  public form!: FormGroup;
  verticalPosition: MatSnackBarVerticalPosition = 'top';
  category = [
    { value: 'ChristmasEvent', viewValue: 'Christmas Event' },
    { value: 'NewYear', viewValue: 'New Year' },
    { value: 'Birthday', viewValue: 'Birthday' },
    { value: 'TradeShows', viewValue: 'Trade Shows' },
    { value: 'Anniversaries', viewValue: 'Anniversaries' },
    { value: 'Weddings', viewValue: 'Weddings' },
    { value: 'EducationalConferences', viewValue: 'Educational Conferences' },
    { value: 'Concerts', viewValue: 'Concerts' },
    { value: 'Festivals', viewValue: 'Festivals' },
    { value: 'CharityEvents', viewValue: 'Charity Events' },
  ];
  contact = [
    { value: 'Emma', viewValue: 'Emma' },
    { value: 'Liam', viewValue: 'Liam' },
    { value: 'Olivia', viewValue: 'Olivia' },
    { value: 'Noah', viewValue: 'Noah' },
    { value: 'Ava', viewValue: 'Ava' },
    { value: 'Sophia', viewValue: 'Sophia' },
    { value: 'Jackson', viewValue: 'Jackson' },
    { value: 'Aiden', viewValue: 'Aiden' },
    { value: 'Lucas', viewValue: 'Lucas' },
    { value: 'Mia', viewValue: 'Mia' },
    { value: 'Ethan', viewValue: 'Ethan' },
    { value: 'Isabella', viewValue: 'Isabella' },
    { value: 'Caden', viewValue: 'Caden' },
    { value: 'Amelia', viewValue: 'Amelia' },
    { value: 'Harper', viewValue: 'Harper' },
    { value: 'Elijah', viewValue: 'Elijah' },
    { value: 'Abigail', viewValue: 'Abigail' },
    { value: 'Benjamin', viewValue: 'Benjamin' },
    { value: 'Emily', viewValue: 'Emily' },
    { value: 'Oliver', viewValue: 'Oliver' },
  ];
  catalogueItems: string[] = [];

  constructor(public fb: FormBuilder, public eventService: EventService, public router: Router, public snackBar: MatSnackBar) { }

  ngOnInit() {
    this.createForm();
  }

  createForm() {
    this.form = this.fb.group({
      eventName: new FormControl('', Validators.required),
      eventCategory: new FormControl('', Validators.required),
      contact: new FormControl(''),
      startDate: new FormControl(''),
      endDate: new FormControl(''),
      catalogueItems: new FormControl(''),
    });
  }

  remove(item: string) {
    const index = this.catalogueItems.indexOf(item);
    if (index >= 0) {
      this.catalogueItems.splice(index, 1);

    }
  }

  add(eve: any) {

  }

  getSuggestions() {
    let result = {
      "Bloody mary": 0.15068662,
      "Burger": 0.14528053,
      "Coke": 0.14225063,
      "Blue lagoon": 0.09363038,
      "Platter": 0.09363038,
      "Pizza": 0.09363038,
      "Noodles": 0.09363038,
      "Fries": 0.09363038,
      "Paneer": 0.09363038
    };
    let slicedObj = Object.fromEntries(Object.entries(result).slice(0, 3))
    console.log(slicedObj);

    for (let item in slicedObj) {
      this.catalogueItems.push(item)
    }
    console.log(this.catalogueItems)
    this.snackBar.openFromComponent(SnackbarComponent, {
      duration: 3000,
      verticalPosition: this.verticalPosition,
    });
    // console.log(this.form)
    // if (this.form.valid) {
    //   console.log(this.form.value);
    //   this.eventService.getCatalogueItemSuggestions(this.form.value).subscribe((data) => {
    //     console.log(data);
    //     let slicedObj = Object.fromEntries(Object.entries(data).slice(0, 3))
    //     console.log(slicedObj);

    //     for (let item in slicedObj) {
    //       this.catalogueItems.push(item)
    //     }
    //     console.log(this.catalogueItems)
    //   });
    // this.snackBar.openFromComponent(SnackbarComponent, {
    //   duration: 3000,
    //   verticalPosition: this.verticalPosition,
    // });
    // }
  }

  submit() {
    this.snackBar.openFromComponent(SnackbarComponent, {
      duration: 3000,
      verticalPosition: this.verticalPosition,
    });
  }
}