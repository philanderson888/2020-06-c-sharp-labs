console.log('hello world from Node');

for (let i=0;i<=10;i++){
    console.log(i);
}


setTimeout(   () => {
    console.log('pushing alert from lambda timeout');
}    ,2000);

doThis = () =>{
    console.log("printed after a 2 second delay")
}

var counter=0;
alsoDoThis = () =>{
    console.log(  new Date() );
    counter++;
    if(counter>=2){
        clearInterval(runningTimer);
    }
}

// set timeout - delay 2 seconds then print something
setTimeout(doThis,2000);

// set interval - print every 2 seconds until stop application
var runningTimer = setInterval(alsoDoThis,1000);


// array handling
console.log("\n\nArray Handling")
const myArray = [10,20,30];
console.log(myArray);
for (let i=0;i<myArray.length;i++){
    console.log(myArray[i])
}

// push and pop, shift and unshift
myArray.push(400);
myArray.push(500);
console.log(myArray);
myArray.pop();
console.log(myArray);
myArray.unshift(5);
myArray.unshift(6);
console.log(myArray);
myArray.shift();
console.log(myArray);