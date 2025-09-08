import { Component, signal } from '@angular/core';

@Component({
  selector: 'app-start',
  templateUrl: './app.html',
  standalone: false,
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('');
}
