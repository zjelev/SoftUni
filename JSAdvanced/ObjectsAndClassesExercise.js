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
    input.forEach(el => {
        let juiceArr = el.split(" => ");
        let juice = { [juiceArr[0]]: Number([juiceArr[1]]) };
        juices.push(juice);
    })

    juices.forEach(j => {
        console.log(Object.keys(j));
    })
}

cappyJuice(['Orange => 2000',
    'Peach => 1432',
    'Banana => 450',
    'Peach => 600',
    'Strawberry => 549']
)