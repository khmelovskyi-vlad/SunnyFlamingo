import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { UserModel } from '../../models/user-model';
import { OrderService } from '../../services/order.service';
import { DeliveryMethodModel } from '../../models/delivery-method-model';
import { UsersService } from '../../services/users.service';
import { AuthService } from '../../auth/auth.service';

@Component({
  selector: 'app-checkout',
  templateUrl: './checkout.component.html',
  styleUrls: ['./checkout.component.css']
})
export class CheckoutComponent implements OnInit {

  orderForm = this.fb.group({
    address: [],
    deliveryMethod: [],
    firstName: [],
    lastName: [],
    email: [],
  });
  deliveryMethods: DeliveryMethodModel[] = [];
  user: UserModel;

  constructor(private fb: FormBuilder, private orderService: OrderService, 
    private usersService: UsersService,
    private authService: AuthService) { }

  onSubmit(){
    this.orderService.getBasketGoods().subscribe(basketGoods =>{
      this.orderService.addOrder(this.orderForm, this.deliveryMethods, basketGoods).subscribe(res => console.log(res));
    });
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
  }

}
