import { Component, OnInit } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { ProductsServices } from 'src/app/services/products/products.service';

@Component({
  selector: 'app-products-list',
  templateUrl: './products-list.component.html',
  styleUrls: ['./products-list.component.css']
})
export class ProductsListComponent implements OnInit {
  isBusy: boolean = false;
  products: BehaviorSubject<any[]>;

  constructor(private productService: ProductsServices) { 
    this.products = new BehaviorSubject([]);
  }

  ngOnInit() {
    this.loadData();
  }
  loadData(){
    this.isBusy = true;
    this.productService.getAll().subscribe((res : any[]) => {
      if(!res || res.length === 0) return false; //something went wrong
      this.products.next(res);
      this.isBusy = false;
    }, (error : any) => {
      console.log(error.error);
    })
  }

}
