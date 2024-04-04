import { Routes } from '@angular/router';
import { DashboardComponent } from './pages/dashboard/dashboard.component';
import { ListComponent } from './pages/list/list.component';
import { AddComponent } from './pages/add/add/add.component';
import { LoginComponent } from './pages/login/login.component';
import { LogsComponent } from './pages/logs/logs.component';

export const routes: Routes = [

    { path: '', component: DashboardComponent },
    { path: 'ekle', component: AddComponent },
    { path: 'list', component: ListComponent },
    { path: 'login', component: LoginComponent },
    { path: 'logs', component: LogsComponent }
];
