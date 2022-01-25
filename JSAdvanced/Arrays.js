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
//     var num = 10;        //with var num is hoisted (hiddenly declared) in beginning of scope
//     return result + num;
// }

// let sum = 5; // Error

// let result = calc(sum, 5, 10);

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
let names = ['Pesho', 'Gosho', 'ivan', 'Stamat', 'Batman', 'superman', 'SpiderMan', 'captain America', 'Wonder Woman'];

// getNames(names);

// function getNames(names) {
//     // let firstName = names[0];
//     // let secondName = names[1];
//     // // Array destructuring
//     let [firstName, ...others] = names; // rest operator

//     console.log(firstName);
//     console.log(others);
// }

// // 51:00 Mutator Methods
// let lastName = names.pop();

// names.push('Gerry');
// console.log(names.push('Gerry'));

// function solve(...names) {           // Rest operator
//     console.log(names.join(', '));
// }
// solve('pesho', 'gosho', 'stamat');

let numbers = [10, 2, 100, 4];
// let largestNumber = Math.max(...numbers);   // Spread operator

// // 1:14 - Task 1
// function sumFirstLast(params) {
//     console.log(Number(params[0]) + Number(params[params.length - 1]));
// }

// sumFirstLast(['20', '30', '40']);
// let result = names.splice(2, 1);

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

// arr = names.slice();

// 2:00 Iteration Methods

// for (const name of names) {      // forof
//     console.log(name);
// }
// names.forEach((x, i, arr) => console.log(x + ' ' + i + ' ' + arr));

// names = names.filter(x => (x[0] !== 'S' && x[0] !== 's'));   // returns all

// names = names.find(x => x[0] === 'S');                       // Like FirstOrDefault in C#

// names = names.some(x => x[0] === 'S');  //Like Any in C#

// names = names.map(x => x.toUpperCase());                     // Like Select in C#

// names = names.reduce((accumulator, element) => {
//     return accumulator + element[0];
// }, '');

// // 4
let start;
let stop;

function lastKNumbersSequence(n, k) {
    let nums = [1];
    let sumPreviosElements = 0;
    for (let i = 0; i < k - 1; i++) {
        sumPreviosElements += nums[i];
        nums.push(sumPreviosElements);
    }
    
    // for (let i = k; i < n; i++) {
    //     let nextNum = 0;
    //     for (let j = k; j > 0; j--) {
    //         nextNum += Number(nums[i - j]);
    //     }
    // }

    while(n-- > k) {
        let sum = 0;
        for (let i = nums.length - 1; i > nums.length - 1 - k; i--) {
            //if (typeof(nums[i]) == 'number') {
                sum += Number(nums[i]);
            // }
        }
        nums.push(sum);
    }

    return nums;
}

function numSequent(n, k) {
    let output = [1];
    while(n-- > 1) {
        let sum = 0;
        for (let i = output.length - 1; i > output.length - 1 - k; i--) {
            if (typeof(output[i]) == 'number') {
                sum += Number(output[i]);
            }
        }
        output.push(sum);
    }
    return output;
}

start = Date.now();
console.log(lastKNumbersSequence(16, 5))
stop = Date.now();
console.log(`My code spent ${stop - start} ms`);

start = Date.now();
console.log(numSequent(16, 5))
stop = Date.now();
console.log(`Other code spent ${stop - start} ms`);