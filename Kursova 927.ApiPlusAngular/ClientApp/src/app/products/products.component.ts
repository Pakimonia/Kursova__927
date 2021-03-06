import { Component, OnInit } from '@angular/core';
import { Product } from '../product';
import { AuthService } from '../Services/Auth.service';

@Component({
  selector: 'products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css'],
  providers: [AuthService]
})
export class ProductsComponent implements OnInit {
  product: Product = new Product();   // изменяемый товар
  products: Product[];                // массив товаров
  tableMode: boolean = true;          // табличный режим
  constructor(private dataService: AuthService) { }
 
  ngOnInit() {
      this.loadProducts();    // загрузка данных при старте компонента  
  }
  // получаем данные через сервис
  loadProducts() {
      this.dataService.getProducts()
          .subscribe((data: Product[]) => this.products = data);
  }
  // сохранение данных
  save() {
      if (this.product.id == null) {
          this.dataService.createProduct(this.product)
              .subscribe((data: Product) => this.products.push(data));
      } else {
          this.dataService.updateProduct(this.product)
              .subscribe(data => this.loadProducts());
      }
      this.cancel();
  }
  editProduct(p: Product) {
      this.product = p;
  }
  cancel() {
      this.product = new Product();
      this.tableMode = true;
  }
  delete(p: Product) {
      this.dataService.deleteProduct(p.id)
          .subscribe(data => this.loadProducts());
  }
  add() {
      this.cancel();
      this.tableMode = false;
  }
};
