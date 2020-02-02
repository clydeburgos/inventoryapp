import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { ProductsListComponent } from './components/products/products-list/products-list.component';
import { ProductsFormComponent } from './components/products/products-form/products-form.component';
import { ProductsServices } from './services/products/products.service';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    ProductsListComponent,
    ProductsFormComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'products', component: ProductsListComponent, pathMatch: 'full' },
      { path: 'products/new', component: ProductsFormComponent },
      { path: 'products/:id/details', component: ProductsFormComponent},
    ])
  ],
  providers: [ ProductsServices ],
  bootstrap: [AppComponent]
})
export class AppModule { }
