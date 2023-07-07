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

// 1
function solve(arr, d) {
    return arr.join(d)
}
//console.log(solve(['One', 'Two', 'Three', 'Four', 'Five'], '+'))

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

    // input.forEach(command => {
    //     if (command === 'add') {
    //         output.push(count);
    //     } else {
    //         output.pop();
    //     }
    //     count++;
    // });

    input.map(el => {
        el === 'remove' ? output.pop() : output.push(count);
        count++;
    })

    output.length == 0 ? console.log('Empty') : console.log(output.join('\n'));
}
// addRemove(['add', 'add', 'remove', 'add', 'add']);

// 4
function rotateArray(arr, n) {
    for (let i = 0; i < n % arr.length; i++) {
        arr.unshift(arr.pop());
    }
    return arr.join(' ');
}
// console.log(rotateArray([1, 2, 3, 4, 2]))
// console.log(rotateArray(['Banana', 'Orange', 'Coconut', 'Apple', '15']))

// 5
function increasingSubsequence(input) {
    // let currMax = Number.MIN_SAFE_INTEGER;
    // return input.filter(num => {
    //     if (num >= currMax) {
    //         currMax = num;
    //         return true;
    //     } else {
    //         return false;
    //     }
    // })
    return input.reduce((a, v) => {
        if (v >= (a[a.length - 1] || input[0])) {
            a.push(v)
        };
        return a;
    }, [])
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
    return input.sort(twoCrtSort).join("\n");
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
        if (matrix[x][y])
            console.log(`This place is already taken. Please choose another!`);
        else {
            matrix[x][y] = counter % 2 === 0 ? 'X' : 'O';
            counter++;

            if (counter === matrix.length ** 2) {
                console.log('The game ended! Nobody wins :(');
                for (const row of matrix) {
                    console.log(row.join('	'));
                }
                return;
            }

            let playerWins = false;

            if (matrix[x].every(z => z == matrix[x][y]) ||
                matrix.reduce((a, v) => {
                    a.push(v[y])
                    return a
                }, []).every(z => z === matrix[x][y]) ||
                matrix[0][0] === matrix[1][1] && matrix[1][1] === matrix[2][2] && matrix[1][1] ||
                matrix[2][0] === matrix[1][1] && matrix[1][1] === matrix[0][2] && matrix[1][1])
            {
                playerWins = true;
            }

            if (playerWins) {
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
// tictactoe(["0 0", "0 0", "1 1", "0 1", "1 2", "0 2", "2 2", "1 2", "2 2", "2 1"])
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
    for (let i = 0; i < params[0]; i++) {
        matrix.push([]);
        for (let j = 0; j < params[1]; j++) {
            matrix[i][j] = Math.max(Math.abs(i - params[2]), Math.abs(j - params[3])) + 1;
        }
    }
    return matrix;
}
// console.log(orbit([5, 5, 2, 2]));

// 11
function spiralMatrix(w, h) {
    let matrix = new Array(w).fill(new Array(h).fill(""))
    matrix = matrix.map(x => x.map(y => ""))
    let [startRow, endRow, startClmn, endClmn, counter] = [0, h - 1, 0, w - 1, 0]

    while (startClmn <= endClmn && startRow <= endRow) {
        for (let i = startClmn; i <= endClmn; i++) {
            matrix[startRow][i] = ++counter
        }
        startRow++
        for (let i = startRow; i <= endClmn; i++) {
            matrix[i][endClmn] = ++counter
        }
        endClmn--
        for (let i = endClmn; i >= startClmn; i--) {
            matrix[endRow][i] = ++counter
        }
        endRow--
        for (let i = endRow; i >= startRow; i--) {
            matrix[i][startClmn] = ++counter
        }
        startClmn++
    }

    return matrix.map(x => x.join(" ")).join("\n")
}

// console.log(spiralMatrix(6, 6))
