import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { AddEmployeeComponent } from "./add-employee/add-employee.component";
import { ListEmployeeComponent } from "./list-employee/list-employee.component";

const routes:Routes=[
    {path:'add', component:AddEmployeeComponent},
    
    {path:'list', component:ListEmployeeComponent}
]

@NgModule({
    imports:[RouterModule.forChild(routes)]
})
export class EmployeeRoutingModule{}