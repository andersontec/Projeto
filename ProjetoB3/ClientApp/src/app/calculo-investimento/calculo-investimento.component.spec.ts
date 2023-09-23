import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CalculoInvestimentoComponent } from './calculo-investimento.component';

describe('CalculoInvestimentoComponent', () => {
  let component: CalculoInvestimentoComponent;
  let fixture: ComponentFixture<CalculoInvestimentoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CalculoInvestimentoComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CalculoInvestimentoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
