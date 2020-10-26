
import { ThrowStmt } from '@angular/compiler';
import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { AccountService } from 'src/app/Services/account.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css'],
})
export class RegisterComponent implements OnInit {
  @Output() public cancelRegister = new EventEmitter();
public model: any = {};
  public registerForm: FormGroup;
  constructor(private accountService: AccountService, private toastrService: ToastrService,
              private fb: FormBuilder, private router: Router,
  ) { }

  public ngOnInit(): void {
    this.registerForm = this.fb.group({

      userName: ['', Validators.required],
      knownAs: ['', Validators.required],
      dateBirth: ['', Validators.required],
      country: ['', Validators.required],
      password: ['', [Validators.required], Validators.min(4), Validators.maxLength(8)],
    });

  }

  public register() {
    console.log(this.model);
    this.accountService.register(this.model).subscribe((response) => {
      this.router.navigateByUrl('/user');
      this.cancel();
    }, (error) => {
        console.log(error);
        this.toastrService.error(error.error);
    });

  }
  public cancel() {
    this.cancelRegister.emit(false);
    console.log('cancelled');

  }
}
