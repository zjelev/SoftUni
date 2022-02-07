// Lab
// 1
function stringLength(arg1, arg2, arg3) {
  let num1 = arg1.length;
  let num2 = arg2.length;
  let num3 = arg3.length;
  let sum = num1 + num2 + num3;
  let average = Math.floor(sum / 3);
  console.log(sum);
  console.log(average);
}

// stringLength('chocolate', 'ice cream', 'cake');
// stringLength('pasta', '5', '22.3');

// 2
function mathOperations(num1, num2, operator) {
  let result;
  switch (operator) {
    case '+': result = num1 + num2; break;
    case '-': result = num1 - num2; break;
    case '*': result = num1 * num2; break;
    case '/': result = num1 / num2; break;
    case '%': result = num1 % num2; break;
    case '**': result = num1 ** num2; break;
    default: break;
  }
   return result;
}
// mathOperations(5, 6, '+');
// mathOperations(3, 5.5, '*');

// 3
function sumOfNumbers(n, m) {
  let sum = 0;
  let first = +n;
  let last = +m;
  for (let i = first; i <= last; i++) {
    sum += i;
  }
  return sum;
}
// sumOfNumbers('1', '5');
// sumOfNumbers('-8', '20');

// 5
function circleArea(param) {
  let result;
  if (typeof(param) == 'number') {
    result = param ** 2 * Math.PI;
    console.log(result.toFixed(2));
  } else {
    console.log(`We can not calculate the circle area, because we receive a ${typeof(param)}.`)
  }
}

// circleArea(5);
// circleArea('name');

// 6
function squareOfStars(size = 1) {
  let line = '';
  for (let i = 0; i < size; i++) {
    for (let j = 0; j < size; j++) {
      line += '* ';
    }
    console.log(line);
    line = '';
  }
}

// squareOfStars();
// squareOfStars(2);
// squareOfStars(5);

// 7
function dayOfWeek(day = 'error') {
  let output;
  switch (day) {
    case 'Monday': output = 1; break;
    case 'Tuesday': output = 2; break;
    case 'Wednesday': output = 3; break;
    case 'Thursday': output = 4; break;
    case 'Friday': output = 5; break;
    case 'Saturday': output = 6; break;
    case 'Sunday': output = 7; break;
    default: output = 'error'; break;
  }
  console.log(output);
}

// dayOfWeek('Monday');
// dayOfWeek('Invalid');

// 8
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

// aggregateElements([2, 4, 8, 16])

// 9. *Words Uppercase
function wordsUppercase(inputStr) {
  // array = inputStr.split(/[\s,?'!.]+/);
  // let output = [];
  // for (let word of array) {
  //   output.push(word.toUpperCase())
  // }
  // return output.join(', ');

  return inputStr.toUpperCase()
    .split(/[\W]+/)
    .filter(w => w.length > 0)
    .join(', ')
}
//console.log(wordsUppercase('Functions in JS can be nested, i.e. hold other functions'));

// Exercise
// 1
function fruit(fruit, weight, price) {
  let kilograms = weight / 1000;
  let money = Number(kilograms) * price;
  return `I need $${money.toFixed(2)} to buy ${kilograms.toFixed(2)} kilograms ${fruit}.`;
}

// 2 Greatest Common Divisor
function gcd(x, y) {
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
}
//   console.log(gcd(458, 2154));
//   console.log(5 % 15)

// 3
function sameNumbers(int) {
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
// sameNumbers(2222222);

// 4
function timeToWalk(steps, stepLenghtMeters, speedKmH) {
  let distanceMeters = steps * stepLenghtMeters;
  let breaksMinutes = Math.floor(distanceMeters / 500);
  let speedMetersPerSecond = speedKmH * 1000 / 3600;
  let seconds = Math.ceil(distanceMeters / speedMetersPerSecond + breaksMinutes * 60);
  let hours = Math.floor(seconds / 3600);
  let minutes = Math.floor((seconds - hours * 3600) / 60);
  seconds = Math.floor(seconds - minutes * 60);
  return `${hours < 10 ? 0 : ''}${hours}:${minutes < 10 ? 0 : ''}${minutes}:${seconds < 10 ? 0 : ''}${seconds}`;
}
// console.log(timeToWalk(4000, 0.60, 5))
// console.log(timeToWalk(2564, 0.70, 5.5))

// 5
function roadRadar(speed, area) {
  let limit = 130;
  if (area === 'residential') {
    limit = 20;
  } else if (area === 'city') {
    limit = 50;
  } else if (area === 'interstate') {
    limit = 90;
  }
  let output = '';
  if (speed > limit + 40) {
    output = 'reckless driving';
  } else if (speed > limit + 20){
    output = 'excessive speeding';
  } else if (speed > limit) {
    output = 'speeding';
  }
  console.log(output);
  // let overLimit = speed - limit;
  // if (overLimit > 0) {
  //   console.log(`The speed is ${overLimit} km/h faster than the allowed speed of ${limit} - ${output}`);
  // } else {
  //   console.log(`Driving ${speed} km/h in a ${limit} zone`);
  // }
}
roadRadar(40, 'city');
roadRadar(21, 'residential');
roadRadar(120, 'interstate');
roadRadar(200, 'motorway');

// 6.
function cookingByNumbers(...params) {
  let number = +params.shift();
  let result = [];

  params.forEach(p => {
    switch (p) {
      case 'chop':
        number /= 2;
        break;
      case 'dice':
        number = Math.sqrt(number);
        break;
      case 'spice':
        number++;
        break;
      case 'bake':
        number *= 3;
        break;
      case 'fillet':
        number *= 0.80;
        break;
    }
    result.push((Math.round(number * 10) / 10));
  });
  return result.join("\n");
}
console.log(cookingByNumbers('32', 'chop', 'chop', 'chop', 'chop', 'chop'));
cookingByNumbers('9', 'dice', 'spice', 'chop', 'bake', 'fillet');

// 7
function validityChecker(x1, y1, x2, y2) {
  // let x1 = Number(params.shift());
  // let y1 = Number(params.shift());
  // let x2 = Number(params.shift());
  // let y2 = Number(params.shift());
  console.log(`{${x1}, ${y1}} to {0, 0} is ${isValid(x1, y1, 0, 0)}`);
  console.log(`{${x2}, ${y2}} to {0, 0} is ${isValid(x2, y2, 0, 0)}`);
  console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is ${isValid(x1, y1, x2, y2)}`);
  
  function isValid(x1, y1, x2, y2) {
    let distance = Math.sqrt((x2 - x1) ** 2 + (y2 - y1) ** 2);
    if (Number.isInteger(distance)) {
      return 'valid';
    } else {
      return 'invalid';
    };
  }
}
// validityChecker(3, 0, 0, 4);
// validityChecker(2, 1, 1, 1);