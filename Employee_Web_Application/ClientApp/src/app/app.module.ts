import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { EmployeeModule } from './Components/employee/employee.module';
import { GetAllEmployeeComponent } from './Components/employee/get-all-employee/get-all-employee.component';
import { AddEmployeeComponent } from './Components/employee/add-employee/add-employee.component';
import { UpdateEmployeeComponent } from './Components/employee/update-employee/update-employee.component';
import { DeleteEmployeeComponent } from './Components/employee/delete-employee/delete-employee.component';
import { SearchEmployeeComponent } from './Components/employee/search-employee/search-employee.component';
import { LogoutComponent } from './Components/employee/logout/logout.component';
import { HomeComponent } from './home/home.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';

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
        path: '',
        component: HomeComponent
      },
      {
        path: 'nav-menu',
        component: NavMenuComponent
      },
      {
        path: 'get-all-employee',
        component: GetAllEmployeeComponent
      },
      {
        path: 'add-employee',
        component: AddEmployeeComponent
      },
      {
        path: 'update-employee',
        component: UpdateEmployeeComponent
      },
      {
        path: 'delete-employee',
        component: DeleteEmployeeComponent
      },
      {
        path: 'search-employee',
        component: SearchEmployeeComponent
      },
      {
        path: 'login',
        component: LogoutComponent
      },
      {
        path: 'logout',
        component: LogoutComponent
      },
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
