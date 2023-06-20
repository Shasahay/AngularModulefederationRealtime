import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { StudentListComponent } from './student-list/student-list.component';
import { ListComponent } from './student/list/list.component';

const routes: Routes = [
  // my seculatoun that module federation : remore js takes this routing for configuration 
  {path:'', redirectTo:'/student-list', pathMatch:'full'},
  {path:'student-list', component:StudentListComponent},
  {path:'student/list', component:ListComponent},  // this works for local and federation
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
