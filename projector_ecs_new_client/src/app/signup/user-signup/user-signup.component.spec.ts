import { ComponentFixture, TestBed } from '@angular/core/testing';
import { UserSignupComponent } from './user-signup.component';


describe('SinginComponent', () => {
  let component: UserSignupComponent;
  let fixture: ComponentFixture<UserSignupComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [UserSignupComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(UserSignupComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
