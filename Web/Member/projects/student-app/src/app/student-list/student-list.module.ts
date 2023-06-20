import { Component, NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { StudentListComponent } from './student-list.component';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';



@NgModule({
  declarations: [
    StudentListComponent
  ],
  imports: [
    CommonModule,
    BrowserModule,
    RouterModule.forChild([
      {path:'', component:StudentListComponent}
    ])
  ]
})
export class StudentListModule { }
