import { Component, OnInit } from '@angular/core';
import { ProductModel } from 'src/app/models/product-model';
import { ProductsServices } from 'src/app/services/products/products.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-products-form',
  templateUrl: './products-form.component.html',
  styleUrls: ['./products-form.component.css']
})
export class ProductsFormComponent implements OnInit {
  isBusy: boolean = false;
  productModel: ProductModel;
  categories: any[];
  constructor(
    private productService: ProductsServices, 
    public router: Router) { 
   this.productModel = new ProductModel(); 
  }

  ngOnInit() {
    this.loadCategoryData();
  }

  loadCategoryData(){
    this.categories = [
      { id : 1, value : 'Computer' },
      { id : 2, value : 'Power Tools' },
      { id : 3, value : 'Books' },
      { id : 4, value : 'Food' },
      { id : 5, value : 'Drinks & Beverages' },
      { id : 6, value : 'Cleaning' },
      { id : 7, value : 'Phone & Accessories' },
      { id : 8, value : 'Beauty Products' },
      { id : 9, value : 'Furniture' },
      { id : 10, value : 'Appliances' },

    ]
  }

  save(){
    this.isBusy = true;
    this.productService.save(this.productModel).subscribe((res) => {
      if(!res) return false;
      this.router.navigateByUrl('/products');
    }, (error: any) => {
      console.log(error.error)
    })
  }

}
