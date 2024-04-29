import { Injectable } from '@angular/core';
import { inArray } from 'jquery';

@Injectable({
  providedIn: 'root',
})
export class ProductService {
  // apiUrl: string = 'https://localhost:44337/';
  apiUrl: string = 'https://panel.coffeemarket.org/api/';
  token : string | null = "";
  constructor() {

    this.token = sessionStorage.getItem('token');
  }

  //ürünleri çek
  async getProducts() {
    return await fetch(this.apiUrl + 'list', {
      method: 'GET',
      headers :{
        'Content-Type' : 'application/json',
        Authorization : `Bearer ${this.token}`
      },
    }).then((response) => response.json()).catch((error)=> error);
  }

  //ürün ekle
  async addProduct(product: FormData)  {
    return await fetch(this.apiUrl + 'add', {
      method: 'POST',
      headers :{ 
        Authorization : `Bearer ${this.token}`
      },
      body: (product),
    })
      .then((response) => console.log(response))
      .then((data) => data);
  }

  async softUpload(image: File) {
    const formData = new FormData();
    formData.append('image', image);
  
    return await fetch(this.apiUrl + 'softUpload', {
      method: 'POST',
      headers: {
        Authorization: `Bearer ${this.token}`
      },
      body: formData,
    }).then((response) => response.json())
      .then((data) => data.result.imageURL);
  }
}
