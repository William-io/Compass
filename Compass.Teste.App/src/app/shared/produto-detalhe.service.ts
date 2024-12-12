import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment.development';
import { ProdutoDetalhe } from './produto-detalhe.model';

@Injectable({
  providedIn: 'root'
})
export class ProdutoDetalheService {

  url: string = environment.apiBaseUrl + '/produtos';
  listaProdutos: ProdutoDetalhe[] = [];

  constructor(private http: HttpClient) { }

  // Método para obter a lista de produtos do servidor
  obterProdutos(){
    this.http.get(this.url)
    // O método subscribe é usado para se inscrever em um Observable e começar a receber notificações assíncronas de dados emitidos pelo Observable.
      .subscribe({
        next: res => {
          // Atribui a resposta do servidor à lista de produtos
          this.listaProdutos = res as ProdutoDetalhe[];
          console.log(res);
        },
        error: err => {
          console.log(err);
        }
      });
  }
}
