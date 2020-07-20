import { Customer } from "./customer";

export class CustomerService{
    customers:Customer[];
    constructor(){
        this.customers =[new Customer(101,'Ramu',23),
                        new Customer(102,'Somu',31)];
    }
    getCustomer(id:number):Customer{
        let customer:Customer = null;
        
        this.customers.forEach(element => {
            if(element.id==id)
                customer = element;
        });
        return customer;
    }
    getCustomers():Customer[]{
        return this.customers;
    }
}