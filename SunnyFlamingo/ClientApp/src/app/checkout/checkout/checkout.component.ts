import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { UserModel } from '../../models/user-model';
import { OrderService } from '../../services/order.service';
import { DeliveryMethodModel } from '../../models/delivery-method-model';
import { UsersService } from '../../services/users.service';
import { AuthService } from '../../auth/auth.service';
import { SelectedGoodsService } from '../../services/selected-goods.service';
import { BasketGoodModel } from '../../models/basket-good-model';

@Component({
  selector: 'app-checkout',
  templateUrl: './checkout.component.html',
  styleUrls: ['./checkout.component.css']
})
export class CheckoutComponent implements OnInit {

  basketGoods: BasketGoodModel[] = [];
  
  orderForm = this.fb.group({
    address: ['',Validators.required],
    deliveryMethod: ['',Validators.required],
    firstName: ['',Validators.required],
    lastName: ['',Validators.required],
    email: ['',Validators.required],
  });
  deliveryMethods: DeliveryMethodModel[] = [];
  user: UserModel;
  showValidation: boolean = false;
  orderAdded: boolean = false;

  constructor(private fb: FormBuilder, private orderService: OrderService, 
    private usersService: UsersService,
    private authService: AuthService,
    private selectedGoodsService: SelectedGoodsService ) { }
  
  getFormControl(name: string): FormControl{
    return this.orderForm.get(name) as FormControl;
  }

  getCount(): number{
    return this.selectedGoodsService.getCount();
  }
  getPrice(): number{
    return this.selectedGoodsService.getPrice();
  }

  onSubmit(){
    if (this.orderForm.invalid) {
      this.showValidation = true;
    }
    else{
      this.orderService.addOrder(this.orderForm, this.deliveryMethods, this.basketGoods).subscribe(res => {
        if (res === 1) {
          this.selectedGoodsService.removeAllValues();
          this.orderAdded = true;
        }
        else{

        }
      });
    }
  }

  ngOnInit(): void {
    this.orderService.searchDeliveryMethods().subscribe(deliveryMethods => this.deliveryMethods = deliveryMethods);
    this.authService.checkLogin().subscribe(isLogin => {
      if (isLogin) {
        this.usersService.getUserModel().subscribe(userModel => {
          this.orderForm.get('firstName')?.setValue(userModel.firstName);
          this.orderForm.get('lastName')?.setValue(userModel.lastName);
          this.orderForm.get('email')?.setValue(userModel.email);
        });
      }
    });
    this.selectedGoodsService.selectedBasketGoods.subscribe(basketGoods => this.basketGoods = basketGoods);
  }

}
