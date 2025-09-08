import { Component } from '@angular/core';

@Component({
  selector: 'app-second',
  standalone: false,
  templateUrl: './second.html',
  styleUrl: './second.css'
})
export class Second {
  year : number = new Date().getFullYear();
}
