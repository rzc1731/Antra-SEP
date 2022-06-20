import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ListSupplierComponent } from './list-supplier/list-supplier.component';
import { AddSupplierComponent } from './add-supplier/add-supplier.component';
import { SupplierRoutingModule } from './supplier-routing.module';
import { FormsModule } from '@angular/forms';



@NgModule({
  declarations: [
    ListSupplierComponent,
    AddSupplierComponent
  ],
  imports: [
    CommonModule,
    SupplierRoutingModule,
    FormsModule
  ]
})
export class SupplierModule { }
