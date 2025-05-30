import { Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { UserSignupComponent } from './signup/user-signup/user-signup.component';
import { CompanySignupComponent } from './signup/company-signup/company-signup.component';
import { EmptyComponent } from './empty/empty.component';
import { GetRequestsComponent } from './requests/get-request/get-requests.component';
import { RequestDetailsComponent } from './requests/request-details/request-details.component';


export const routes: Routes = [ 
    { path: '', redirectTo: '/loginUser', pathMatch: 'full' },
    { path: 'loginUser', component: LoginComponent },
    { path: 'usersignup', component: UserSignupComponent },
    { path: 'companysignup', component: CompanySignupComponent},
    { path: 'getrequest', component: GetRequestsComponent},
    { path: 'request-details/:id', component: RequestDetailsComponent},
    { path: 'home', component: EmptyComponent },
    
];
