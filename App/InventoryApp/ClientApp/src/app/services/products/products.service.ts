import { Injectable } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { environment } from 'src/environments/environment';

@Injectable({
    providedIn: "root"
})
export class ProductsServices {
    constructor(private httpclient: HttpClient){

    }

    get<T>(id: number): Observable<T>{
        return this.httpclient.get<T>(`/api/product/get/${id}`);
    }

    getAll<T>(): Observable<T>{
        return this.httpclient.get<T>(`/api/product/get`);
    }

    save<T>(product: any): Observable<T>{
        return this.httpclient.post<T>(`/api/product`, product);
    }

}
