import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'host-app';
  isMenuExpanded = false;

  toggleMenu(): void {
    this.isMenuExpanded = !this.isMenuExpanded;
  }
}
