import { Component, Input, OnInit } from '@angular/core';
import { IMember } from 'src/app/Models/IMember';
import { IPhoto } from 'src/app/Models/IPhoto';
import { IUser } from 'src/app/Models/IUser';
import { AccountService } from 'src/app/Services/account.service';
import { MemberService } from 'src/app/Services/member.service';

@Component({
  selector: 'app-photo-editor',
  templateUrl: './photo-editor.component.html',
  styleUrls: ['./photo-editor.component.css'],
})
export class PhotoEditorComponent implements OnInit {

  @Input() public member: IMember;
  public user: IUser;
  constructor(private accountService: AccountService, private memberService: MemberService) {
    this.accountService.currentUser.subscribe((user) => this.user = user);
   }

  public ngOnInit(): void {
  }

  public setMainPhoto(photo: IPhoto) {
    this.memberService.setMainPhoto(photo.id).subscribe(() => {
      this.user.photoUrl = photo.url;
      this.member.photoUrl = photo.url;
      this.member.photos.forEach((p) => {
        if (p.isMain) {
          p.isMain = false;
        }
        if (p.id === photo.id) {
          p.isMain = true;
        }
      });

    });
  }
  public deletePhoto(photoId: number) {
    this.memberService.deletePhoto(photoId).subscribe(() => {
      this.member.photos = this.member.photos.filter((x) => x.id !== photoId);
    });
  }
}
