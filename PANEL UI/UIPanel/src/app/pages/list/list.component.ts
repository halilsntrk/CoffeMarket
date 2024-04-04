import { CommonModule } from '@angular/common';
import { Component,Input,HostListener  } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ProductService } from '../../services/product.service';
import { DashboardComponent } from '../dashboard/dashboard.component';
import  $ from 'jquery'


@Component({
  selector: 'app-list',
  standalone: true,
  imports: [CommonModule,DashboardComponent],
  templateUrl: './list.component.html',
  styleUrl: './list.component.css',
})
export class ListComponent {
  products: any[] = [];
  currentmodal : string = ""
 
  openModal(productId: string,status : boolean) {
    const modalId = 'myModal' + productId;
    this.currentmodal = modalId;
    const modalElement = document.getElementById(modalId);
    if (modalElement) {
      if(status){
        modalElement.style.display = 'block';
      }else{
        console.log("kapat")
        modalElement.style.display = 'none';
      }
     
    }
  }
  closeModal() {
    // Modalı kapatmak için gerekli kodu buraya ekleyin
  }

  constructor(private product_service : ProductService) {}

  async ngOnInit() {
    //Ürünleri çek
  var data = await this.product_service.getProducts();
    this.products = data.result;
   
 
    
  }

  @HostListener('document:click', ['$event'])
  onDocumentClick(event: MouseEvent) {
    // Arka plana tıklanıp tıklanmadığını kontrol edin
    const targetElement = event.target as HTMLElement;
    if (!targetElement.closest('.modal-content')) {
      var key = this.currentmodal.replace("myModal","");
      console.log(key)
      this.openModal(key,false);
    }
  }

  
}



