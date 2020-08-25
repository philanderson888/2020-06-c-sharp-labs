function sayHello(){
    alert('hello');
}

// global scope - whole application
var x02 = 10;

function variables(){
    // var is function scope
    var x01 = 10;

    console.log(x01);
    console.log(x02);

    alert('x01 is ' + x01 + ' and x02 is ' + x02)

    for(let j=0;j<5;j++){
        console.log(j);
    }

    // j is not in scope 
    // alert(j);

    const x03 = 100;
    // x03 = 200;  invalid

    const array01 = [1,2,3,4];
    alert(array01);
    array01[0]= 1000;
    alert(array01);

    // array01 = [2,3,4,5]; invalid 

}

addDataIntoDOM = function(){
    document.getElementById('putDataHere').innerHTML="I am putting some data <em><strong>here</strong></em>";
}

addDataAlsoHere = () =>{
    document.getElementById('putDataHere').innerHTML="I am putting some data <em><strong>here</strong></em>2";
}

addDataViaJQuery = () =>{
    $("#putDataHere").html("<strong>Some data via jQuery<strong>");
}

appendMoreData = () => {
    $("#putDataHere").append("<br />Some more data via jQuery");
}

appendDataByClass = () => {
    $(".alsoPutDataHere").text("Data added in bulk");
}