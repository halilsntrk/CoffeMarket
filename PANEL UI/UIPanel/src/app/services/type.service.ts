import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class TypeService {
  apiUrl: string = 'https://localhost:44337/';
  constructor() { }


  //Ürün Tiplerini listele
  async getTypes(){
   return fetch(this.apiUrl + "gettypes",{
      method : 'GET'
    }).then((response) => response.json()).then((data)=> data.result)
  }
}
