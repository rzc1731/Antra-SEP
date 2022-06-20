import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Supplier } from 'src/interface/supplier';

@Component({
  selector: 'app-add-supplier',
  templateUrl: './add-supplier.component.html',
  styleUrls: ['./add-supplier.component.scss']
})
export class AddSupplierComponent implements OnInit {
  supplier:Supplier ={
    companyName:'',
    contactName:'',
    contactTitle:'',
    address:'',
    city:'',
    region:0,
    postalCode:'',
    country:'',
    phone:0
  
  }

  constructor() { }

  ngOnInit(): void {
  }

  insertSupplier(form:NgForm){
    console.log(form.value)
  }
  resetPage(form:NgForm){
    form.reset();
  }

}
