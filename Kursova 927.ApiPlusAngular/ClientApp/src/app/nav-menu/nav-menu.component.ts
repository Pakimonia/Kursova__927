import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from '../Services/Auth.service';

@Component({
  selector: 'nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  isExpanded = false;
  isLogined: boolean;
  isAdmin: boolean;
  isManager: boolean;

  constructor(
    private authService: AuthService,
    private router: Router) {}

  ngOnInit() { 
    this.isLogined = this.authService.isLoggedIn();
    this.isAdmin = this.authService.isAdmin();
    this.isManager = this.authService.isManager();
    this.authService.authEvents.subscribe((status) => {
      this.isLogined = status;
      this.isAdmin = this.authService.isAdmin();
      this.isManager = this.authService.isManager();
    });
  }


  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

  Logout() {
    this.authService.Logout();
  }


}
