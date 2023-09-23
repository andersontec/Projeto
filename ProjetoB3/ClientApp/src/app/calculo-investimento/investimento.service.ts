import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { InvestimentoModel } from '../investimento.model';

@Injectable({
  providedIn: 'root'
})
export class InvestimentoService {

  private apiUrl = 'https://localhost:7247/api/investimento';
  constructor(private http: HttpClient) { }

  public calcular(valorInicial: number, prazoMeses: number): Observable<InvestimentoModel> {
    const payload = {
      valorInicial,
      prazoMeses
    };

    return this.http.post<InvestimentoModel>(`${this.apiUrl}/calcular`, payload);
  }
}
