import { Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { UserSignupComponent } from './signup/user-signup/user-signup.component';
import { CompanySignupComponent } from './signup/company-signup/company-signup.component';
import { EmptyComponent } from './empty/empty.component';


export const routes: Routes = [ 
    { path: 'loginUser', component: LoginComponent },
    { path: 'usersignup', component: UserSignupComponent },
    { path: 'companysignup', component: CompanySignupComponent},
    { path: 'home', component: EmptyComponent },
    { path: '', redirectTo: '/home', pathMatch: 'full' }
];
