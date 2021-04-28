import { NgModule, Component} from '@angular/core';
import { Routes, RouterModule, CanActivate } from '@angular/router';
import { AdminPanelComponent } from './admin-panel/admin-panel.component';
import { LoginComponent } from './Auth/Login/Login.component';
import { RegisterComponent } from './Auth/Register/Register.component';
import { AdminGuard } from './Guards/admin.guard';
import { ManagerGuard } from './Guards/manager.guard';
import { NotLoginGuard } from './Guards/notLogin.guard';
import { UserGuard } from './Guards/user.guard';
import { HomeComponent } from './home/home.component';
import { ManagerPanelComponent } from './manager-panel/manager-panel.component';
import { UserProfileComponent } from './user-profile/user-profile.component';

const routes: Routes = [
    { path:'', redirectTo: 'home', pathMatch:'full'},
    { path:'home', component: HomeComponent, pathMatch:'full'},
    { path:'login', component:LoginComponent,canActivate:[NotLoginGuard], pathMatch:'full'},
    { path:'register', component:RegisterComponent,canActivate:[NotLoginGuard], pathMatch:'full'},
    { path:'admin-panel', component:AdminPanelComponent,canActivate:[AdminGuard], pathMatch:'full'},
    { path:'manager-panel', component:ManagerPanelComponent,canActivate:[ManagerGuard], pathMatch:'full'},
    { path:'user-profile', component:UserProfileComponent,canActivate:[UserGuard], pathMatch:'full'}
];

@NgModule({ 

    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule],
})

export class AppRoutingModule { }