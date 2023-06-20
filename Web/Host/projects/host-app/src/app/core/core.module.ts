import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NavBarComponent } from './nav-bar/nav-bar.component';
import {MatListModule} from '@angular/material/list';
import { MatSidenavModule } from '@angular/material/sidenav';
import { BrowserModule } from '@angular/platform-browser';
//import { SidebarComponent } from './sidebar/sidebar.component';
import {MatIconModule} from '@angular/material/icon';
import {MatToolbarModule} from '@angular/material/toolbar';
import {MatExpansionModule} from '@angular/material/expansion';

import { RouterModule } from '@angular/router';
@NgModule({
  declarations: [NavBarComponent],
  imports: [
    CommonModule,
    MatListModule,
    MatSidenavModule,
    BrowserModule,
    MatIconModule,
    MatToolbarModule,
    MatExpansionModule,
    RouterModule
  ],
  exports:[NavBarComponent]
})
export class CoreModule { }
