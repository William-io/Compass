import { Component, OnInit } from '@angular/core';
import { ProdutoDetalheService } from '../shared/produto-detalhe.service';

@Component({
  selector: 'app-produto-detalhes',
  templateUrl: './produto-detalhes.component.html',
  styleUrls: ['./produto-detalhes.component.css']
})
export class ProdutoDetalhesComponent implements OnInit {

  constructor(public service: ProdutoDetalheService) { }

  ngOnInit(): void {
    this.service.obterProdutos();
  }

}
