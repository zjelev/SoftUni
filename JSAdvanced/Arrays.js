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
// console.log(emptyArr.length);
// emptyArr.length = 10; // Arrays are not guaranteed to be dense
// console.log(emptyArr.length);
// console.log(emptyArr);
// emptyArr[100] = 'kooj';
// console.log(emptyArr);

// emptyArr.unshift("hi", "my name is");
// console.log(emptyArr);
// emptyArr.length = 5;
// console.log(emptyArr);

// let array = [10, 3, 'Pesho', 6, true]; // Mixing types is bad practice
// // console.log(array);
// console.log(array[-1]);
// // array[array.length + 10] = 'Gerry';
// console.log(array);
// array[-1] = 'Gosho';
// console.log(array); 
// console.log(array.length);  //WTF

// // 46:15
let names = ['Pesho', 'Gosho', 'Ivan', 'Stamat']
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


// 2
function evenPositionElement(params) {
    let output = '';
    // for (let i = 0; i < params.length; i+=2) {
    //     output += params[i] + ' ';
    // }

    for (const key in params) {
        if (key % 2 == 0) {
            output += params[key] + ' ';
        }
    }
    console.log(output);
}

evenPositionElement(['5', '30', '40']);

// 3
function negativePositiveNums(params) {
    let array = [];
    params.forEach(element => {
        if (element <  0) {
            array.unshift(element);
        } else {
            array.push(element)
        }
    });
    console.log(array.join(' '));
}