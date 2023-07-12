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