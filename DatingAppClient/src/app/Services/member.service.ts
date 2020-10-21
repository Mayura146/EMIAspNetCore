import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { IMember } from '../Models/IMember';

@Injectable({
  providedIn: 'root',
})
export class MemberService {

  public baseUrl = environment.apiUrl;

  constructor(private httpClient: HttpClient) {

  }

  public getMembers() {
   
    return this.httpClient.get<IMember[]>(this.baseUrl + 'user');
  }
  public getMemberById(id: number) {
    return this.httpClient.get<IMember>(this.baseUrl + 'user/' + id);
  }
}
