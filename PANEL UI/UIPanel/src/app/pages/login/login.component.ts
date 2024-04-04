import { Component } from '@angular/core';
import { LoginModel } from '../../models/models/login.model';
import { Router } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { UserService } from '../../services/user.service';
@Component({
  selector: 'app-login',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css',
})
export class LoginComponent {
  loginmodel: LoginModel = new LoginModel();
  form: any;
  messsage: any;
  constructor(private user_service: UserService, private router: Router) {}

  ngOnInit() {
    this.loginmodel.username = localStorage.getItem('username');
    this.form = document.getElementById('loginForm') as HTMLElement;
    this.messsage = document.createElement('div');
    this.form.appendChild(this.messsage);
  }
  async login() {
    //beni hatırla
    const rememberme = document.getElementById(
      'form2Example31'
    ) as HTMLInputElement;
    if (rememberme.checked) {
      localStorage.setItem('username', this.loginmodel.username as string);
      localStorage.setItem('password', this.loginmodel.password as string);
    }

    var res = await this.user_service.Login(this.loginmodel);
    if (res.result == null) {
      this.messageShow('warning', res.message);
    } else {
      const token = res.result;
      if (token) {
        this.messageShow('success', res.message);
        setTimeout(() => {
          sessionStorage.setItem('token', token);
          this.router.navigateByUrl('');
        }, 3000);
      }
    }
  }

  async messageShow(status: string, message: string) {
    this.messsage.className = `alert alert-${status}`;
    this.messsage.innerHTML = message;

    this.messsage.style.display = 'block';

    setTimeout(() => {
      this.messsage.style.display = 'none';
    }, 2000);
  }
}
