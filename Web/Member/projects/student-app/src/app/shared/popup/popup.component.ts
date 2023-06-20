import { animate, state, style, transition, trigger } from '@angular/animations';
import { Component, HostBinding } from '@angular/core';
import { MatDialogRef } from '@angular/material/dialog';

@Component({
  selector: 'app-popup',
  templateUrl: './popup.component.html',
  styleUrls: ['./popup.component.scss'],
 
})
export class PopupComponent {
  @HostBinding('class.new-record-popup') isOpen = true;
  
  constructor(public dialogRef: MatDialogRef<PopupComponent>) {}

}
