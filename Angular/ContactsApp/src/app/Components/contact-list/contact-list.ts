import { Component, OnInit } from '@angular/core';
import { contact } from '../../Models/contact';
import { ContactService } from '../../Services/contact';
import { Router } from '@angular/router';

@Component({
  selector: 'app-contact-list',
  standalone: false,
  templateUrl: './contact-list.html',
  styleUrls: ['./contact-list.css']
})
export class ContactList implements OnInit {
  contactList: any = [];

  constructor(private service: ContactService, private route: Router) {}

  ngOnInit(): void {
    this.service.getAllContacts().subscribe((data: contact[]) => {
      this.contactList = data;
    });
  }

  delete(id: number): void {
    this.service.deleteContact(id).subscribe(() => {
      this.contactList = this.contactList.filter((c: contact) => c.contactId !== id);
      alert('Contact deleted successfully.');
      location.reload();
    }); 
  }
}
