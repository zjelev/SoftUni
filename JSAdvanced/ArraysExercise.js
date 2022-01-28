// function solve(input) {
//     // input.forEach(element => {console.log(element);
//     // });

//     // for (const key in input) {
//     //     if (Object.hasOwnProperty.call(input, key)) {
//     //         const element = key;
//     //         console.log(element);
//     //     }
//     // }

//     // for (const iterator of input) {
//     //     console.log(iterator);
//     // }

//     console.log(input.reduce((acc, curr) => acc *= curr))
// }

// solve([1, 2 ,3, 4, 1, 9])

// React!!!
// // 1
// function solve(input) {
//     return input.join(input.pop());
// }
// console.log(solve(['One', 'Two', 'Three', 'Four', 'Five', '+']))

// //2
// function everyNthElement(input) {
//     //let args = [5, 5, 5, 5, 5];
//     let output = [];
//     let step = Number(input.pop());
//     input.forEach((el, index) => {
//         if (index % step == 0) {
//             output.push(el);
//         }
//     })//, args)
//     // console.log(input.filter((v, i) => i % step == 0));
//     return output;
// }
// console.log(everyNthElement(['5', '20', '31', '4', '20', '2']))

// //3 
// function addRemove(input) {
//     let count = 1;
//     let output = [];
//     input.forEach(command => {
//         if (command === 'add') {
//             output.push(count);
//         } else {
//             output.pop();
//         }
//         count++;
//     });
//     output.length == 0 ? console.log('Empty') : console.log(output.join('\n'));
// }
// addRemove(['add', 'add', 'remove', 'add', 'add']);

// // 4
// function rotateArray(input) {
//     let count = input.pop() % input.length;
//     for (let i = 0; i < count; i++) {
//         input.unshift(input.splice(input.length - 1))// pop());
//     }
//     console.log(input.join(' '));
// }
// rotateArray([1, 2, 3, 4, 2]);
// rotateArray(['Banana', 'Orange', 'Coconut', 'Apple', '15']);

// // 5
// function increasingSubsequence(input) {
//     let currMax = Number.MIN_SAFE_INTEGER;
//     // input.forEach(num => {
//     //     if (num > currMax) {
//     //         currMax = num;
//     //         console.log(currMax);
//     //     }
//     // });
//     input = input.filter(num => {
//         if (num > currMax) {
//             currMax = num;
//             return true;
//         } else {
//             return false;
//         }
//     });
//     return input;
// }
// console.log(increasingSubsequence([0, 3, 2, 15, 6, 1]));

//6
function arraySort2Crit(input) {
    input.sort((a, b) => {
        if (a.length > b.length) {
            return 1;
        } else if (a.length === b.length) {
            return (a > b);
        } else {
            return -1;
        }
    });
    return input;
}
console.log(arraySort2Crit(['test', 'Deny', 'omen', 'Default']));