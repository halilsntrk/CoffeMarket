import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class TypeService {
  // apiUrl: string = 'https://localhost:44337/';
  apiUrl: string = 'https://panel.coffeemarket.org/api/';
  constructor() { }


  //Ürün Tiplerini listele
  async getTypes(){
   return fetch(this.apiUrl + "gettypes",{
      method : 'GET'
    }).then((response) => response.json()).then((data)=> data.result)
  }
}
