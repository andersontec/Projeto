import { TestBed } from '@angular/core/testing';

import { InvestimentoService } from './investimento.service';

describe('InvestimentoService', () => {
  let service: InvestimentoService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(InvestimentoService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
