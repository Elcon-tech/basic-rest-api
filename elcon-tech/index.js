function wait(num) {
    return new Promise((resolve, reject) => {
        setTimeout(() => {
            console.log(num);
            resolve(num);
        }, num);
    
    });
}


// wait(() => {
//     console.log("callback function is called");
// }, 0);
