"use strict";
class Person {
    constructor() {
        this.firstName = "John";
        this.secondName = "Arbucle";
        this.ssn = "123456789";
    }
    GetFullName() {
        return this.firstName + " " + this.secondName;
    }
}
let p = new Person();
console.log(p.GetFullName());
