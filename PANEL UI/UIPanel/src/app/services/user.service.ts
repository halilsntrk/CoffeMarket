import { Injectable } from '@angular/core';
import { LoginModel } from '../models/models/login.model';
import { retry } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class UserService {
  constructor() {}
  apiUrl: string = 'https://panel.coffeemarket.org/api/';
  //LOGİN İŞLEMİ
  async Login(loginmodel:LoginModel) {
  return await fetch(this.apiUrl+"login", {
      body: JSON.stringify(loginmodel),
      method: 'POST',
      headers: {
        'Content-Type': 'application/json',
      },
    })
      .then((response) => response.json())
      .then((data) => data);
  }

  async Logout(token : string|null){
    sessionStorage.removeItem('token');
    
  }


  //Logları çekme

  async getLogs(){
    return await fetch('https://localhost:44337/logs', {
      method: 'GET',
      headers: {
        'Content-Type': 'application/json',
      },
    })
      .then((response) => response.json())
      .then((data) => data.result);
  }
}
