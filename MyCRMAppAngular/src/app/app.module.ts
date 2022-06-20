import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EmployeeModule } from './employee/employee.module';
import { RegionModule } from './region/region.module';
import { ProductModule } from './product/product.module';
import { SupplierModule } from './supplier/supplier.module';
import { CustomerModule } from './customer/customer.module';
import { CategoryModule } from './category/category.module';
import { ShipperModule } from './shipper/shipper.module';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    EmployeeModule,
    RegionModule,
    ProductModule,
    SupplierModule,
    CustomerModule,
    CategoryModule,
    ShipperModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
