import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { TabsModule } from 'ngx-bootstrap/tabs';
import { NgxGalleryModule } from 'ngx-gallery-9';
import { ToastrModule } from 'ngx-toastr';
import { AngularMaterialModule } from './angular-material/angular-material.module';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './Components/home/home.component';
import { ListComponent } from './Components/list/list.component';
import { MessagesComponent } from './Components/messages/messages.component';
import { NavBarComponent } from './Components/nav-bar/nav-bar.component';
import { RegisterComponent } from './Components/register/register.component';
import { UserCardComponent } from './Components/user-card/user-card.component';
import { UserDetailsComponent } from './Components/user-details/user-details.component';
import { UserEditComponent } from './Components/user-edit/user-edit.component';
import { UserListComponent } from './Components/user-list/user-list.component';
import { JwtInterceptor } from './Interceptor/jwt.interceptor';
@NgModule({
  declarations: [
    AppComponent,
    NavBarComponent,
    UserListComponent,
    ListComponent,
    MessagesComponent,
    RegisterComponent,
    HomeComponent,
    UserCardComponent,
    UserDetailsComponent,
    UserEditComponent,

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    AngularMaterialModule,
    HttpClientModule,
    FormsModule,
    ToastrModule.forRoot({ positionClass: 'toast-bottom-left' }),
    TabsModule.forRoot(),
    NgxGalleryModule,
  ],
  providers: [{provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true}],
  bootstrap: [AppComponent],
})
export class AppModule { }
