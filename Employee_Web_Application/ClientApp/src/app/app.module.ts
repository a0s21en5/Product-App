import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { AddEmployeeComponent } from './Components/employee/add-employee/add-employee.component';
import { DeleteEmployeeComponent } from './Components/employee/delete-employee/delete-employee.component';
import { GetAllEmployeeComponent } from './Components/employee/get-all-employee/get-all-employee.component';
import { SearchEmployeeComponent } from './Components/employee/search-employee/search-employee.component';
import { UpdateEmployeeComponent } from './Components/employee/update-employee/update-employee.component';
import { EmployeeModule } from './Components/employee/employee.module';

@NgModule({
  declarations: [
    AppComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    EmployeeModule,
    RouterModule.forRoot([
      {
        path: 'add-employee',
        component: AddEmployeeComponent
      },
      {
        path: 'delete-employee/:id',
        component: DeleteEmployeeComponent
      },
      {
        path: 'get-all-employee',
        component: GetAllEmployeeComponent
      },
      {
        path: 'search-employee',
        component: SearchEmployeeComponent
      },
      {
        path: 'update-employee/:id',
        component: UpdateEmployeeComponent
      },
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
