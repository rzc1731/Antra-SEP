import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { AddSupplierComponent } from "./add-supplier/add-supplier.component";
import { ListSupplierComponent } from "./list-supplier/list-supplier.component";

const routes:Routes=[
    {path:'add', component:AddSupplierComponent},
    
    {path:'list', component:ListSupplierComponent}
]

@NgModule({
    imports:[RouterModule.forChild(routes)]
})
export class SupplierRoutingModule{}