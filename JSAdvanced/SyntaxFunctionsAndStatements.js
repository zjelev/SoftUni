// // 1 Fruit
// function fruit(fruit, weight, price) {
//     let kilograms = weight / 1000;
//     let money = Number(kilograms) * price;
//     return `I need $${money.toFixed(2)} to buy ${kilograms.toFixed(2)} kilograms ${fruit}.`;
// }

// // 2 Greatest Common Divisor - GCD
// function gcd_two_numbers(x, y) {
//     if ((typeof x !== 'number') || (typeof y !== 'number')) 
//       return false;
//     x = Math.abs(x);
//     y = Math.abs(y);
//     while(y) {
//       var t = y;
//       y = x % y;
//       x = t;
//     }
//     return x;
//   }
  
//   console.log(gcd_two_numbers(458, 2154));

//   console.log(5 % 15)
// // 3 Same Numbers

// function areSameNumbers(int) {
//   let digit = int % 10;
//   let sum = 0;
//   let areSameNumbers = true;
//   while (int) {
//     let current = int % 10;
//     sum += current;
//     if (current != digit) {
//       areSameNumbers = false;
//     }
//     int = Math.floor(int / 10);
//   }

//   console.log(areSameNumbers);
//   console.log(sum);
// }

// areSameNumbers(2222222);

// // 4. Time to Walk
// function timeToWalk(steps, stepLenghtMeters, speedKmH) {
//   let distanceMeters = steps * stepLenghtMeters;
//   let breaksMinutes = Math.floor(distanceMeters / 500);
//   let speedMetersPerSecond = speedKmH * 1000 / 3600;
//   let seconds = Math.ceil(distanceMeters / speedMetersPerSecond + breaksMinutes * 60);
//   let hours = Math.floor(seconds / 3600);
//   let minutes = Math.floor((seconds - hours * 3600) / 60);
//   seconds = Math.floor(seconds - minutes * 60);

//   console.log(`${hours < 10 ? 0 : ''}${hours}:${minutes < 10 ? 0 : ''}${minutes}:${seconds < 10 ? 0 : ''}${seconds}`);
// }

// timeToWalk(4000, 0.60, 5);
// timeToWalk(2564, 0.70, 5.5);

// // 5. Road Radar
// function roadRadar(speed, area) {
//   let limit = 0;
//   if (area === 'residential') {
//     limit = 20;
//   } else if (area === 'city') {
//     limit = 50;
//   } else if (area === 'interstate') {
//     limit = 90;
//   } else {
//     limit = 130;
//   }
//   let output = '';
//   if (speed > limit + 40) {
//     output = 'reckless driving'
//   } else if (speed > limit + 20){
//     output = 'excessive speeding'
//   } else if (speed > limit) {
//     output = 'speeding '
//   }
//   let overLimit = speed - limit;
//   if (overLimit > 0) {
//     console.log(`The speed is ${overLimit} km/h faster than the allowed speed of ${limit} - ${output}`);
//   } else {
//     console.log(`Driving ${speed} km/h in a ${limit} zone`)
//   }
// }

// roadRadar(40, 'city');
// roadRadar(21, 'residential');
// roadRadar(120, 'interstate');
// roadRadar(200, 'motorway');

// 6. Cooking by Numbers
// function cookingByNumbers(first, op1, op2, op3, op4, op5) {
//   let number = Number(first);
//   let input = [op1, op2, op3, op4, op5];
//   for (let i = 0; i < input.length; i++) {
//     switch (input[i]) {
//       case 'chop':
//         number /= 2;
//         break;
//       case 'dice':
//         number = Math.sqrt(number);
//         break;
//       case 'spice':
//         number++;
//         break;
//       case 'bake':
//         number *= 3;
//         break;
//       case 'fillet':
//         number *= 0.80;
//         break;
//     }
//     console.log(number);
//   }
// }

// cookingByNumbers('32', 'chop', 'chop', 'chop', 'chop', 'chop');
// cookingByNumbers('9', 'dice', 'spice', 'chop', 'bake', 'fillet');

// 7. Validity Checker
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

validityChecker(3, 0, 0, 4);
validityChecker(2, 1, 1, 1);

// 8. *Words Uppercase
function wordsUppercase(params) {
  
}