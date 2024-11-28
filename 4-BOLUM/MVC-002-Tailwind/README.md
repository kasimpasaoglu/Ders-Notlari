# MVC -TAILWIND ve LIVE WATCH OZELLIKLERI (Ders Disi)

- node ve npm yuklu olmali kotrol et

```bash
node -v
npm -v
```

- Proje root'ta `package.json` olusturmak icin

```bash
npm init -y
```

- Tailwind ve PostCSS projeye ekle

```bash
npm install tailwindcss postcss autoprefixer
```

- Proje root'ta Tailwind config dosyasi olustur

```bash
npx tailwindcss init
```

---

## Konfigrasyon

- `tailwind.config.js` dosyasinda tailwindin hangi dosyalarda kullanilacagini belirt

```js
module.exports = {
  content: [
    './Views/**/*.cshtml', // Razor View dosyalarınız
    './wwwroot/js/**/*.js' // Statik JavaScript dosyalarınız
  ],
  theme: {
    extend: {},
  },
  plugins: [],
};

```

> Bu, tailwindin views klasorundeki .cshtml dosyalarini ve wwwrot klasorundeki statik dosyalari izlemesini saglar

- `wwwroot/css/` dizininde bir `input.css` dosyasi olustur

>wwwroot/css/input.css:

```bash
@tailwind base;
@tailwind components;
@tailwind utilities;

```

- Derlenmis bir css dosyasi (`output.css`) olusmasi icin asagidaki komutu calistir.

```bash

npx tailwindcss -i ./wwwroot/css/input.css -o ./wwwroot/css/output.css --watch
```

> `wwwroot/css/` dizininde bir output.css diye dosya gelmis olmali!

- `Views/Shared/_Layout.cshtml` dosyasinda head kisminda asagidaki satiri ekle

```HTML
    <link rel="stylesheet" href="~/css/output.css" asp-append-version="true">
```

- Bir deneme yap, sorun yoksa bir sonraki adima gec

- `npx tailwindcss -i ./wwwroot/css/input.css -o ./wwwroot/css/output.css --watch` komutunu yazdigin terminali durdur (`CTRL+C`)

- Root'daki `package.json` dosyasini ac. Scripts kismina asagidaki gibi `"dev"` scriptini ekle

```json
{
  "name": "mvc-002-tailwind",
  "version": "1.0.0",
  "description": "",
  "main": "index.js",
  "scripts": {
    "test": "echo \"Error: no test specified\" && exit 1",
    "dev": "tailwindcss -i ./wwwroot/css/input.css -o ./wwwroot/css/output.css --watch"
  },
  "keywords": [],
  "author": "",
  "license": "ISC",
  "dependencies": {
    "autoprefixer": "^10.4.20",
    "postcss": "^8.4.49",
    "tailwindcss": "^3.4.15"
  }
}
```

- artik tailwindin anlik olarak dosyalarini izlemesi ve degisiklikleri yapmasi icin terminale `npm run dev` yazman yeterli

---

## MVC' de anlik izleme

- Yeni bir terminalde `dotnet watch run` komutunu gir. Hot reload acik bir sekilde sayfayi tarayicida acar ve kodta yaptigin degisiklikler anik olarak tarayicida izlenebilir

- Bazen Hot reload onbellekleme sorunlari yuzunden calismayabilir, ozellikle tailwind classlari ekleyip cikarirken.

- Boyle durumlarda hot reloadi kapatarak izleme yapmak icin `dotnet watch run --no-hot-reload` komutu girilebilir.

- Ancak burda sayfaha her degisiklik yapilip kaydedildiginde, yeniden derleme yapar, daha uzun surebilir sayfanin yenilenmesi.

- Bir baska yontem olarak [BrowserSynch](https://browsersync.io/) kullanilabilir.

- Yeni bir middleware yontemi mevcut [Westwint.AspnetCore.LiveReload](https://github.com/RickStrahl/Westwind.AspnetCore.LiveReload)
