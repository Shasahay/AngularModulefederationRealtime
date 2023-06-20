import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-candidate',
  templateUrl: './candidate.component.html',
  styleUrls: ['./candidate.component.scss']
})
export class CandidateComponent {
  newStudentForm: FormGroup;

  constructor(private formBuilder: FormBuilder) {}

  ngOnInit() {
    this.newStudentForm = this.formBuilder.group({
      firstName: ['', Validators.required],
      lastName: ['', Validators.required],
      email: ['', [Validators.required, Validators.email]],
      phoneNumber: ['', Validators.required]
    });
  }

  onSubmit() {
    if (this.newStudentForm.valid) {
      // Perform actions with the form data
      console.log(this.newStudentForm.value);
    }
  }
}
