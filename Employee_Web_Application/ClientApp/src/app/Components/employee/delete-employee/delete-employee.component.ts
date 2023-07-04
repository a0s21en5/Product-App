import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { environment } from '../../../../environments/environment';
import { Employee } from '../../../Models/employee';

@Component({
  selector: 'app-delete-employee',
  templateUrl: './delete-employee.component.html',
  styleUrls: ['./delete-employee.component.css']
})
export class DeleteEmployeeComponent implements OnInit {

  baseUrl = environment.baseUrl

  employee: Employee
  constructor(private http: HttpClient, private activatedRoute: ActivatedRoute, private router: Router) {
    this.employee = new Employee()
  }

  ngOnInit(): void {
    const id = this.activatedRoute.snapshot.paramMap.get('id');
    this.DeleteEmployee(id);
  }

  DeleteEmployee(id: any) {
    this.http.delete<boolean>(this.baseUrl + 'Delete/' + id);
  }
}
