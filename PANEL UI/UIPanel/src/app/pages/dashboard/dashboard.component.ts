import { Component } from '@angular/core';
import { Router, RouterModule } from '@angular/router';
import { UserService } from '../../services/user.service';

@Component({
  selector: 'app-dashboard',
  standalone: true,
  imports: [],
  templateUrl: './dashboard.component.html',
  styleUrl: './dashboard.component.css'
})
export class DashboardComponent {
token : string | null = '';
constructor(private user_service : UserService,private router : Router){
  this.token = sessionStorage.getItem('token')
  if(this.token==null){
    this.router.navigateByUrl("login");
  }
}


async logout(){
this.user_service.Logout(this.token);
this.router.navigateByUrl("login");
}
}
