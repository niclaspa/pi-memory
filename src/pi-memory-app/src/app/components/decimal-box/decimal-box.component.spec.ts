import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DecimalBoxComponent } from './decimal-box.component';

describe('DecimalBoxComponent', () => {
  let component: DecimalBoxComponent;
  let fixture: ComponentFixture<DecimalBoxComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DecimalBoxComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DecimalBoxComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
