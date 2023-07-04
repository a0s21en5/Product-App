import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { environment } from '../../../../environments/environment';
import { Employee } from '../../../Models/employee';

@Component({
  selector: 'app-get-all-employee',
  templateUrl: './get-all-employee.component.html',
  styleUrls: ['./get-all-employee.component.css']
})
export class GetAllEmployeeComponent {

  employees: Employee[] = []

  baseUrl = environment.baseUrl
  constructor(private http: HttpClient) {
    http.get<Employee[]>(this.baseUrl + 'Get').subscribe(result => {
      this.employees = result;
      //console.warn(result)
    })
  }
}
