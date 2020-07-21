export class Food{
    name:String;
    type:String;
    likeCount:number;
    hateCount:number;
    constructor(name?,type?,lc?,hc?){
        this.name=name;
        this.type = type;
        this.likeCount = lc;
        this.hateCount = hc;
    }
}