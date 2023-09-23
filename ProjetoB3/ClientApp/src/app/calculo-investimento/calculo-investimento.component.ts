import { Component, OnInit } from '@angular/core';
import { InvestimentoService } from './investimento.service';
import { InvestimentoModel } from '../investimento.model';

@Component({
  selector: 'app-calculo-investimento',
  templateUrl: './calculo-investimento.component.html',
  styleUrls: ['./calculo-investimento.component.css']
})
export class CalculoInvestimentoComponent implements OnInit {

  valorInicial: number = 0;
  prazoMeses: number = 0;
  valorFinal: number = 0;
  valorLiquido: number = 0;
  resultadoCalculado = false;

  constructor(private investimentoService: InvestimentoService) { }

  ngOnInit(): void {
  }

  calcularInvestimento() {
    this.investimentoService.calcular(this.valorInicial, this.prazoMeses)
      .subscribe(
        res => {
          this.valorFinal = res.valorFinal;
          this.valorLiquido = res.valorLiquido;
          this.resultadoCalculado = true;
        },
        err => {
          console.error("Ocorreu um erro: ", err);
        }
      );
  }
}
