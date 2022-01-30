let person = {
    firstName: 'Pesho',
    lastName: 'Petrov',
    age: 30, 
    talk: function () {
        person.greet('qewwqdas');
    },
    height: 180,
    greet: name => console.log('Hello ' + name + '!'),
}

person.talk();

let person2 = Object.assign({}, person);
let propName = 'firstName';
console.log(person2[propName]);
