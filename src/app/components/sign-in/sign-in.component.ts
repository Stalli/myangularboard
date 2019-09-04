import { SocialUser } from "angularx-social-login";
import { AuthService } from "angularx-social-login";
import { FacebookLoginProvider, GoogleLoginProvider } from "angularx-social-login";
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Subscription } from 'rxjs';

@Component({
  selector: 'sign-in',
  templateUrl: './sign-in.component.html',
  styleUrls: ['./sign-in.component.less']
})
export class SignInComponent implements OnInit {

  private user: SocialUser;
  private loggedIn: boolean;
  private authSubscription : Subscription;

  constructor(private authService: AuthService, private router: Router) { }

  ngOnInit() {
    this.authSubscription = this.authService.authState.subscribe((user) => {
      this.user = user;
      this.loggedIn = (user != null);
      if (this.loggedIn)
      {
          this.router.navigate(['/columns']);
      }
    });
  }

  ngOnDestroy(){
    this.authSubscription.unsubscribe();
  }

  signInWithGoogle(): void {
    this.authService.signIn(GoogleLoginProvider.PROVIDER_ID);
  }

  signInWithFB(): void {
    this.authService.signIn(FacebookLoginProvider.PROVIDER_ID);
  } 

  goToDemoBoard(): void {
    this.router.navigate(['/columns']);
  }
}