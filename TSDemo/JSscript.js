function add(first, second)
{
    return first + second;
}

function sub(first, second)
{
    return first - second;
}

// Create object manually
let objCalculator = {};
objCalculator.first = 10;
objCalculator.second = 20;
objCalculator.op = add;
objCalculator.exec = function(){console.log(this.op(this.first, this.second))};

// Create object with function 
function createFuncCalculator(first, second, op, exec)
{
    let obj = {};
    obj.first = first;
    obj.second = second;
    obj.op = op;
    obj.exec = exec;
    return obj;
}
let funcCalculator = createFuncCalculator(20, 20, sub, objCalculator.exec)

// Create object with prototype/ctor
class CtorCalculator {
    constructor(first, second, op, exec) {
        this.first = first;
        this.second = second;
        this.op = op;
        this.exec = exec;
    }
}

let ctorCalculator = new CtorCalculator(30, 20, sub, objCalculator.exec);
ctorCalculator.exec();
