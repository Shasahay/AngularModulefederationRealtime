import { Component } from '@angular/core';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.scss']
})
export class SearchComponent {
  searchValue: string = '';

  handleSearch(): void {
    // Implement your search logic here
    console.log('Search value:', this.searchValue);
  }
}
