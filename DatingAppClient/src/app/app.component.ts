import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent implements OnInit {
  public title = 'DatingAppClient';
  public displayedColumns: string[] = ['id', 'userName'];
  public users: any;
  constructor(private httpClient: HttpClient) {

  }
  public ngOnInit() {
    this.getUsers();
  }
  public getUsers() {
    this.httpClient.get('https://localhost:44303/api/user').subscribe((response) => {
      this.users = response;
    }, (error) => {
        console.log(error);
    });
  }

}
