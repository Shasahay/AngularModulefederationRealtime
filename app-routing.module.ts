import { loadRemoteModule } from '@angular-architects/module-federation';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const STUDENT_APP_URL = "http://localhost:4400/remoteEntry.js";
const STUDENT_ADMISSION_APP_URL = "http://localhost:4600/remoteEntry.js";
const routes: Routes = [
  //{path:'', redirectTo:'/home', pathMatch:'full'},

  
  {path:'student-list', loadChildren:() => {
    return loadRemoteModule({
      remoteEntry : STUDENT_APP_URL,
      remoteName:"studentApp",
      exposedModule:"./StudentListModule"
    }).then( m=> m.StudentListModule).catch(err=> console.log(err))
  }  },
  {path:'student/list', loadChildren:() => {
    return loadRemoteModule({
      remoteEntry : STUDENT_APP_URL,
      remoteName:"studentApp",
      exposedModule:"./StudentModule"
    }).then( m=> m.StudentModule).catch(err=> console.log(err))
  }  },
    // Registration remote
 { path:'admission/registration', loadChildren:() =>{
   return loadRemoteModule({
     remoteEntry: STUDENT_ADMISSION_APP_URL,
     remoteName:"admissionApp",
     exposedModule:"./RegistrationModule",
        }).then( x=> x.RegistrationModule).catch( err=> console.log(err))
 }
}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
