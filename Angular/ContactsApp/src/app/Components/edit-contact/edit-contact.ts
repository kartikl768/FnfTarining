import { Component, OnInit } from '@angular/core';
import { contact } from '../../Models/contact';
import { ActivatedRoute, ParamMap, Router } from '@angular/router';
import {  ContactService } from '../../Services/contact';


@Component({
  selector: 'app-edit-contact',
  standalone: false,
  templateUrl: './edit-contact.html',
  styleUrls: ['./edit-contact.css']
})
export class EditContact implements OnInit {
  
  id : any;
  foundContact: any = {};


  constructor(
    private service: ContactService,
    private activatedRoute: ActivatedRoute,
    private nav: Router
  ) {}
  


  ngOnInit(): void {
    this.activatedRoute.paramMap.subscribe((params: ParamMap) => {
      this.id = params.get('id');
      if (this.id) {
        this.service.getContact(this.id).subscribe((data ) => {
          
          this.foundContact = data as contact;
        });
      }
    });
  }
  


  onUpdate(): void {
    this.service.updateContact(this.foundContact).subscribe(() => {
      this.nav.navigate(['/contacts/viewall']);
    });
  }
}
