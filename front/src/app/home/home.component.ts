import { Component, OnInit } from '@angular/core';

import { User } from '../model/user'

import { UserService } from '../servicos/user.service'

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.sass']
})
export class HomeComponent implements OnInit {
  caminho = '../../assets/imagens/img1';
  postagen = [
    {'img':'../../assets/imagens/img1', 'owner':'Daniel', 'description':'aqui jax uma desricao', 'likes': ['Saniel', 'Aniel']},
    {'img':'../../assets/imagens/img2', 'owner':'Saniel', 'description':'aqui jax uma desricao', 'likes': ['Daniel', 'Aniel']},
    {'img':'../../assets/imagens/img3', 'owner':'Aniel', 'description':'aqui jax uma desricao', 'likes': ['Daniel', 'Saniel']},
  ]
  constructor(private userService: UserService) { }

  ngOnInit(): void {
  }

  getUser(userApelido): User{
    var usuario = <User> {"name": "Usuario 01", "user": userApelido, "password": "123456", "email": "user01@gmail.com", "img": "../../assets/imagens/user.png"}
    return usuario;

    /* Código quando dados tiverem vindo da api 
    var usuario: User;
    this.userService.getUser(userApelido).subscribe(user => usuario = user)
    return usuario;
    */
  }

}
