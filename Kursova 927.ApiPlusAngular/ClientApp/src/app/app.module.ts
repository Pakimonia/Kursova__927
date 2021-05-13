import { BrowserModule } from '@angular/platform-browser';
import { NgModule , enableProdMode } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './Auth/Login/Login.component';
import { RegisterComponent } from './Auth/Register/Register.component';
import { NotifierModule } from 'angular-notifier';
import { UserProfileComponent } from './user-profile/user-profile.component';
import { AdminPanelComponent } from './admin-panel/admin-panel.component';
import { ManagerPanelComponent } from './manager-panel/manager-panel.component';
import { AddAdminComponent } from './add-admin/add-admin.component';
import { AddManagerComponent } from './add-manager/add-manager.component';
import { AddProductComponent } from './add-product/add-product.component';
import { TestComponent } from './test/test.component';
import { Error_404Component } from './error_404/error_404.component';
import { TypeMenuComponent } from './type-menu/type-menu.component';
import { ProductsComponent } from './products/products.component';
import { ProductDetailComponent } from './product-detail/product-detail.component';
import { EditProductComponent } from './edit-product/edit-product.component';

enableProdMode();
@NgModule({
  
  declarations: [																
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    LoginComponent,
    RegisterComponent,
    TestComponent,
    Error_404Component,
    TypeMenuComponent,
    UserProfileComponent,
    AdminPanelComponent,
      AddAdminComponent,
      AddManagerComponent,
    ManagerPanelComponent,
      AddProductComponent,
      ProductsComponent,
      ProductDetailComponent,
      EditProductComponent
   ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    AppRoutingModule,
    NotifierModule.withConfig({
      position: {
        horizontal: {
          position: 'right',
        },
        vertical: {
          position: 'top',
        }
      }
    })
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
