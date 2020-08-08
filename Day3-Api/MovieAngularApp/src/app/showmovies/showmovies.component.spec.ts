import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ShowmoviesComponent } from './showmovies.component';

describe('ShowmoviesComponent', () => {
  let component: ShowmoviesComponent;
  let fixture: ComponentFixture<ShowmoviesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ShowmoviesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ShowmoviesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
