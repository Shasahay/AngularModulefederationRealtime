import { Component } from '@angular/core';
import { student } from '../../models/student';
import { MatDialog } from '@angular/material/dialog';
import { PopupComponent } from '../../shared/popup/popup.component';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.scss']
})
export class ListComponent {

  constructor(public dialog: MatDialog) {}

  data: student[] = [
    {id: 1, firstName:'Name 1', middleName:'middle 1', lastName:'last 1', age: 15},
    {id: 2, firstName:'Name 2', middleName:'middle 2', lastName:'last 2', age: 12},
    {id: 3, firstName:'Name 3', middleName:'middle 3', lastName:'last 3', age: 6},
    {id: 4, firstName:'Name 4', middleName:'middle 4', lastName:'last 4', age: 7},
    {id: 5, firstName:'Name 5', middleName:'middle 5', lastName:'last 5', age: 10},
  ];
  
    displayedColumns: string[] = ['id', 'firstName', 'middleName', 'lastName','age', 'actions'];

    addItem(): void {
      // Implement logic to add a new item to the data array
      const newItem: student = { id: this.data.length + 1, firstName: 'New Add Student', middleName:'New middle Name', lastName:'Add Last Name', age: 7 };
      this.data.push(newItem);
    }
    
    editItem(item: student): void {
      // Implement logic to edit an existing item in the data array
      // You can open a dialog or navigate to a separate edit page
      console.log('Edit item:', item);
    }
    
    deleteItem(item: student): void {
      // Implement logic to delete an item from the data array
      const index = this.data.indexOf(item);
      if (index >= 0) {
        this.data.splice(index, 1);
      }
    }

    openPopup() {
      const dialogRef = this.dialog.open(PopupComponent, {
        width: '60%', // Set the width to 50% of the screen
        height:'86%',
          position: {
          right: '0', // Position the popup window on the right side
          bottom:'1%'
        }
      });
    }
    
    
}
