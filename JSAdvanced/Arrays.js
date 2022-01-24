// // Lab
// // 05:00
// console.log(calc(sum, 1, 1)); // Hoisting

// // let sum = (a, b) => a + b; // Definition - Hoising does not work

// function sum(a, b) {        // Declaration - Hoisting is OK
//     return a + b;
// }

// function calc(oper, arg1, arg2) {
//     let result = oper(arg1, arg2);
//     console.log(num);
//     var num = 10; //with var num is hoisted (hiddenly declared) in beginning of scope
//     return result + num;
// }

// //let sum = 5; // Error

// let result = calc(sum, 5, 10);
// console.log(result);

// //26:12
// let emptyArr = [];
// emptyArr[100] = 'kooj';

// emptyArr.unshift("hi", "my name is");

// emptyArr.length = 5;

// let array = [10, 3, 'Pesho', 6, true]; // Mixing types is bad practice
// console.log(array[-1]);
// // array[array.length + 10] = 'Gerry';
// console.log(array);
// array[-1] = 'Gosho';
// console.log(array); 
// console.log(array.length);  //WTF

// // 46:15
let names = ['Pesho', 'Gosho', 'ivan', 'Stamat', 'Batman', 'Superman', 'SpiderMan', 'captain America', 'Wonder Woman'];

// getNames(names);

// function getNames(names) {
//     // let firstName = names[0];
//     // let secondName = names[1];
//     // Array destructuring
//     let [firstName, ...others] = names; // rest operator

//     console.log(firstName);
//     console.log(others);
// }

// // 51:00 Mutator Methods
// let lastName = names.pop();

// names.push('Gerry');
// console.log(names.push('Gerry'));

// console.log(lastName);
// console.log(names);


// function solve(...names) {           // Rest operator
//     console.log(names.join(', '));
// }
// solve('pesho', 'gosho', 'stamat');

// let numbers = [10, 2, 100, 4];
// let largestNumber = Math.max(...numbers);   // Spread operator
// console.log(largestNumber);

//  1:14 - Task 1
// function sumFirstLast(params) {
//     console.log(Number(params[0]) + Number(params[params.length - 1]));
// }

// sumFirstLast(['20', '30', '40']);
// console.log(names);
// let result = names.splice(2, 1);
// console.log(result);
// console.log(names);


// // 2
// function evenPositionElement(params) {
//     let output = '';
//     // for (let i = 0; i < params.length; i+=2) {
//     //     output += params[i] + ' ';
//     // }

//     for (const key in params) {
//         if (key % 2 == 0) {
//             output += params[key] + ' ';
//         }
//     }
//     console.log(output);
// }

// evenPositionElement(['5', '30', '40']);

// // 3
// function negativePositiveNums(params) {
//     let array = [];
//     params.forEach(element => {
//         if (element <  0) {
//             array.unshift(element);
//         } else {
//             array.push(element)
//         }
//     });
//     console.log(array.join(' '));
// }

let result;

// result = names.splice(2, names.length, 1, 3, 5); 

// console.log(result);
// console.log(names);

let arr = [1, 2, 3, 4, 5, 6, 7, 10, 100, 256];
// arr.length = 5;
// arr.fill(5, 1, 3);  // Ctrl + Shift + Space
// arr.reverse();

// names.sort((a, b) => a.localeCompare(b));
// function compareNums(a, b) {
//     return a - b;
// }
// arr.sort();              //Sorts by Inicode symbol code
// arr.sort((a, b) => b - a);  //Arrow function (lambda in c#)

// 1:42 Accessor Methods
// console.log(names.join('--|--'));

// result = names.indexOf('Pesho1');  // like includes, but returns index
// if (result > -1) {
//     console.log('Ima go');
// } else {
//     console.log('Nqma go');
// }

// names.concat(arr);

arr = names.slice();

console.log(names);
console.log(result);
console.log(arr);
// console.log(newArr);