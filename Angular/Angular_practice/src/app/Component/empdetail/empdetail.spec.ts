import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Empdetail } from './empdetail';

describe('Empdetail', () => {
  let component: Empdetail;
  let fixture: ComponentFixture<Empdetail>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [Empdetail]
    })
    .compileComponents();

    fixture = TestBed.createComponent(Empdetail);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
