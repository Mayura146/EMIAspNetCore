import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { NgxGalleryAnimation, NgxGalleryImage, NgxGalleryOptions } from '@kolkov/ngx-gallery';

import { IMember } from 'src/app/Models/IMember';
import { MemberService } from 'src/app/Services/member.service';

@Component({
  selector: 'app-user-details',
  templateUrl: './user-details.component.html',
  styleUrls: ['./user-details.component.css'],
})
export class UserDetailsComponent implements OnInit {

  public member: IMember;
  public galleryOptions: NgxGalleryOptions[];
  public galleryImages: NgxGalleryImage[];
  constructor(private memberService: MemberService, private route: ActivatedRoute) { }

  public ngOnInit(): void {
    this.getMember();
    this.galleryOptions = [
      {
        width: '400px',
        height: '400px',
        thumbnailsColumns: 3,
        imageAnimation: NgxGalleryAnimation.Slide,
        preview: false,
      },
    ];

  }

  public getMember() {
    this.memberService.getMemberById(+this.route.snapshot.paramMap.get('id'))
      .subscribe((response) => {
        this.member = response;
      });
    this.galleryImages = this.getImages();
  }

  public getImages(): NgxGalleryImage[] {
    const imageUrl = [];
    for (const photo of this.member.photos) {
      imageUrl.push({
        small: photo.url,
        medium: photo.url,
        big: photo.url,
      });
      return imageUrl;
      }
  }
}
