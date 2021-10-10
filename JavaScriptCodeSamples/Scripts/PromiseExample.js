/*In JavaScript, a promise is an object that returns a value which you hope to receive in the future, but not now.*/

/* A promise has three states:
Pending:the promise is unfulfilled.
Fulfilled: the promise has been fulfilled and returned a value 
Rejected: the promise has errored.*/


let completed = true;

let learnJS = new Promise(function (resolve, reject) {
    // Time out simulates an asynchronous call 
    setTimeout(() => {
        if (completed) {
            resolve("I have completed learning JS.");
        } else {
            reject("I haven't completed learning JS yet.");
        }
    }, 3 * 1000);
});


/*Consuming a Promise: then, catch, finally*/
/*The then() method is used to schedule a callback to be executed when the promise is successfully resolved.

The then() method takes two callback functions:promiseObject.then(onFulfilled, onRejected);*/

function makePromise(completed) {
    return new Promise(function (resolve, reject) {
        setTimeout(() => {
            if (completed) {
                resolve("I have completed learning JS.");
            } else {
                reject("I haven't completed learning JS yet.");
            }
        }, 3 * 1000);
    });
}


let learnJsResult= makePromise(true);

learnJsResult.then(
    success => console.log(success),
    reason => console.log(reason) // returns reason why promise was rejected
);

learnJsResult.then(
    value => console.log(value)
);

/*Rejected Case */
let masterJS = makePromise(false);

masterJS.then(
    undefined,
    reason => console.log(reason)
);

/*catch*/
/*If you want to schedule a callback to be executed when the promise is rejected, you can use the catch() method of the Promise object:*/
learnJS.catch(
    reason => console.log(reason)
);

/*Finally*/

/*Sometimes, you want to execute the same piece of code whether the promise is fulfilled or rejected.*/

function createApp() {
    // ...
}

learnJS
    .then(
        (success) => {
            console.log(success);
            createApp();
        }
    ).catch(
    (reason) => {
        console.log(reason);
        createApp();
    }
);

/*Finally refactored*/
learnJS
    .then(success => console.log(success))
    .catch(reason => console.log(reason))
    .finally(() => createApp());


function load(url) {
    return new Promise(function (resolve, reject) {
        const request = new XMLHttpRequest();

        request.onreadystatechange = function (e) {
            if (this.readyState === 4) {
                if (this.status === 200) {
                    resolve(this.response);
                } else {
                    reject(this.status);
                }
            }
        }
        request.open('GET', url, true);
        request.send();
    });
}

