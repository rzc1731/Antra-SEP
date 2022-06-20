import { NgModule } from "@angular/core";
import { RouterModule,Routes } from "@angular/router";
import { AddShipperComponent } from "./add-shipper/add-shipper.component";
import { ListShipperComponent } from "./list-shipper/list-shipper.component";

const routes:Routes=[
    {path:'list', component:ListShipperComponent },
    
    {path:'add', component:AddShipperComponent }
]

@NgModule(
    {
        imports:[RouterModule.forChild(routes)]
    }
)
export class ShipperRoutingModule{

}