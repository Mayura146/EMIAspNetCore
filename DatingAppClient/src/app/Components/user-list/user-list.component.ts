import { Component, OnInit } from '@angular/core';
import { IMember } from '../../Models/IMember';
import { MemberService } from '../../Services/member.service';
@Component({
  selector: 'app-user-list',
  templateUrl: './user-list.component.html',
  styleUrls: ['./user-list.component.css'],
})
export class UserListComponent implements OnInit {
  public members: IMember[];
  constructor(private memberService: MemberService) { }

  public ngOnInit(): void {
    this.getMembers();
  }

  public getMembers() {
    this.memberService.getMembers().subscribe((response) => {
      debugger;
      this.members = response;
    });
  }
}
