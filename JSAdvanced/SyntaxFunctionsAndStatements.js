// 1
function fruit(fruit, weight, price) {
    let kilograms = weight / 1000;
    let money = Number(kilograms) * price;
    return `I need $${money.toFixed(2)} to buy ${kilograms.toFixed(2)} kilograms ${fruit}.`;
}

// 2
function gcd_two_numbers(x, y) {
    if ((typeof x !== 'number') || (typeof y !== 'number')) 
      return false;
    x = Math.abs(x);
    y = Math.abs(y);
    while(y) {
      var t = y;
      y = x % y;
      x = t;
    }
    return x;
<<<<<<< HEAD
  }
  
  console.log(gcd_two_numbers(458, 2154));

  console.log(5 % 15)
// 3 Write a function that takes an integer number as an input and check 
// if all the digits in a given number are the same or not.
// Print on the console true if all numbers are same and false if not. 
// On the next line print the sum of all digits.
// The input comes as an integer number.
// The output should be printed on the console.

function areSameNumbers(int) {
  let digit = int % 10;
  let sum = 0;
  let areSameNumbers = true;
  while (int) {
    let current = int % 10;
    sum += current;
    if (current != digit) {
      areSameNumbers = false;
    }
    int = Math.floor(int / 10);
  }

  console.log(areSameNumbers);
  console.log(sum);
}

areSameNumbers(2222222);

// 4. Time to Walk
function timeToWalk(steps, stepLenghtMeters, speedKmH) {
  let distanceMeters = steps * stepLenghtMeters;
  let breaksMinutes = Math.floor(distanceMeters / 500);
  let speedMetersPerSecond = speedKmH * 1000 / 3600;
  let seconds = Math.ceil(distanceMeters / speedMetersPerSecond + breaksMinutes * 60);
  let hours = Math.floor(seconds / 3600);
  let minutes = Math.floor((seconds - hours * 3600) / 60);
  seconds = Math.floor(seconds - minutes * 60);

  console.log(`${hours < 10 ? 0 : ''}${hours}:${minutes < 10 ? 0 : ''}${minutes}:${seconds < 10 ? 0 : ''}${seconds}`);
}

timeToWalk(4000, 0.60, 5);
timeToWalk(2564, 0.70, 5.5);
=======
  }
>>>>>>> 477a155ec910852c0c24d4e0dfbeb84423f9b807
