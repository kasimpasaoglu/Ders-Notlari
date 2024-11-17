# CSS

- CSS, HTML elementlerine still ozellikleri girmek (reng, boyut, konum) icin kullanilan bir dildir.
- CSS dogrudan `style` attribute olarak HTML elementine **Inline CSS** olarak yazilabilecegi gibi, class, id ve ya elementin dogrudan kendisini gostererek verilebilir.
- CSS kodlari ayri bir dosyada yazilabilecegi gibi HTML icinde `<head>` kisminda `<style>` icine yazilabilir

```CSS
p {
    background-color: red;
}
```

> HTML icindeki butun `p` etiketli elementlere arkaplan kirmizi olacak ozelligini ekledik

- HTML etiketine `id="ilkH"` attribute eklenerek asagidaki CSS ozelligi verilebilir. CSS te ID gostermek icin `#` isareti kullanilir

```CSS
#ilkH {
    background-color: yellowgreen;
}

```

- HTML etiketine `class="ulstyle"` gibi bir attribute verilerek asagidaki gibi CSS ozelligi verilebilir. CSS te CLASS gostermek icin `.` isareti kullanilir

```CSS
.ulstyle {
    background-color: aquamarine;
}
```

- Sadece div elementi olan ve classlari ortadiv olanlari etkileyecek

```CSS
div.ortadiv {
    background-color: red;
    width: 100px;
    height: 100px;
}
```

- Grup selector -> birden fazla element, class ve ya id ye ayni css ozellikleri verilebilir

```CSS
h1,
h2,
h5 {
    font-family: Verdana, Geneva, Tahoma, sans-serif;
    font-size: 40px;
    background-color: coral;
    color: chartreuse;
}
```

- main classi olan div elementi icindeki p lere ozellik verme

```CSS
div.main p {
    color: blanchedalmond;
    font-size: 60px;
    text-align: center;
}
```

- ul icinde classi liste olan li

```CSS
ul li.liste {
    border: 2px solid red;
}
```

- Tablo icindeki td nin icindeki tr icindeki ul'un icindeki li'nin icindeki a

```CSS
table tr td ul li a {
    text-decoration: none;
    color: yellow;
    background: black;
    border-radius: 10px;
}
```

- :warning: Dogrudan example isimli ul icindeki li icindeki a icin bu sekilde gosteririz. Bu sekilde gosterince direkt bu yeri arar

```CSS
ul.example>li>a {
    background-color: red;
    font-size: 20;
}
```

- `:hover` bir elementin mause uzerine getirldiginde almasini istedigimiz ozellik icin

```CSS
.image:hover {
    opacity: 0.2;
    border: 10px solid red;
    border-radius: 20px;
}
```

> :bulb: `:hover` gibi secicilere `pseudo selector` denir

- dome icindeki sadece ilk p elementinin belli bir kisimdaki alanindan oncesi ve sonrasi

```CSS
#p_first::before {
    background-color: red;
    content: 'Ilk eleman';
}
#p_first::after {
    background-color: yellow;
    content: 'Son eleman';
}
```

- verilen elementin icinde yazan yazinin sadece ilk satiri stillendirmek icin

```CSS
.letter::first-line {
    background-color: purple;
}
```

- Metnin sadece ilk karakterini sekillendirmek icin

```CSS
.paragraf::first-letter {
    font-size: 50px;
    font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
    color: deeppink;
}
```

## Attribute Selector

HTML elementinin attributelarina gore bir element yakalayabiliriz. Ornegin img ler arasinda alt attribute'u Random Image olan elementi yakalayalim

```CSS
img[alt='Random Image'] {
    border: 5px solid blue;
}
```

- Sadece `href` kismi `http` ile baslayan a linkerine ozellik ekliyoruz

```CSS
a[href^=http] {
    border: 3px solid deeppink;
}
```

- sadece `href` attribute u `net` ile biten a linklere ozellik ekleme

```CSS
a[href$=net] {
    border: 3px solid black;
}
```

- :warning: !important` bir ozelligin baska bir yerden degistirilmesini engeller

```CSS
#importantDiv {
    background-color: yellow;
    border: 3px solid black;
    width: 200px;
    height: 200px;
}

#importantDiv {
    background-color: deeppink !important;
}
```

> :warning: `importantDiv` id li elemente aslinda arkaplan sari olmasi ozelligi verilmisti, ancak baska bir noktada deeppink rengini `!important` ile verince artik bu id'ye sahip element arkaplani deeppink rengine olacaktir
