/*In JavaScript, you can use the this keyword in the global and function contexts. Moreover, the behavior of the  this keyword changes between strict and non-strict modes.*/


/*The this references the object of which the function is a property. In other words, the this references the object that is currently calling the function.*/


const counter = {
    count: 0,
    next: function () {
        return ++this.count;
    }
};

counter.next();

/*The next() is a function that is the property of the counter object. Therefore, inside the next() function, the this references the counter object.*/