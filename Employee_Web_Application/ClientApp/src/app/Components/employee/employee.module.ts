import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { GetAllEmployeeComponent } from './get-all-employee/get-all-employee.component';
import { AddEmployeeComponent } from './add-employee/add-employee.component';
import { UpdateEmployeeComponent } from './update-employee/update-employee.component';
import { DeleteEmployeeComponent } from './delete-employee/delete-employee.component';
import { LoginComponent } from './login/login.component';
import { LogoutComponent } from './logout/logout.component';
import { SearchEmployeeComponent } from './search-employee/search-employee.component';



@NgModule({
  declarations: [
    GetAllEmployeeComponent,
    AddEmployeeComponent,
    UpdateEmployeeComponent,
    DeleteEmployeeComponent,
    SearchEmployeeComponent,
    LoginComponent,
    LogoutComponent
  ],
  imports: [
    CommonModule
  ],
  exports: [
    GetAllEmployeeComponent,
    AddEmployeeComponent,
    UpdateEmployeeComponent,
    DeleteEmployeeComponent,
    SearchEmployeeComponent,
    LoginComponent,
    LogoutComponent
  ]
})
export class EmployeeModule { }
