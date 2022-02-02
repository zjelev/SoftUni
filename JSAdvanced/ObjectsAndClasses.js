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
}

// person.talk();

// let person2 = Object.assign({}, person);
// let propName = 'firstName';
// console.log(person2[propName]);

// person['jobtitle'] = 'Trainer';
// console.log(person['jobtitle']);
// console.log(person.age(30));
// delete person.age;
// console.log(person.age);

// let keys = Object.keys(person);
// //console.log(keys);
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

// for (const el of Object.keys(person)) {
//      console.log(`${el} --> ${person[el]}`);
// }

// let data = '[{"manager": {"firstName":"Pesho","lastName":"Petrov","height":180}}, {"firstName": "Gosho"}]'; //JSON.stringify(person);
// // console.log(data);
// let person2 = JSON.parse(data);
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

function sumByTown(input) {
    let data = input
        .map(v => v.split(','));
    
    let result = [];
    for (let i = 1; i < data.length; i+=2) {
        let town = {
            [data[i - 1]]: Number(data[i])
        };
        if (result.town.hasOwnProperty([data[i - 1]])) {
            result.push(town);
        }
    }
    return result;
}

console.log(sumByTown(['Sofia', '20', 'Varna', '3', 'Sofia', '5', 'Varna', '4']))

function fromJsonToHtmlTable(params) {
    
}

let res = ""
let check = res ? "Yes" : "No";
    console.log(check);