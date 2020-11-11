class Person
{
    firstName = "John"
    secondName = "Arbucle"
    
    private ssn: string = "123456789"

    constructor() 
    {
    
    }

    GetFullName() : string 
    {
        return this.firstName + " " + this.secondName;    
    }
}

let p = new Person();
console.log(p.GetFullName());
