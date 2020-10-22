import { Component, Input, OnInit } from '@angular/core';
import { IMember } from 'src/app/Models/IMember';
import { MemberService } from 'src/app/Services/member.service';

@Component({
  selector: 'app-user-card',
  templateUrl: './user-card.component.html',
  styleUrls: ['./user-card.component.css'],
})
export class UserCardComponent implements OnInit {
  @Input() public member: IMember;
  constructor() { }

  public ngOnInit(): void {
  }

}
