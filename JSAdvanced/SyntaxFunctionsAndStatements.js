function fruit(fruit, weight, price) {
    let kilograms = weight / 1000;
    let money = Number(kilograms) * price;
    return `I need $${money.toFixed(2)} to buy ${kilograms.toFixed(2)} kilograms ${fruit}.`;
}

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
  }
  
  console.log(gcd_two_numbers(2154, 458));
  console.log(gcd_two_numbers(15, 5));