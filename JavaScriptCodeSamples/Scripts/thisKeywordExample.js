﻿/*In JavaScript, you can use the this keyword in the global and function contexts. Moreover, the behavior of the  this keyword changes between strict and non-strict modes.*/


/*The this references the object of which the function is a property. In other words, the this references the object that is currently calling the function.*/


const counter = {
    count: 0,
    next: function () {
        return ++this.count;
    }
};

counter.next();

/*The next() is a function that is the property of the counter object. Therefore, inside the next() function, the this references the counter object.*/


/*Global Context*/
/*In the global context, the this references the global object, which is the window object on the web browser or global object on Node.js.*/
console.log(this === window);

/*If you assign a property to this object in the global context, JavaScript will add the property to the global object as shown in the following example:*/
this.color= 'Red';
console.log(window.color); // 'Red'


/*Function Context*/
/*In JavaScript, you can invoke a function in the following ways:
Function invocation
Method invocation
Constructor invocation
Indirect invocation
Each function invocation defines its own context, therefore, the this behaves differently than you may expect.
*/

/*Simple function invocation*/
/*In the non-strict mode, the this references the global object when the function is called as follows*/
function show() {
    console.log(this === window); // true
}

show();
/*When you call the show() function, the this references the global object, which is the window on the web browser and global on Node.js.*/
/*Calling the show() function is the same as:*/
window.show();

/*In the strict mode, JavaScript sets the this to undefined. Consider the following example:*/

function show() {
    "use strict";
    console.log(this === undefined);
}

show();


/*Method Invocation*/
/*When you call a method of an object, JavaScript sets this to the object that owns the method. See the following car object:*/
let car = {
    brand: 'Mercedes',
    getBrand: function () {
        return this.brand;
    }
}

console.log(car.getBrand());

console.log(brand()); // undefined

/*
You get undefined instead of "Honda" because when you call a method without specifying its object, JavaScript sets this to the global object in non-strict mode and undefined in the strict mode.
To fix this issue, you use the bind() method of the Function.prototype object. The bind() method creates a new function whose the this keyword is set to a specified value.
* */
let brand = car.getBrand.bind(car);
console.log(brand()); // Mercedes

/*In this example, the bind() method sets the this to the bike object, therefore, you see the value of the brand property of the bike object on the console.*/
let vehicle = {
    brand: 'Honda',
    getBrand: function () {
        return this.brand;
    }
}

let bike = {
    brand: 'Harley Davidson'
}

let manufacturer = car.getBrand.bind(bike);
console.log(manufacturer());