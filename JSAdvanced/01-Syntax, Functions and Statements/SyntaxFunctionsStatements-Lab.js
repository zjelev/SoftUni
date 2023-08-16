// //sudo apt install nodejs

// console.log(+'5' / 2); //bad practice

function maxNum(first, second, third) {
    let result = Math.max(first, second, third);
    console.log(`The largest number is ${result}`);
}
// maxNum(5, -3, 16);

const foo = function(a, b, c) {
    console.log(a);
    console.log(b);
    console.log(c);
 }
//  foo(2,5)

function calculate(sth) {
    if (true)
        this.sth = sth;

    console.log(sth);
}
// sth = 'Gosho'
// calculate(sth)

// const count = 1;

// console.log(5 ** 4)

// let a = 5;
// let b = a = 10;
// console.log(a)
// console.log(b)

// console.log(5 ? 4 : 10)

// let value;
// if (value)
//     console.log(value)
// else
//     console.log('no value')

// console.log(typeof {})
// console.log(typeof [])
// console.log(typeof 5)
// console.log(typeof ' ')

// 01. Echo Function
function echo(input) {
    console.log(input.length);
    console.log(input);
}

//echo('Hello, JavaScript!');

//2. String Length
function stringLength(a, b, c) {
    console.log(a.length + b.length + c.length);
    console.log(Math.floor((a.length + b.length + c.length)/3));
}
// stringLength('chocolate', 'ice cream', 'cake');
// stringLength('pasta', '5', '22.3');

// 3
function largestNumber(a, b, c) {
    console.log(`The largest number is ${Math.max(a, b, c)}.`);
}
// largestNumber(5, -3, 16);
// largestNumber(-3, -5, -22.5);

// 4
function circleArea(params) {
    if (typeof(params) == 'number') {
        console.log((params * params * Math.PI).toFixed(2));
    } else {
        console.log(`We can not calculate the circle area, because we receive a ${typeof params}.`)
    }
}
// circleArea(5)
// circleArea('name')

// 8
function daysInMonth(month, year) {
    let date = new Date(year, month, 0).getDate();
    console.log(date);
}
// daysInMonth(2, 2024);

// 9
function squareOfStars(params = 5) {
    for (let index = 0; index < params; index++) {
        console.log('* '.repeat(params).trimEnd())
    }
}
// squareOfStars(2)

// 10
function aggregateElements(arr) {
    let sum = 0;
    let inverseSum = 0;
    let concat = '';
    for (let i = 0; i < arr.length; i++) {
      sum += Number(arr[i]);
      inverseSum += Number(1 / arr[i]);
      concat += String(arr[i]);
    }
    console.log(sum);
    console.log(inverseSum);
    console.log(concat);
  }
  aggregateElements([2, 4, 8, 16]);
