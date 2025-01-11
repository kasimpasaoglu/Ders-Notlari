# REACT NEDIR

- React bir on yuz olusturma teknolojisidir.
- MVC'nin aksine React bir web uygulamanin sadece front end kismini olusturur.
- Dinamik siteler icin Database'e erisimi backhand'de farkli bir uygulama(API) ile yapip, fornt-end ve backh-and ikiye ayrilir.
- Front-end tarafini yazabilecegimiz teknolojilerden bazilari (React.js, Angular.js, Vue.js)
- Back-end tarafini yazabilecegimiz teknolojiler (.Net, Node, Java, Python)
- Neden bu ayirim olmaya basladi? (MOBIL)
  - Backhand ayrica yazildiktan sonra, ayni API'yi kullanan ister mobil ister masaustu uygulama gelistirilebilir.

- React Meta(Facebook) tarafindan yazilmis bir JavaScript kutuphanesidir.

---

## React Projesi Olusturma

- [React Resmi Sitesi](https://react.dev/) dokumanlarini kullanacagiz
- [React olusturma paketi](https://create-react-app.dev/docs/getting-started/)

- `npx create-react-app first` komutuyla projeyi olusturduk
- npm start ile calistirdik

## Klasor Yapisi

- **node_modules** -> uygulamanin calismasi icin gerekli paketleri icerir. Buraya dokunmayacagiz
- **public** -> Istemciye gonderilecek butun yapilar bu klasorde olur
  - Aslinda react calisma yapisi olarak tek sayfa uygulamadir (SPA).
  - Public klasoru icindeki index.html dosyasi aslinda projedeki tek html sayfasidir.
  - React bu index sayfasini dinamik olarak degistirirek uygulamayi olusturur.
  - Bu index icinde id'si `root` olan bir div var buna dikkat
- **src**-> Kaynak kodlarin oldugu klasordur
  - React component bazli calisacak sekilde tasarlanmis bir teknoloji oldugu icin,  uygulamayi olusturan bilesenler bu klasor icinde toplanir
  - `Index.js` projenin baslangic noktasidir. Bir react projesi her zaman burdan calismaya baslar.
    - `App.js` icindeki yapi burdan cagrilmis
    - App.js burdaki ikinci adimimiz. Sayfada su anda render edilen her sey App.js icinde yazilmiz. Bir bilesen olarak ayri tutulmus. Index.js icinde cagrilmis
- `.gitignore` projeyi herhangi bir buluta atarken (guthub gibi) projede oraya gonderilmeisni istemedigimiz belli basli seyler yazilir. Ornegin (node_modules)
  - `node_modules` klasoru icindeki bilesenler cloud'a yuklenmesine gerk yoktur, projeyi calistirmak isteyen kisiler `npm install` yazdigi zaman node_modules klasoru gelir (`npm i`)
  - Sadece veri tasarrufu icin degil guvenlik icinde bazi dosyalarin buluta yuklenmemesini saglariz. Ornegin veritabanina baglanmak icin kullandigimiz connection stringi buluta gondermemek icin
- `package.json` -> projenin kunyesidir. Projede bulunan paketler vs burda tutulur.

---

## Component Ornegi

- Reactin calisma mantigi function componentlerdir. App.js icini tamamen silip kendi componentimizi olusturalim

```JS
function App() {

  // Bu bir jsx yapisidir.

  return <h1>Oguzhan hocayla ilk ders</h1>
}

export default App(); // bu componenti public hale cevirdik. artik index.js te bu componente erisebilirim.
```

- `dafault` =>  bir js dosyasinda birden fazla fonskiyon olabilir. Eger default kullanilimiyorsa cagrildigi yerde `{}` ile cagirmak gerekir
  - Default yazilmazsa `import {App} from './App';`  seklinde cagrilmalidir.
  - default yazilirsa `import App from './App';` seklinde cagrilmalidir.
  - default yazilirsa farkli bir isimlendirme verilebilir mesela `import Test from './App';`
    - bu durumda bu componenti kullanirken `<App />` yerine `<Test />` seklinde cagrilabilir.
    - Yani metodun adi App bile olsa farkli isim vererek cagirmis oluyoruz
- :blub: default keywordu metodu farkli isimle cagirabilmemizi saglar.

```JS
export function App() {

  // Bu bir jsx yapisidir.

  return <h1>Oguzhan hocayla ilk ders</h1>
}
```

> Yani fonskiyonun basina export eklemek = bir clasi public yapmak

- Bu componenti index.js icinde cagirabilmek icin. ust satira `import { App } from './App';` satirini ekliyoruz

---

- Birden fazla HTML elementi donulecekse `return` ifadesinden sonra `()` parantez acip yazmak lazim

```JS
export function App() {

  // Bu bir jsx yapisidir.

  return (
    <div>
      <h1>Oguzhan hocayla ilk ders</h1>
      <h2>Kac Saat Islenecek</h2>
    </div>
  )
}
```

- Burda yine iki elementi tek bir div icine almamiz gerekti.
- React bir componenti her zaman bir kapsayici icine sarmalaman gerekir. Bu ornekte `<div>` ile sarmalladik
- Div kullanmak istemiyorsak `jsx fragment` kullanabiliriz

```JS
export function App() {

  // Bu bir jsx yapisidir.

  return (
    <>
      <h1>Oguzhan hocayla ilk ders</h1>
      <h2>Kac Saat Islenecek</h2>
    </>
  )
}
```

---

## JavaScript Temel Bilgiler

- ES7+ React/Redux/React-Native snippets eklentisini kullanabiliriz javascrip icin
- JavaScript'te degisken tanimlamak icin `const` ve ya `let` kullanilir.

```JS
const string1 = "Merhaba";
const number1 = 23;
const boolean1 = true;
let array1 = [12, 22, "asd", true, [2, "asdf", false]]
```

- array disinda bir obje tanimlanabilir. Daha once gordugumuz json yapisi alsinda. Key ve value degerleri alir

```JS
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
```

- Key degeri gelisiguzel olusturulabilir, ancak value degeri gecerli primative tiplerden biri olmalidir.
- Son fieldta fonskiyon ekledik !
  - JS te fonksion tanimlama iki sekilde yapilir.

```JS
function test1() {

}
// ve ya
const test2 = () => {

}
```

- her ikisi de fonskiyondur.
- ikinci tanimlama ECMA Script ile gelen bir ozelliktir (ES).
- Bu sekildeki gosterime `Arrow Function` denir.
- Ozellikle ornekte oldugu gibi obje icinde fonskiyon tanimlanmasi icin getirilmis bir ozelliktir.
  - JavaScriptin gelen versionlarina ES denir
  - En populeri ES6'dir

- `const` ile tanimlanan deger degistirilemez, `let` ile tanimlanan deger sonradan degistirilebilir

```JS
let name1 = "Oguzhan"
name1 = "Oguzhan Varli" // degisim islemi
console.log(name1)
// cikti Oguzhan Varli 
```

- Neden `let` ve `const` var, ayri ayri. Cunku let ile bellekte tutuldug yer ayni degil. const ile kalici bir yerde tutulurken let gecici bir bolgede tutuluyor.
- Bu yuzden `const` degistirilemez, `let` degistirilebilir
- :bulb: `const` icinde bulundugu scope'ta calisir

```JS
{
    const team = "Galatasaray";
}

console.log(team); // hata verir
```

- `let` 'te ayni sekilde hata verir, ancak `var` keywordu ile tanimlanirsa hata vermez

```JS
{
    var team = "Galatasaray";
}

console.log(team) // galatasaray gelir
```

- Yani `var` ile tanimlanan degisken globale yazilir.
- :warning: Bu bir guvenlik acigi oldugu icin artik kullanilmiyor.

---

### `===` vs `==` farki

- Sorgulamalarda `===` ile `==` arasinda fark vardir.

```JS
let number2 = 29
if (number2 === "29") {
    console.log("esitler")
}
else {
    console.log("esit degil") // buraya dustu
}
```

- number2 degeri sayi tipinde 29 olarak yazildi, sorgu yapilirken 3 tane esitlik oldugu icin 29 sayisal degerinin karilastirgini ifadenin de sayisal olmasi gerekir.
- Yani `===` ile sorgu yapildigi zaman hem degerin hem de tipin ayni olmasi gerekir.
- Her ikisi de 29 olsa bile if sorgusu icinde string olarak `"29"` yazildigi icin else bloguna gidiyor

---

### Null ve undefined degerler

```JS
let sampleNull = null;
if (sampleNull) {
    console.log("if'e dustum")
}
else {
    console.log("else'e dustum")
}
```

```JS
let sampleUnd = undefined;
if (sampleUnd) {
    console.log("if'e dustum")
}
else {
    console.log("else'e dustum") // buraya dustu
}
```

- Her iki ornektede kullanilan degiskenler javascript'sel bir ifade olmadigi icin false dondu. yani aslinda if'in icine bu sekilde bir degisken gonderince, degiskenin icinde bir deger olup olmadigina bakarak true false kararirini veriyor.

```JS
let number3 = 1881
if (number3) {
    console.log("if'e dustu")  
}
else {
    console.log("else'e dustu")
}
```

- if'e dustu cunku number3'un karsiligi javascriptsel bir ifade. yani karsiliginda bir deger var.

- Peki icinde herhangi bir deger olmayan bir array gonderirsek ne olacak?

```JS
let hobbies = []
if (hobbies) {
    console.log("if'e dustu")
}
else {
    console.log("else'e dustu")
}
```

- ife dustu cunku hobbies'in karsiligi javascriptsel bir ifade. yani karsiliginda bir deger var.
- Array ici bos olsa bile sonucta bir array var. hic birsey olmamasindan iyidir :)

```JS
let test3
if (test3) {
    console.log("if'e dustu")
}
else {
    console.log("else'e dustu")
    // test3 undefined oldugu icin else dustu
}
```

- bir degisken tanimlanip herhangi bir deger atanmasi yapilmazsa undefined olarak kalir

### Arraylerin bellekteki davranisi

```JS
let arr1 = [1, 2, 3]
let arr2 = [1, 2, 3]

if (arr1 == arr2) {
    console.log("esitler")
}
else {
    console.log("esit degiller")
}
```

- Else blogu calisti cunku;
  - Primative tipler dogrudan rame yaziliyor, ve direk karsilastirma yapilabiliyor.
  - Ancak **obje** ve **array** gibi tipler **Immutable** oldugu icin yani **referans** deger oldugu icin, icerikleri birebir ayni bile olsa **pointer'lari bellekte farkli noktalari isaret eder** bu yuzden esitlik sorgusu false doner.
- Ayni sey obje icin de gecerlidir

```JS
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
```
