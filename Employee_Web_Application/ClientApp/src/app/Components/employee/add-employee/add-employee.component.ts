import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { environment } from '../../../../environments/environment';
import { Employee } from '../../../Models/employee';

@Component({
  selector: 'app-add-employee',
  templateUrl: './add-employee.component.html',
  styleUrls: ['./add-employee.component.css']
})
export class AddEmployeeComponent {

  baseUrl = environment.baseUrl

  employee: Employee
  constructor(private http: HttpClient, private router: Router) {
    this.employee = new Employee();
  }

  AddEmployee(registerForm: NgForm) {
    this.http.post<boolean>(this.baseUrl + 'Create', this.employee).subscribe(result => {
      //console.log(result)
      if (result) {
        this.router.navigate(['get-all-employee'])
      }
    })
  }
}






