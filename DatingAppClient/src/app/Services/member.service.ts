import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { of } from 'rxjs';
import { map } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import { IMember } from '../Models/IMember';

@Injectable({
  providedIn: 'root',
})
export class MemberService {

  public baseUrl = environment.apiUrl;
  public members: IMember[] = [];

  constructor(private httpClient: HttpClient) {

  }

  public getMembers() {

    if (this.members.length > 0) {
      return of(this.members);
      }

    return this.httpClient.get<IMember[]>(this.baseUrl + 'user').pipe(
      map((members) => {
        this.members = members;
        return members;
      }),
    );
  }
  public getMemberById(id: number) {
    const member = this.members.find((x) => x.id === id);
    if (member !== undefined) {
      return of(member);
      }
    return this.httpClient.get<IMember>(this.baseUrl + 'user/' + id);
  }

  public updateUser(member: IMember) {
    const URL = this.baseUrl + 'user/edit';
    return this.httpClient.put(URL, member).pipe(map(() => {
      const index = this.members.indexOf(member);
      this.members[index] = member;
    }));
  }

}
