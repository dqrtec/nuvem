import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.sass']
})
export class HomeComponent implements OnInit {
  caminho = '../../assets/imagens/img1';
  postagen = [{'img':'../../assets/imagens/img1', 'owner':'Daniel', 'description':'aqui jax uma desricao'},
  {'img':'../../assets/imagens/img2', 'owner':'Saniel', 'description':'aqui jax uma desricao'},
  {'img':'../../assets/imagens/img3', 'owner':'Aniel', 'description':'aqui jax uma desricao'},]
  constructor() { }

  ngOnInit(): void {
  }

}
