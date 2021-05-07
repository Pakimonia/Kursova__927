import { NgModule, Component} from '@angular/core';
import { Routes, RouterModule, CanActivate } from '@angular/router';
import { AddAdminComponent } from './add-admin/add-admin.component';
import { AddClassProductComponent } from './add-class-product/add-class-product.component';
import { AddManagerComponent } from './add-manager/add-manager.component';
import { AddProductComponent } from './add-product/add-product.component';
import { AddTypeClassComponent } from './add-type-class/add-type-class.component';
import { AdminPanelComponent } from './admin-panel/admin-panel.component';
import { LoginComponent } from './Auth/Login/Login.component';
import { RegisterComponent } from './Auth/Register/Register.component';
import { AdminGuard } from './Guards/admin.guard';
import { ManagerGuard } from './Guards/manager.guard';
import { NotLoginGuard } from './Guards/notLogin.guard';
import { UserGuard } from './Guards/user.guard';
import { HomeComponent } from './home/home.component';
import { ManageProductsComponent } from './manage-products/manage-products.component';
import { ManagerPanelComponent } from './manager-panel/manager-panel.component';
import { TestComponent } from './test/test.component';
import { UserProfileComponent } from './user-profile/user-profile.component';

const routes: Routes = [
    { path:'', redirectTo: 'home', pathMatch:'full'},
    { path:'home', component: HomeComponent, pathMatch:'full'},
    { path:'login', component:LoginComponent,canActivate:[NotLoginGuard], pathMatch:'full'},
    { path:'register', component:RegisterComponent,canActivate:[NotLoginGuard], pathMatch:'full'},
    { path:'admin-panel', component:AdminPanelComponent,canActivate:[AdminGuard], pathMatch:'full'},
        { path:'add-admin', component:AddAdminComponent,canActivate:[ManagerGuard], pathMatch:'full'},
        { path:'add-manager', component:AddManagerComponent,canActivate:[ManagerGuard], pathMatch:'full'},
        { path:'add-type-class', component:AddTypeClassComponent,canActivate:[ManagerGuard], pathMatch:'full'},
        { path:'add-class-product', component:AddClassProductComponent,canActivate:[ManagerGuard], pathMatch:'full'},
    { path:'manager-panel', component:ManagerPanelComponent,canActivate:[ManagerGuard], pathMatch:'full'},
        { path:'manage-products', component:ManageProductsComponent,canActivate:[ManagerGuard], pathMatch:'full'},
        { path:'add-product', component:AddProductComponent,canActivate:[ManagerGuard], pathMatch:'full'},
    { path:'user-profile', component:UserProfileComponent,canActivate:[UserGuard], pathMatch:'full'},
    { path:'test', component: TestComponent, pathMatch:'full'},
];

@NgModule({ 

    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule],
})

export class AppRoutingModule { }