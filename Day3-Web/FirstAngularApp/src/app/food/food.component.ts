import {Component, OnInit} from '@angular/core';
import {Food} from './food';
import { FormGroup, FormControl, Validators } from '@angular/forms';


@Component({
    selector:'app-food',
    templateUrl:'./food.component.html',
    styleUrls:['./food.component.css']
})
export class FoodComponent {
    food:Food;
    myForm:FormGroup;
    showDetails:boolean;
constructor(){
    this.food = new Food();
    this.myForm = new FormGroup({
        fn:new FormControl(null,Validators.required),
        foodtype:new FormControl(null,Validators.required),
        foodlike:new FormControl(null,[Validators.required,Validators.min(1)]),
        foodhate:new FormControl(null,Validators.required)
    });
    this.showDetails = false;
}

public get fname() {
    return this.myForm.get('fn');
}
public get foodtype() {
    return this.myForm.get('foodtype');
}
public get foodlike() {
    return this.myForm.get('foodlike');
}
public get foodhate() {
    return this.myForm.get('foodhate');
}

showFood(){
    //console.log(this.myForm);
    if(this.myForm.valid)
    {
        this.showDetails = true;
        this.food.name = this.fname.value;
        this.food.type = this.foodtype.value;
        this.food.likeCount = this.foodlike.value;
        this.food.hateCount = this.foodhate.value;
        
    }
        
    //console.log(this.showDetails)
}
likeChange(){
    this.food.likeCount++;
    //this.food.hateCount--;
    }
    hateChange(){
        this.food.hateCount++;
        //this.food.likeCount--;
        }
}