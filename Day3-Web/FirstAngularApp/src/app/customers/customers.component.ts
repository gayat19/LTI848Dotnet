import { Component, OnInit } from '@angular/core';
import { CustomerService } from '../customer/customer.service';
import { Customer } from '../customer/customer';

@Component({
  selector: 'app-customers',
  templateUrl: './customers.component.html',
  styleUrls: ['./customers.component.css']
})
export class CustomersComponent implements OnInit {

  customers:Customer[];
  customer:Customer;
  constructor(private customerService:CustomerService) {
    this.customers = this.customerService.getCustomers();
   }

  ngOnInit(): void {
  }
  showOption(id:number){
    this.customer = this.customerService.getCustomer(id);
  }
}
