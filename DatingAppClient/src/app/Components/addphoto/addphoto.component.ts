import { Component, Input, OnInit } from '@angular/core';
import { FileUploader } from 'ng2-file-upload';
import { IMember } from 'src/app/Models/IMember';
import { IPhoto } from 'src/app/Models/IPhoto';
import { IUser } from 'src/app/Models/IUser';
import { AccountService } from 'src/app/Services/account.service';
import { MemberService } from 'src/app/Services/member.service';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-addphoto',
  templateUrl: './addphoto.component.html',
  styleUrls: ['./addphoto.component.css'],
})
export class AddphotoComponent implements OnInit {
  @Input() public member: IMember;
  public uploader: FileUploader;
  public hasBaseDropZoneOver = false;
  public baseUrl = environment.apiUrl;
  public user: IUser;
  constructor(private accountService: AccountService, private memberService: MemberService) {
    // access to current user
    this.accountService.currentUser.subscribe((user) => this.user = user);
  }

  public ngOnInit(): void {

  }

}
