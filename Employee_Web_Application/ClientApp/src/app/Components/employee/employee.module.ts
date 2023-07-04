import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { GetAllEmployeeComponent } from './get-all-employee/get-all-employee.component';
import { AddEmployeeComponent } from './add-employee/add-employee.component';
import { UpdateEmployeeComponent } from './update-employee/update-employee.component';
import { DeleteEmployeeComponent } from './delete-employee/delete-employee.component';
import { SearchEmployeeComponent } from './search-employee/search-employee.component';
import { FormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    GetAllEmployeeComponent,
    AddEmployeeComponent,
    UpdateEmployeeComponent,
    DeleteEmployeeComponent,
    SearchEmployeeComponent
  ],
  imports: [
    CommonModule,
    FormsModule
  ],
  exports: [
    GetAllEmployeeComponent,
    AddEmployeeComponent,
    UpdateEmployeeComponent,
    DeleteEmployeeComponent,
    SearchEmployeeComponent
  ]
})
export class EmployeeModule { }
