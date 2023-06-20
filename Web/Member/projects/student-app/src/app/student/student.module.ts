import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ListComponent } from './list/list.component';
import { RouterModule, Routes } from '@angular/router';
import { AddComponent } from './add/add.component';
import { MatTableModule } from '@angular/material/table';
import { SharedModule } from '../shared/shared.module';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { FormsModule } from '@angular/forms';
import { MatInputModule } from '@angular/material/input';



const sroutes: Routes = [
  // { path:'', redirectTo:'/student/list', pathMatch:'full'},
  //{path:'student/list', component:ListComponent}  // this does not work for federation but for local
  {path:'', component:ListComponent} // this + routing combined works for federation and  for local
]

@NgModule({
  declarations: [ListComponent, AddComponent],
  imports: [
    CommonModule,
    MatTableModule,
    SharedModule,
    MatButtonModule,
    MatIconModule,
    FormsModule,
    MatInputModule,
    RouterModule.forChild(sroutes)
  ]
})
export class StudentModule { }
