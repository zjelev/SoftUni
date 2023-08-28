// 4
function heroicInventory(input) {
    let heroes = [];
    input.forEach((line) => {
        let [name, level, items] = line.split(" / ");
        level = Number(level);
        items = items ? items.split(", ") : [];
        let hero = { name, level, items };
        heroes.push(hero);
    });
    return JSON.stringify(heroes);
}
// heroicInventory(['Isacc / 25 / Apple, GravityGun','Derek / 12 / BarrelVest, DestructionSword','Hes / 1 / Desolator, Sentinel, Antara']);

//2
function JsonsTable(input) {
    let employees = [];
    input.forEach(el => {
        employees.push(JSON.parse(el));
    });

    let table = "<table>\n";
    employees.forEach(e => {
        table += '\t<tr>\n'
        Object.values(e).forEach(v => {
            table += `\t\t<td>${v}</td>\n`
        })
        table += '\t</tr>\n';
    })
    table += '</table>';
    return table;
}

// console.log(
//     JsonsTable(['{"name":"Pesho","position":"Promenliva","salary":100000}',
//         '{"name":"Teo","position":"Lecturer","salary":1000}',
//         '{"name":"Georgi","position":"Lecturer","salary":1000}']
//     ))

//3
function cappyJuice(input) {
    let juices = {};
    let juicesInOrder = {};
    input.forEach(el => {
        let [product, qty] = el.split(" => ");
        
        if (!juices[product]) {
            juices[product] = Number(qty);
        } else {
            juices[product] += Number(qty);
        }
        
        if (juices[product] >= 1000) {
            juicesInOrder[product] = parseInt(juices[product] / 1000);
        }
    });

    Object.keys(juicesInOrder).forEach(key => console.log(`${key} => ${juicesInOrder[key]}`));
}

// cappyJuice(['Kiwi => 234','Pear => 2345','Watermelon => 3456','Kiwi => 4567','Pear => 5678','Watermelon => 6789'])

// 2023
function calorieObject(arr) {
    let obj = {};
    for (let i = 0; i < arr.length; i+=2) {
        obj[arr[i]] = Number(arr[i + 1]);
    }
    return obj;
}

// console.log(calorieObject(['Yoghurt', '48', 'Rise', '138', 'Apple', '52']))

function constructionCrew(obj) {
    if (obj.dizziness) {
        obj.levelOfHydrated += 0.1*obj.weight*obj.experience;
        obj.dizziness = false;
    }
    return obj;
}

// console.log(constructionCrew({ weight: 120, experience: 20, levelOfHydrated: 200, dizziness: true }))

function carFactory(obj) {
    let engines = {
        Small: { power: 90, volume: 1800 } ,
        Normal: { power: 120, volume: 2400 },
        Monster: { power: 200, volume: 3500 }
    };

    let car = {
        model: obj.model,
        carriage: { 
            type: obj.carriage,
            color: obj.color
        }
    };
     
    if (obj.power <= 90 ) {
        car.engine = engines.Small;
    } else if (obj.power <= 120) {
        car.engine = engines.Normal;
    } else {
        car.engine = engines.Monster;
    }
    
    let wheels = [];
    if (obj.wheelsize % 2 == 0) {
        obj.wheelsize--;
    }

    for (let i = 0; i < 4; i++) {
        wheels.push(obj.wheelsize)   
    }

    car.wheels = wheels;
    
    return car;
}

console.log(carFactory({model: 'VW Golf II', power: 90, color: 'blue', carriage: 'hatchback', wheelsize: 14 }))