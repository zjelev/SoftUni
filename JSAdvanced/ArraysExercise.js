function solve(input) {
    input.forEach(element => console.log(element));

    for (const key in input) {
        if (Object.hasOwnProperty.call(input, key)) {
            const element = key;
            console.log(element);
        }
    }

    for (const iterator of input) {
        console.log(iterator);
    }

    console.log(input.reduce((acc, curr) => acc *= curr))
}

// solve([1, 2 ,3, 4, 1, 9])

// React!!!
// 1
function solve(input) {
    return input.join(input.pop());
}
// console.log(solve(['One', 'Two', 'Three', 'Four', 'Five', '+']))

//2
function everyNthElement(input) {
    let output = [];
    let step = Number(input.pop());
    input.forEach((el, index) => {
        if (index % step == 0) {
            output.push(el);
        }
    })
    // return input.filter((v, i) => i % step == 0);
    return output.join("\n");
}
// console.log(everyNthElement(['5', '20', '31', '4', '20', '2']))

//3 
function addRemove(input) {
    let count = 1;
    let output = [];
    input.forEach(command => {
        if (command === 'add') {
            output.push(count);
        } else {
            output.pop();
        }
        count++;
    });
    output.length == 0 ? console.log('Empty') : console.log(output.join('\n'));
}
// addRemove(['add', 'add', 'remove', 'add', 'add']);

// 4
function rotateArray(input) {
    let count = input.pop() % input.length;
    for (let i = 0; i < count; i++) {
        input.unshift(input.splice(input.length - 1))// pop());
    }
    return input.join(' ');
}
// console.log(rotateArray([1, 2, 3, 4, 2]))
// console.log(rotateArray(['Banana', 'Orange', 'Coconut', 'Apple', '15']))

// 5
function increasingSubsequence(input) {
    let currMax = Number.MIN_SAFE_INTEGER;
    input = input.filter(num => {
        if (num >= currMax) {
            currMax = num;
            return true;
        } else {
            return false;
        }
    });
    return input.join("\n");
}
// console.log(increasingSubsequence([1, 3, 8, 4, 10, 12, 3, 2, 24]));
// console.log(increasingSubsequence([20, 3, 2, 15, 6, 1]));

//6
function arraySort2Crit(input) {
    // input.sort((a, b) => {
    //     if (a.length > b.length) {
    //         return 1;
    //     } else if (a.length === b.length) {
    //         return (a > b);
    //     } else {
    //         return -1;
    //     }
    // });
    const twoCrtSort = (a, b) => a.length - b.length || a.localeCompare(b);
    input.sort(twoCrtSort);
    return input.join("\n");
}
// console.log(arraySort2Crit(['test', 'Deny', 'omen', 'Default']));

// 7
function magicMatrices(matrix) {
    let sumRow = matrix[0].reduce((acc, curr) => acc + curr);
    for (let i = 0; i < matrix.length; i++) {
        if (sumRow !== matrix[i].reduce((acc, curr) => acc + curr)) {
            return false;
        } else {
            let sumCol = 0;
            for (let j = 0; j < matrix.length; j++) {
                sumCol += matrix[j][i];
            }
            if (sumRow !== sumCol) {
                return false;
            }
        }
    }
    return true;
}

// console.log(magicMatrices([[4, 5, 6],    [6, 5, 4],    [5, 5, 5]]      ))
// console.log(magicMatrices([[11, 32, 45],    [21, 0, 1],    [21, 1, 1]]        ))
// console.log(magicMatrices([[1, 0, 0],    [0, 0, 1],    [0, 1, 0]]      ))

// 8
function tictactoe(moves) {
    let matrix = [[false, false, false],
    [false, false, false],
    [false, false, false]];

    let counter = 0;

    for (const move of moves) {
        let [x, y] = move.split(' ').map(num => Number(num));
        if (matrix[x][y]) {
            console.log(`This place is already taken. Please choose another!`);
        } else {
            if (counter % 2 === 0) {
                matrix[x][y] = 'X'
            } else {
                matrix[x][y] = 'O'
            }
            counter++;

            if (counter === matrix.length ** 2) {
                console.log('The game ended! Nobody wins :(');
                for (const row of matrix) {
                    console.log(row.join('	'));
                }
                return;
            }

            // for (let i = 0; i < matrix.length; i++) {
            //     if (matrix[i][i] === matrix[i][i + 1] && matrix[i][i + 1] === matrix[i][i + 2] && matrix[i][i] ||
            //         matrix[i][i] === matrix[i + 1][i] && matrix[i + 1][i] === matrix[i + 2][i] && matrix[i][i]
            //     ) {
            //         console.log(`Player ${matrix[x][y]} wins`);
            //         for (const row of matrix) {
            //             console.log(row.join(' '));
            //         }
            //         return;
            //     }
            // }

            if (matrix[0][0] === matrix[0][1] && matrix[0][1] === matrix[0][2] && matrix[0][0] ||
                matrix[1][0] === matrix[1][1] && matrix[1][1] === matrix[1][2] && matrix[1][1] ||
                matrix[2][0] === matrix[2][1] && matrix[2][1] === matrix[2][2] && matrix[2][2] ||
                matrix[0][0] === matrix[1][0] && matrix[1][0] === matrix[2][0] && matrix[0][0] ||
                matrix[0][1] === matrix[1][1] && matrix[1][1] === matrix[2][1] && matrix[1][1] ||
                matrix[0][2] === matrix[1][2] && matrix[1][2] === matrix[2][2] && matrix[2][2] ||
                matrix[0][0] === matrix[1][1] && matrix[1][1] === matrix[2][2] && matrix[1][1] ||
                matrix[2][0] === matrix[1][1] && matrix[1][1] === matrix[0][2] && matrix[1][1]) {
                console.log(`Player ${matrix[x][y]} wins!`);
                for (const row of matrix) {
                    console.log(row.join('	'));
                }
                return;
            }
        }
    }
}

// tictactoe(["0 1", "0 0", "0 2", "2 0", "1 0", "1 2", "1 1", "2 1", "2 2", "0 0"])
// tictactoe(["0 0","0 0","1 1","0 1","1 2","0 2","2 2","1 2","2 2","2 1"])
// tictactoe(["0 1", "0 0", "0 2", "2 0", "1 0", "1 1", "1 2", "2 2", "2 1", "0 0"])

//9
function diagonalAttack(matrix) {
    let leftSum = 0;
    let rightSum = 0;
    let i = 0;
    let j = matrix.length - 1;
    matrix.forEach(row => {
        row = row.split(" ");
        leftSum += Number(row[i++]);
        rightSum += Number(row[j--])
    })

    i = 0;
    j = matrix.length - 1;
    let newMatrix = [];
    if (leftSum === rightSum) {
        matrix.forEach(row => {
            splitRow = row.split(" ");
            let newSplitRow = [];
            splitRow.forEach((v, index) => {
                if (index !== i && index !== j) {
                    v = leftSum;
                }
                newSplitRow.push(v);
            })
            newMatrix.push(newSplitRow.join(" "));
            i++;
            j--;
        })
        return newMatrix.join("\n");
    } else {
        return matrix.join("\n");
    }
}
// console.log(diagonalAttack(['1 1 1', '1 1 1', '1 1 0']))

// 10
function orbit(params) {
    let matrix = [];
    return matrix.join("\n");


}
console.log(orbit([4, 4, 0, 0]))
