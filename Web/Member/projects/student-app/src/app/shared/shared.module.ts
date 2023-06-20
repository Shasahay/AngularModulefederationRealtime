import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SearchComponent } from './search/search.component';
import { MatInputModule } from '@angular/material/input';
import { MatFormFieldModule } from '@angular/material/form-field';
import { FormsModule, ReactiveFormsModule  } from '@angular/forms';
import {MatIconModule} from '@angular/material/icon';
import { PopupComponent } from './popup/popup.component';
import {MatDialogModule} from '@angular/material/dialog';
import { CandidateComponent } from './component/candidate/candidate.component';
import { ParentComponent } from './component/parent/parent.component';
import { GuardianComponent } from './component/guardian/guardian.component';
import { TransportComponent } from './component/transport/transport.component';
import {MatStepperModule} from '@angular/material/stepper';
import { AddnewComponent } from './component/addnew/addnew.component'


@NgModule({
  declarations: [SearchComponent, PopupComponent, CandidateComponent, ParentComponent, GuardianComponent, TransportComponent, AddnewComponent],
  imports: [
    CommonModule,
    MatInputModule,
    MatFormFieldModule,
    MatIconModule,
    FormsModule,
    MatDialogModule,
    MatStepperModule,
    ReactiveFormsModule
  ],
  exports:[SearchComponent, PopupComponent]
})
export class SharedModule { }
