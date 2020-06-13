import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { AuthService } from '../_services/auth.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  model: any = {};
  values:any;
  @Output() ListaCursos = new EventEmitter();
  @Output() VistaCursos = new EventEmitter();
  constructor(private authService: AuthService) { }

  ngOnInit() {
  }
  login(){
    this.authService.login(this.model).subscribe(next =>{
      console.log('Logged in succesfully');
    }, error => {
      console.log(error);
    });
  }

  loggedIn(){
    const token = localStorage.getItem('token');
    return !!token;
  }

  logout(){
    localStorage.removeItem('token');
    console.log('logged out');
  }
  Cursos(){
    this.authService.ObtenerCursos().subscribe(response => {
      this.values = response;
      this.ListaCursos.emit(this.values);
     // this.VistaCursos.emit(false);
      //console.log(this.values);
    }, error => {
      console.log(error);
    });
    };
}

