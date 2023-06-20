import { Component, ViewEncapsulation } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-addnew',
  templateUrl: './addnew.component.html',
  styleUrls: ['./addnew.component.scss']
  //encapsulation: ViewEncapsulation.None
})
export class AddnewComponent {
  firstFormGroup = this._formBuilder.group({
    firstCtrl: ['', Validators.required],
  });
  secondFormGroup = this._formBuilder.group({
    secondCtrl: ['', Validators.required],
  });
  isLinear = false;

  constructor(private _formBuilder: FormBuilder) {}

  submit():void{
    console.log('submit')
  }
  
}
