import { HttpClient } from '@angular/common/http';
import { Injectable, EventEmitter } from '@angular/core';
import jwt_decode from 'jwt-decode';
import { Observable } from 'rxjs';
import { ApiResponse } from '../Models/api.response';
import { LoginModel } from '../Models/login.model';
import { RegisterModel } from '../Models/register.model';
import { Product } from '../product';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  private url = "/api/products";
  token_data: any; 
  token = localStorage.getItem('token');
  baseUrl = "/api/Account";
  authEvents = new EventEmitter<boolean>();

  
  constructor(private http: HttpClient) { }

  authEventsEmit(){
    this.authEvents.emit(true);
  }

  register(model: RegisterModel): Observable<ApiResponse> {
    return this.http.post<ApiResponse>(this.baseUrl + "/register", model);
  }

  login(model: LoginModel): Observable<ApiResponse> {
    return this.http.post<ApiResponse>(this.baseUrl + "/login", model);
  }

  isAdmin(): boolean {
    this.token = localStorage.getItem('token');
    if(this.token !=null){
      this.token_data = jwt_decode(this.token);
      return this.token_data.roles == "Admin" ? true : false;
    }
    return false;
  }

  isManager(): boolean {
    this.token = localStorage.getItem('token');
    if(this.token !=null){
      this.token_data = jwt_decode(this.token);
      return this.token_data.roles == "Manager" ? true : false;
    }
    return false;
  }

  isLoggedIn(): boolean {
    //this.token = localStorage.getItem('token');
    if(this.token == null)
    return false;
    return (this.token) ? true : false;
  }

  Logout(){
    
    localStorage.removeItem("token");
    this.authEvents.emit(false);
  }

  getProducts() {
    return this.http.get(this.url);
  }
 
  getProduct(id: number) {
      return this.http.get(this.url + '/' + id);
  }
 
  createProduct(product: Product) {
      return this.http.post(this.url, product);
  }
  updateProduct(product: Product) {

      return this.http.put(this.url, product);
  }
  deleteProduct(id: number) {
      return this.http.delete(this.url + '/' + id);
  }



  

}
