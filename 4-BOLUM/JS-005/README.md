# JavaScript

- Bir script dilidir.
- Derleyicisi tarayicidir
- Sayfa icerisinde client-side yani istemci tarafinda yapilmasi gereken islemler javascript ile yapilir
  - Client-side; yapilan islemde sunucuya gidip gelinmiyor. Mevcut sayfa uzerinde istemci tarafinda islem yapiliyor.
  - Server-side; yapilacak islem sunucu uzerinden calistirmayi gerektiriyorsa server-side'dir. Javascript dilini server-side kullanmak icin `node.js` kullanilir.

- HTML dosyasi icinde `<script>` etiketi icine de yazilabilecegi gibi external bir dosyada da yazilabilir

- `var` keywordu degisken tanimlamak icin kullanilir
- JS'te degisken tanimlama yapilirken tip yazilmaz.

```js
var ilkDegisken = 10;
```

```js
    var ilkDegisken = 10;
    var ikinciDegisken = 20;
    var toplam = ilkDegisken + ikinciDegisken;

    console.log(toplam)
```

> JS ile mantiksal ve aritmetik operatorler kullanilabilir

- `string`, `number`, `boolean`, `null`, `undefined` gibi temel degisken tipleri vardir.
