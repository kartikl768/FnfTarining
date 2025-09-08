import { Component, OnInit } from '@angular/core';
import { contact } from '../../Models/contact';
import { ActivatedRoute, ParamMap, Router } from '@angular/router';
import {  ContactService } from '../../Services/contact';

@Component({
  selector: 'app-new-contact',
  standalone: false,
  templateUrl: './new-contact.html',
  styleUrl: './new-contact.css'
})
export class NewContact {
  newContact: any = {} ;

  constructor(
    private service: ContactService,
    private activatedRoute: ActivatedRoute,
    private nav: Router
  ) {}

  onSubmit() {
    this.service.addContact(this.newContact).subscribe((data) => {
      this.nav.navigate(['/Contact/viewall']);
    });
  }
}
