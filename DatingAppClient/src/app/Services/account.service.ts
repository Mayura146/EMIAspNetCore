import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ReplaySubject } from 'rxjs';
import { map } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import { IUser } from '../Models/IUser';
@Injectable({
  providedIn: 'root',
})
export class AccountService {
  public baseUrl = environment.apiUrl;
  private currentUserValue = new ReplaySubject<IUser>(1);
  public currentUser = this.currentUserValue.asObservable();

  constructor(private httpClient: HttpClient) { }

  // tslint:disable-next-line: typedef
  public login(model: any) {
    const URL = this.baseUrl + 'account/login';
    return this.httpClient.post(URL, model)
      .pipe(map((response: IUser) => {
        const user = response;
        if (user) {
          localStorage.setItem('user', JSON.stringify(user));
          this.currentUserValue.next(user);
          }
        return user;
      }));
  }
  // tslint:disable-next-line: typedef
  public logout() {
    localStorage.removeItem('user');
    this.currentUserValue.next(null);
  }

  // tslint:disable-next-line: typedef
  public register(model: any) {
    const URL = this.baseUrl + 'account/register';
    return this.httpClient.post(URL, model).pipe(map((user: IUser) => {
      if (user) {
        localStorage.setItem('user', JSON.stringify(user));
        this.currentUserValue.next(user);
      }
    }));
  }
  public setCurrentUser(user: IUser) {
    this.currentUserValue.next(user);
  }
}
