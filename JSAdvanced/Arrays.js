// // Lab
// // 05:00
// console.log(calc(sum, 1, 1)); // Hoisting
// let sum = (a, b) => a + b;   // Definition - Hoising does not work
function sum(a, b) {        // Declaration - Hoisting is OK
    return a + b;
}

function calc(oper, arg1, arg2) {
    let result = oper(arg1, arg2);
    console.log(num);
    var num = 10;        //with var num is hoisted (hiddenly declared) in beginning of scope
    return result + num;
}

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

// 46:15
let names = ['Pesho', 'Gosho', 'ivan', 'Stamat', 'Batman', 'superman', 'SpiderMan', 'captain America', 'Wonder Woman'];

// getNames(names);
function getNames(names) {
    // let firstName = names[0];
    // let secondName = names[1];
    // // Array destructuring
    let [firstName, ...others] = names; // Rest operator

    console.log(firstName);
    console.log(others);
}

// // 51:00 Mutator Methods
// let lastName = names.pop();
// names.push('Gerry');

function solve(...names) {           // Rest operator
    console.log(names.join(', '));
}
// solve('pesho', 'gosho', 'stamat');

// let numbers = [10, 2, 100, 4];
// let largestNumber = Math.max(...numbers);   // Spread operator

// 1:14 - Task 1
function sumFirstLast(params) {
    console.log(Number(params[0]) + Number(params[params.length - 1]));
}
// sumFirstLast(['20', '30', '40']);
// let result = names.splice(2, 1);

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
// evenPositionElement(['5', '30', '40']);

// 3
function negativePositiveNums(params) {
    let array = [];
    params.forEach(element => {
        if (element < 0) {
            array.unshift(element);
        } else {
            array.push(element)
        }
    });
    console.log(array.join(' '));
}

// let result = names.splice(2, names.length, 1, 3, 5); 
// let arr = [1, 2, 3, 4, 5, 6, 7, 10, 100, 256];
// arr.length = 5;
// arr.fill(5, 1, 3);  // Ctrl + Shift + Space
// arr.reverse();

// names.sort((a, b) => a.localeCompare(b));
function compareNums(a, b) {
    return a - b;
}
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

// names = names.some(x => x[0] === 'S');                       //Like Any in C#

// names = names.map(x => x.toUpperCase());                     // Like Select in C#

// names = names.reduce((accumulator, element) => {
//     return accumulator + element[0];
// }, '');

// // 4
// let start;
// let stop;

function lastKNumbersSequence(n, k) {
    let nums = [1];
    let sum = 1;
    for (let i = 1; i <= k; i++) {
        nums[i] = sum;
        sum += nums[i];
    }

    for (let i = k + 1; i < n; i++) {
        let lastK = nums.slice(i - k, i);
        let sum = 0;
        lastK.forEach(x => sum += x);
        nums[i] = sum;
    }
    return nums;
}
// console.log(lastKNumbersSequence(0, 1))

// function numSequent(n, k) {
//     let output = [1];
//     while(n-- > 1) {
//         let sum = 0;
//         for (let i = output.length - 1; i > output.length - 1 - k; i--) {
//             if (typeof(output[i]) == 'number') {
//                 sum += Number(output[i]);
//             }
//         }
//         output.push(sum);
//     }
//     return output;
// }

// start = Date.now();
// console.log(lastKNumbersSequence(16, 5))
// stop = Date.now();
// console.log(`My code spent ${stop - start} ms`);

// start = Date.now();
// console.log(numSequent(16, 5))
// stop = Date.now();
// console.log(`Other code spent ${stop - start} ms`);

// 5
function processOddPositions(params) {
    let result = params.filter((v, i) => i % 2 == 1).map(v => v * 2).reverse();
    return result;
}
// console.log(processOddPositions([10, 15, 20, 25]))

// 6
function smallestTwoNumbers(params) {
    let result = params.sort((a, b) => a -b).slice(0, 2)
    return result;
}
// console.log(smallestTwoNumbers([30, 15, 50, 5]));

// 7
function biggestElement(matrix) {  
    //let maxNum = Number.MIN_SAFE_INTEGER;
    // matrix.forEach(row => {
    //     row.forEach(el => {
    //         if (el > maxNum) {
    //             maxNum = el;
    //         }
    //     })
    // });

    // matrix.forEach(row => {
    //     let maxInRow = Math.max(...row);
    //     if ( maxInRow > maxNum) {
    //         maxNum = maxInRow;
    //     }
    // });

    // let maxNums = matrix.map(row => Math.max(...row));
    // let maxNum = Math.max(...maxNums);

    let maxNum = matrix
        .map(row => Math.max(...row))
        .reduce((a, x) => Math.max(a, x), Number.MIN_SAFE_INTEGER)

    return maxNum;
}
// console.log(biggestElement([[3, 5, 7, 12],[-1, 4, 33, 2],[8, 3, 0, 4]]));
// console.log(biggestElement([[20, 50, 10], [8, 33, 145]]));

// 8 
function diagonalSums(matrix) {
    let leftRightSum = 0;

    for (let i = 0; i < matrix.length; i++) {
        leftRightSum += matrix[i][i]; 
    }

    let rightLeftSum = 0;
    let reverseCounter = matrix.length;
    for (let i = 0; i < matrix.length; i++) {
        rightLeftSum += matrix[i][--reverseCounter];
    }
    return leftRightSum + ' ' + rightLeftSum;
}
// console.log(diagonalSums([[3, 5, 17],[-1, 7, 14],[1, -8, 89]]));

// 9. 
function equalNeighbors(matrix) {
    let sum = 0;
    let lastRow = matrix[matrix.length - 1];

    for (let i = 0; i < matrix.length - 1; i++) {
        for (let j = 0; j < matrix[i].length - 1; j++) {
            if ((matrix[i][j] === matrix[i + 1][j])) {
                sum++;
            }

            if (matrix[i][j] === matrix[i][j + 1]) {
                sum++;
            }
        }
    }

    for (let row = 0; row < matrix.length - 1; row++) {
        if (matrix[row][matrix[row].length - 1] === matrix[row + 1][matrix[row].length - 1]) {
            sum++;
        }
    }

    for (let col = 0; col < lastRow.length - 1; col++) {
        if (lastRow[col] === lastRow[col + 1]) {
            sum++
        }
    }
    return sum;
}
// console.log(equalNeighbors([['2', '3', '4', '7', '0'],
// ['4', '0', '5', '3', '4'],
// ['2', '3', '5', '4', '2'],
// ['9', '8', '7', '5', '4']]))

// console.log(equalNeighbors([['test', 'yes', 'yo', 'ho'],
// ['well', 'done', 'yo', '6'],
// ['not', 'done', 'yet', '5']]));

// console.log(equalNeighbors([[2, 2, 5, 7, 4],
// [4, 0, 5, 3, 4],
// [2, 5, 5, 4, 2]]))