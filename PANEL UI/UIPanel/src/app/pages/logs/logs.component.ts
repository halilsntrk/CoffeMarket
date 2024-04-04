import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { DashboardComponent } from '../dashboard/dashboard.component';
import { UserService } from '../../services/user.service';

@Component({
  selector: 'app-logs',
  standalone: true,
  imports: [DashboardComponent,CommonModule],
  templateUrl: './logs.component.html',
  styleUrl: './logs.component.css'
})
export class LogsComponent {
logs : any[] = [];


constructor(private user_service : UserService){

}

async ngOnInit(){

this.logs = await this.user_service.getLogs();
}

}
