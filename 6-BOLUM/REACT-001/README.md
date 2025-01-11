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

- node_modules -> uygulamanin calismasi icin gerekli paketleri icerir.
- public -> Istemciye gonderilecek butun yapilar bu klasorde olur
  - Aslinda react calisma yapisi olarak tek sayfa uygulamadir (SPA).
  - Public klasoru icindeki index.html dosyasi aslinda projedeki tek html sayfasidir.
  - React bu index sayfasini dinamik olarak degistirirek uygulamayi olusturur.
  - Bu index icinde id'si `root` olan bir div var buna dikkat
- src-> Kaynak kodlarin oldugu klasordur
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
  - Index.js icinde `import {App} from './App';`  seklinde cagrilirsa default yazilmayabilir.

```JS
export function App() {

  // Bu bir jsx yapisidir.

  return <h1>Oguzhan hocayla ilk ders</h1>
}
```

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
let name1 = "Oguzhan";
name1 = "Oguzhan Varli"
console.log(name1);
// cikti Oguzhan Varli 
```

- Neden `let` ve `const` var, ayri ayri. Cunku let ile bellekte tutuldug yer ayni degil. const ile kalici bir yerde tutulurken let gecici bir bolgede tutuluyor.
- Bu yuzden `const` degistirilemez, `let` degistirilebilir
- `const` icinde bulundugu scope'ta calisir

```JS
{
    const team = "Galatasaray";
}

console.log(team); // hata verir
```

- `let` 'te ayni sekilde hata verir ancak

```JS
{
    var team = "Galatasaray";
}

console.log(team) // galatasaray gelir
```

- Yani `var` ile tanimlanan degisken globale yazilir.
- Bu bir guvenlik acigi oldugu icin artik kullanilmiyor.

---

-

```JS
let number2 = 29
if (number2 === "29") {
    console.log("esitler")
}
else {
    console.log("esit degil")
}
```

- number2 degeri sayi tipinde 29 olarak yazildi, sorgu yapilirken 3 tane esitlik oldugu icin 29 sayisal degerinin karilastirgini ifadenin de sayisal olmasi gerekir.
- Bu ornekte `"29"` olarak sorgulandigi icin eit degil cikacak.

---

```JS
let sampleNull = null;
if (sampleNull) {
    console.log("if'e dustum")
}
else {
    console.log("else'e dustum")
}
```
