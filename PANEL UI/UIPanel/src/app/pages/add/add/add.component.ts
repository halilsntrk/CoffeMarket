import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { FormBuilder, FormGroup, Validators,ReactiveFormsModule  } from '@angular/forms';
import { Product } from '../../../models/models/product.model';
import { ProductService } from '../../../services/product.service';
import { TypeService } from '../../../services/type.service';
import { ProductType } from '../../../models/models/type.model';
import { DashboardComponent } from '../../dashboard/dashboard.component';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-add',
  standalone: true,
  imports: [FormsModule,ReactiveFormsModule,DashboardComponent,CommonModule],
  templateUrl: './add.component.html',
  styleUrl: './add.component.css'
})

export class AddComponent {
  apiUrl: string = 'https://localhost:44387/';
  product: Product = new Product()
  selectedImage: any;
  files : Map<string,any> = new Map<string,any>;
types : ProductType[] = [];

  constructor(private product_service : ProductService,private type_service : TypeService){

  }


  async ngAfterViewInit() {
    this.types = await this.type_service.getTypes();
   
  }

async  getformData(){
  let formData : FormData = new FormData;
 formData.append('TypeID' , this.product.TypeID);
 formData.append('Name' , this.product.Name);
 formData.append('Grammage' , this.product.Grammage.toString());
 formData.append('Price' , this.product.Price.toString());
 formData.append('Spot' , this.product.Spot);

return formData;
  }

 async handleDetailImage(data : any){
this.files.set("detail",data.files as File[]);  

  }
  async handleListImage(data : any){

    this.files.set("list",data.files as File[]); 
  if (data.files[0]) {
    const reader = new FileReader();
    reader.onload = (e: any) => {
      this.selectedImage = e.target.result;
    };
    reader.readAsDataURL(data.files[0]);
  }
      }

  

 async onSubmit() {
  console.log(this.files)
    const formdata = await this.getformData();
    Array.from(this.files.get("detail")).forEach((f : any) => formdata.append('DetailImage',f))
    Array.from(this.files.get("list")).forEach((f : any) => formdata.append('ListImage',f))
   var res = await this.product_service.addProduct(formdata);

   console.log(res)
}

}

