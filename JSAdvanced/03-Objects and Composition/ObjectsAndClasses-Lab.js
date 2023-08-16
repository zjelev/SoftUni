let person = {
    firstName: 'Pesho',
    lastName: 'Petrov',
    age: function (myAge) {
        return `My age is ${myAge}`;
    },
    talk: function () {
        person.greet('qewwqdas');
    },
    height: 180,
    greet: name => console.log('Hello ' + name + '!'),
    course: {
        name: "JS",
        teacher: "Gosho",
    }
}

// person.talk();

let person2 = Object.assign({}, person); // cloning
let propName = 'firstName';
// console.log(person2[propName]);

person['jobtitle'] = 'Trainer';
// console.log(person['jobtitle']);
// console.log(person.age(30));
// delete person.age;
// console.log(person.age);

// let keys = Object.keys(person);
//console.log(keys);
// if (person.hasOwnProperty('age')) {
//     console.log(person.age(30));  // JS Core 
// }

// let values = Object.values(person);
// console.log(values);
// if (values.includes('Pesho')) {
//     console.log("found value");
// }

// for (const key in person) {
//     console.log(`${key} --> ${person[key]}`);
// }

// for (const el of Object.keys(person)) { // ForOf работи само с масиви
//      console.log(`${el} --> ${person[el]}`);
// }

// Object.keys(person.course).forEach((key) => {
//     console.log(key)
// })

let res = Object.entries(person);
//console.log(res);
let samePerson = Object.fromEntries(res);
//console.log(samePerson);

let data = '[{"manager": {"firstName":"Pesho","lastName":"Petrov","height":180}}, {"firstName": "Gosho"}]'; //JSON.stringify(person);
// console.log(data);
person2 = JSON.parse(data);
// console.log(person2[0].manager.firstName);

//1
function townsToJson(input) {
    let data = input
        .map(row => row.split('|').filter(x => x != '').map(x => x.trim()));

    let properties = data.shift();

    let result = [];

    data.forEach(row => {
        let town = {
            [properties[0]]: row[0],
            [properties[1]]: Number(Number(row[1]).toFixed(2)),
            [properties[2]]: Number(Number(row[2]).toFixed(2)),
        };
        result.push(town);
    });
    console.log(JSON.stringify(result));
}

// townsToJson(['| Town | Latitude | Longitude |', '| Sofia | 42.696552 | 23.32601 |', '| Beijing | 39.913818 | 116.363625 |']);

function sumByTown(input = []) {
    //.map(v => v.split(','));
    let result = {};
    for (let i = 1; i < input.length; i += 2) {
        if (!result.hasOwnProperty(input[i - 1])) {
            result[input[i - 1]] = Number(input[i]);
        } else {
            result[input[i - 1]] += Number(input[i]);
        }
    }
    return JSON.stringify(result);
}

// console.log(sumByTown(['Sofia', '20', 'Varna', '3', 'Sofia', '5', 'Varna', '4']))
//4
function fromJsonToHtmlTable(input) {
    let products = JSON.parse(input);
    let first = products[0];

    let html = "<table>";
    html += `
    <tr>${Object.keys(first).map(x => `<th>${x}</th>`).join("")}</tr>`;
    // html += products.map()
    products.forEach(product => {
        html += `  
    <tr>${Object.values(product).map(x => `<td>${x}</td>`).join("")}</tr>`;
    });
    html += `
</table>`;

    return html;
}

// console.log(fromJsonToHtmlTable(['[{"Name":"Pesho <div>-a","Age":20,"City":"Sofia"},{"Name":"Gosho","Age":18,"City":"Plovdiv"},{"Name":"Angel","Age":18,"City":"Veliko Tarnovo"}]']))

class Person {
    #currentAge;
    static type = 'Homo Sapiens';
    constructor(firstName, lastName, age = 0) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.#currentAge = age || 0;
    }

    get age() {
        return this.#currentAge
    }

    set age(value) {
        if (!(value < 0 || value > 120)) {
            this.#currentAge = value;
        }
    }

    get fullName() {
        return this.firstName + " " + this.lastName;
    }

    greet() {
        console.log(`Hello, my name is ${this.fullName}`);
    }

    static talk() {
        console.log('Im talking ' + this.type); // this refers to class!?
    }
}
// let person = new Person('Pesho', 'Petrov', 18);
// console.log(person.age);
// Person.talk();
// console.log(Person.type);
// console.log(person instanceof Person);

// No method overloading in JS. Only 1 ctor!

//3
function populationsInTowns(input) {
    let towns = {};
    input.forEach(el => {
        let [townKey, populationVal] = el.split(" <-> ");

        if (towns[townKey]) {
            towns[townKey] += Number(populationVal)
        } else {
            towns[townKey] = Number(populationVal)
        }
    })

    for (const key in towns) {
        console.log(`${key} : ${towns[key]}`);
    }
}

// populationsInTowns(['Sofia <-> 1200000','Montana <-> 20000','New York <-> 10000000','Washington <-> 2345000','Las Vegas <-> 1000000'])

//5
function lowestPricesInCities(input) {
    let products = [];
    let minPriceProducts = [];

    input.forEach(el => {
        let [town, product, price] = el.split(" | ");
        let obj = { product, town, price };
        let previous = products.find(x => x.product === product);
        if (!previous) {
            products.push(obj);
        } else {
            if (previous[price] < price) {
                products[previous] = obj;
            }
        }
    })
    products.forEach(p => console.log(`${p.product} -> ${p.price} (${p.town})`))
}

// lowestPricesInCities(['Sample Town | Sample Product | 1000', 'Sample Town | Orange | 2','Sample Town | Peach | 1',
//    'Sofia | Orange | 3','Sofia | Peach | 2','New York | Sample Product | 1000.1','New York | Burger | 10'])

//// 2023
function cityRecord(townName, population, gold) {
    let obj = {name: townName, population, treasury: gold};

    return obj;
}
// console.log(cityRecord('Tortuga', 7000, 15000));

function townPopulation(input) {
    let towns = {};

    input.forEach(line => {
        let [town, population] = line.split(' <-> ');
        population = Number(population);

        if (!towns.hasOwnProperty(town)) {
            towns[town] = 0;
        }

        towns[town] += population;
    });

    for (let town in towns) {
        console.log(`${town} : ${towns[town]}`);
    }
}

const input = [
    'Sofia <-> 1200000',
    'Montana <-> 20000',
    'New York <-> 10000000',
    'Washington <-> 2345000',
    'Las Vegas <-> 1000000'
];

//townPopulation(input);

function cityTaxes(name, population, treasury) {
    return {
        name,
        population,
        treasury,
        taxRate: 10,
        collectTaxes() {
            this.treasury += this.population * this.taxRate;
        },
        applyGrowth(percentage) {
            this.population *= 1 + percentage / 100;
        },
        applyRecession(percentage) {
            this.treasury *= 1 - percentage / 100;
        }
    };
}

// const city = cityTaxes('Tortuga', 7000, 15000);
// console.log(city);

function factory(library, orders) {
    let arr = [];
    
    for (const order of orders) {
        let template = order.template;

        for (const part of order.parts) {
            if (library.hasOwnProperty(part)) {
                template[part] = library[part];
            }
        }

        arr.push(template);
    }

    return arr;
}

const library = {
    print: function () {
        console.log(`${this.name} is printing a page`);
    },
    scan: function () {
        console.log(`${this.name} is scanning a document`);
    },
    play: function (artist, track) {
        console.log(`${this.name} is playing '${track}' by ${artist}`);
    },
};

const orders = [
    {
        template: { name: 'ACME Printer' },
        parts: ['print']
    },
    {
        template: { name: 'Initech Scanner' },
        parts: ['scan']
    },
    {
        template: { name: 'ComTron Copier' },
        parts: ['scan', 'print']
    },
    {
        template: { name: 'BoomBox Stereo' },
        parts: ['play']
    }
];

// const products = factory(library, orders);
// console.log(products);  

function createAssemblyLine() {
    let result = {
        hasClima(myCar) {
            myCar.temp = 21;
            myCar.tempSettings = 21;

            myCar.adjustTemp = () => {
                if (myCar.temp < myCar.tempSettings) {
                    myCar.temp += 1;
                } else if (myCar.temp > myCar.tempSettings) {
                    myCar.temp -= 1;
                }
            }
        },

        hasAudio(myCar) {
            myCar.currentTrack = null;

            myCar.nowPlaying = () => {
                if (myCar.currentTrack !== null) {
                    console.log(`Now playing '${myCar.currentTrack.name}' by ${myCar.currentTrack.artist}`);
                }
            }
        },

        hasParktronic(myCar) {
            myCar.checkDistance = (distance) => {
                if (distance < 0.1) {
                    console.log('Beep! Beep! Beep!');
                } else if (distance < 0.25) {
                    console.log('Beep! Beep!');
                } else if (distance < 0.5) {
                    console.log('Beep!');
                } else {
                    console.log('');
                }
            }
        }
    };

    return result;
}

const assemblyLine = createAssemblyLine();

const myCar = {
    make: 'Toyota',
    model: 'Avensis',
};

assemblyLine.hasClima(myCar);
console.log(myCar.temp);
myCar.tempSettings = 18;
myCar.adjustTemp();
console.log(myCar.temp);

assemblyLine.hasAudio(myCar);
myCar.currentTrack = {
    name: 'Never Gonna Give You Up',
    artist: 'Rick Astley'
};
myCar.nowPlaying();

assemblyLine.hasParktronic(myCar);
myCar.checkDistance(0.4);
myCar.checkDistance(0.2);

console.log(myCar);