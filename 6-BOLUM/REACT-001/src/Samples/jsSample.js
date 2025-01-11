console.log("Calistim");

const string1 = "Merhaba";
const number1 = 23;
const boolean1 = true;
let array1 = [12, 22, "asd", true, [2, "asdf", false]]


let object = {
    key: "value",
    oguzhan: 'oguzhan',
    age: 29,
    isWorking: true,
    hobbies: ["coding", "music"],
    others: {
        city: "Istanbul",
        nation: "Turkey"
    },
    sayHello: () => {
        console.log("Hello")
    }
}

function test1() {

}

const test2 = () => {

}

// const name1 = "Oguzhan";
// name1 = "Oguzhan Varli" // hata verir cunku const ile tanimlandigi icin sonradan degistirilemez
// console.log(name1);


let name1 = "Oguzhan";
name1 = "Oguzhan Varli" // hata verir cunku const ile tanimlandigi icin sonradan degistirilemez
console.log(name1);

{
    var team = "Galatasaray";
}

console.log(team);



if (name1 == "Oguzhan Varli") {
    console.log("Esit")
}
else {
    console.log("Esit Degil")
}

let number2 = 29
if (number2 === "29") {
    console.log("esitler")
}
else {
    console.log("esit degil")
}

let sampleNull = null;
if (sampleNull) {
    console.log("if'e dustum")
}
else {
    console.log("else'e dustum") // buraya dustu
}

let sampleUnd = undefined;
if (sampleUnd) {
    console.log("if'e dustum")
}
else {
    console.log("else'e dustum") // buraya dustu
}

// if kontorlunde null ve ya undefined ise else'e duser.

let number3 = 1881
if (number3) {
    console.log("if'e dustu") // ife dustu cunku number3'un karsiligi javascriptsel bir ifade. yani karsiliginda bir deger var.
}
else {
    console.log("else'e dustu")
}

let hobbies = []
if (hobbies) {
    console.log("if'e dustu")
    // ife dustu cunku number3'un karsiligi javascriptsel bir ifade. yani karsiliginda bir deger var. array ici bos olsa bile sonucta bir array var
}
else {
    console.log("else'e dustu")
}

let test3
if (test3) {
    console.log("if'e dustu")
}
else {
    console.log("else'e dustu")
    // test3 undefined oldugu icin else dustu
}

console.log(test3) // undefined geldi

let date1 = new Date()
console.log(date1.getDay())


let str1 = "Oguzhan"
let str2 = "Oguzhan"

if (str1 == str2) {
    console.log("esitler") // buraya dustu
}
else {
    console.log("esit degiller")
}
// array  & obj

let arr1 = [1, 2, 3]
let arr2 = [1, 2, 3]

if (arr1 == arr2) {
    console.log("esitler")
}
else {
    console.log("esit degiller") // buraya dustu.
}


let obj1 = {
    one: 1
}
let obj2 = {
    one: 1
}

if (arr1 == arr2) {
    console.log("esitler")
}
else {
    console.log("esit degiller") // buraya dustu.
}

// neden obje ve array esit degil cikti?
// primative tipler rame yaziliyor, ve direk karsilastirma yapilinca yapiyor
// acnak obje ve array gibi tipler Immutable oldugu icin yani referans deger oldugu icin, icerikleri birebir ayni bile olsa pointer'lari bellekte farkli noktalari isaret eder bu yuzden esitlik sorgusu false doner.