//sudo apt install nodejs

function maxNum(first, second, third) {
    let result = Math.max(first, second, third);
    console.log(`The largest number is ${result}`);
}

maxNum(5, -3, 16);

const foo = function() {
    console.log("foobar");
 }
 foo()

function calculate(sth) {
    if (true) {
        this.sth = sth;
    }
    console.log(sth);
}
sth = 'Gosho'
calculate(sth)

const count = 1;

console.log(5 ** 4)

let a = 5;
let b = a = 10;
console.log(a)
console.log(b)

console.log(5 ? 4 : 10)

let value;
if (value) {
    console.log(value);
} else {
    console.log('no value')
}

function maxNum(first, second, third) {
    let result = Math.max(first, second, third);
    console.log(`The largest number is ${result}`);
}

maxNum(5, -3, 16);

const foo = function() {
    console.log("foobar");
 }
 foo()