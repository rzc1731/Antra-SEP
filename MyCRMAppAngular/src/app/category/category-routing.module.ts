import { NgModule } from "@angular/core";
import { RouterModule,Routes } from "@angular/router";
import { AddCategoryComponent } from "./add-category/add-category.component";
import { ListCategoryComponent } from "./list-category/list-category.component";

const routes:Routes=[
    {path:'list', component:ListCategoryComponent },
    
    {path:'add', component:AddCategoryComponent }
]

@NgModule(
    {
        imports:[RouterModule.forChild(routes)]
    }
)
export class CategoryRoutingModule{

}