# HTML

HTML 2 Parcadan Olusur

1. Head
    - Sayfa ile ilgili meta bilgileri; aciklamalar, arama motorlari icin keywordler, css ve ya javasctrip kodlari yazilabilir
2. Body
    - Body bolumun icinde sayfanin tasarimini olusturacak ogeler yazilir

HTML de elementler `<tag> </tag>` ler icinde yazilir.

## Bazi HTML Elementleri

- Basliklar, paragraflar, yazi bicimleri (kalin-italik)

```HTML
    <h1>Baslik-1</h1>
    <h2>Baslik-2</h2>
    <h3>Baslik-3</h3>
    <h4>Baslik-4</h4>
    <h5>Baslik-5</h5>
    <h6>Baslik-6</h6>
    <p>Paragraf</p>
    <b>Kalin yazi tipi</b>
    <i>Italik yazi tipi</i>
    <strong>farkli tarayicilar icin kalin yazi</strong>
```

- Listeler

1. Sirali Olmayan Listeler (Unordered List)

```HTML
    <ul>
        <li>Madde</li>
        <li>Madde</li>
        <li>Madde</li>
        <li>Madde</li>
    </ul>
```

2. Sirali Listeler (Ordered List)

```HTML
    <ol>
        <li>Madde</li>
        <li>Madde</li>
        <li>Madde</li>
        <li>Madde</li>
    </ol>
```

- Linkler

```HTML
    <a href="https://www.google.com" target="_blank">LINKE TIKLA</a>
```

:bulb: HTML Elementleri Attirbute alabilirler. (href, target gibi)

- Tablolar

```HTML
<table border="2px">
    <tr>
        <td>1. Satir 1.sutun</td>
        <td>1. Satir 2.sutun</td>
    </tr>
    <tr>
        <td>2. Satir 1.sutun</td>
        <td>
            <!-- ic ice tablo olusturabiliriz -->
            <table border="2px">
                <tr>
                    <td>1</td>
                    <td>2</td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td>3. Satir tek sutun</td>
    </tr>
</table>
```

:bulb: bazi CSS (still) ozellikleri HTML elementine dogrudan verilebilir (border="2px" gibi)

- Button, Textbox, Dosya Yukleme, Checkbox

>Button

```HTML
<input type="button" value="Ben bir buttonum" name="adbutton">
<!-- ve ya  -->
<button type="button">Ben Bir Buttonum</button>
```

>Textbox

```HTML
<input type="text" placeholder="Buraya yazi yazilabilir">
```

>Password Input

```HTML
<input type="password" placeholder="sifrenizi girin">
```

>Checkbox

```HTML
<input type="checkbox" value="checkbox">

<!-- ve ya -->

<input type="radio">
```

- :warning: Radio ile checkbox birbirine benzerdir. Ikisi arasindaki fark; radio grubundan  sadece bir tane secilmesine izin verilirken, checkbox'ta kullanici birden fazla checkboxu isaretleyebilir
- :warning: Inputlarda `type` attirbute ile farkli secenekler mevcut

> Resim

```HTML
<img src="https://picsum.photos/200/300" alt="resim">
```
