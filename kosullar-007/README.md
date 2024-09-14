# Kosullar (Karar Mekanizmalari)

- Bir yazilimin en onemli bilesenidir
- Derleyiciye belli degerlere gore belli kod bloklarini calistirmasini soyleme yontemidir. 
- Calisma Mantigi: 
- Elimizde bir *kosul* var.
-- Kosul true ise bu kod calissin
-- Degilse bu kod calissin
C# 'ta iki farkli kosul yontemi var
1. `if - else if - else` yontemi 
2. `Switch Case` yontemi

## `if`
```C#
    if(kosul)
    {
        kosul true ise bu kod blogu(scope) calisacak
    }
```
* not, kosul her zaman mantiksal operatorden gelen bir deger almalidir (true/false). Yani if parantezi ya direk true false bir deger kabul eder, ya da sonucu true/false donecek bir mantiksal operator islemi alir.

```C#
Console.WriteLine("Lutfen Bir Sayi Giriniz");
int intDegisken = int.Parse(Console.ReadLine());
// cift mi?
    if (intDegisken % 2 == 0)
    {
        Console.WriteLine("Girdiginiz sayi cift");
    }
    // cift degil mi?
    if (intDegisken % 2 != 0)
    {
        Console.WriteLine("Girdiginiz sayi tek");
    }
```

## `if-else`
* yukaridaki ornek her ne kadar dogru sonucu veriyor olsa da derleyici iki adet sorgu yapmis oluyor. Oysaki zaten girdigimiz kosul cift degilse zaten tektir. Yani ikinci if sorgusuna gerek yok. Bu tarz sadece iki durumu kontrol ediyorsak `else` kullaniyoruz. Boylece iki sorgu yapmiyoruz. \
Yani if kosulunu bir kere kontrol ediyoruz, dogru ise if blogu calisacak, degilse else blogu calisacak. \
Eger if blogu calisirsa `else` blogunu asla kontrol etmez

```C#
    Console.WriteLine("Lutfen Bir Sayi Giriniz");
    int intDegisken = int.Parse(Console.ReadLine());

    // cift mi kosulu dogru ise bu blok calisir
    if (intDegisken % 2 == 0)
    {
        Console.WriteLine("Girdiginiz sayi cift");
    }

    // degilse ...
    else
    {
        Console.WriteLine("Girdiginiz sayi tek");
    }
```

*derste verilen odev1
```C#
    Console.WriteLine("bir karakter girin");
    int input = Convert.ToInt32(char.Parse(Console.ReadLine()));

    if (input > 64 && input < 91)
    {
        Console.WriteLine("Girdiginiz Harf Buyuk");
    }
    else
    {
        Console.WriteLine("Girdiginiz harf kucuk");
    }
```
Bu ornekteki sorun su: Kullanicinin girecegi karakterin ASCII kodu 64, 91 araligi disinda hangi deger gelirse gelsin Ekrana `Girdiginiz Harf Kucuk` yazisi cikacak. Bu da aslinda tam olarak istedigimiz sey degil. Buna deginecegiz
* if ve else kosullarinda, eger bu bloklarin icinde tek satir kod girilecekse  paranteze alamamiza gerek yoktur
```C#
    Console.WriteLine("bir karakter girin");
    int input = Convert.ToInt32(char.Parse(Console.ReadLine()));

    if (input > 64 && input < 91)
        Console.WriteLine("Girdiginiz Harf Buyuk");
    
    else
        Console.WriteLine("Girdiginiz harf kucuk");
    
```
* if bloklari icine baska if bloklari ve else bloklari da yazabiliriz.

```C#
    Console.WriteLine("lutfen notunuzu giriniz");
    int note = int.Parse(Console.ReadLine());
    
    if (note < 50)
    {
        if (note < 25)
        {
            Console.WriteLine("Kaldi");
        }
        else
        {
            Console.WriteLine("Dusuk Ama Gecti");
        }
    }
    else
    {
        if (note < 75)
        {
            Console.WriteLine("Orta Seviyeli Gecti");
        }
        else
        {
            Console.WriteLine("Cok Iyi Seviyeli Gecti");
        }
    }
```
## else if
* If blogunda, kapidan kontrol if blogu sartina uyuyorsa if calisiyor uymuyorsa else calisiyor,
* Ancak birden fazla kosul varsa `else if` ile ayiririz. Bu sayede kosul uymuyorsa direk `else` gitmek yerine, `else if` e 
Ders:Hesap Makinesi Ornegine Bak
* if veya else if'ler else olmadan calisabilir, ancak else, bir if olmadan calismaz.
## Ternary Operatoru
* `if` yerine gecen ancak if yazmak istemedigimiz durumlarda, hizlica bir degeri kontrol etmek istedigimiz durumlarda kullaniyoruz. 
```C#
    bool isOkay = true
    string degisken = isOk ? "Dogru" : "Yanlis"
```
Aciklama : Eger isOk True gelirse ( ? ), degiskene "Dogru" degerini ata, Degilse ( : ) "Yanlis" degerini ata.
* Mantiksal degere gore calisir.
* Eger Mantiksal operator true degeri verirse, ? ifadesinden sonraki blok calisir
* Eger Mantiksal operator false degeri verirse : ifadesinden sonraki blok calisir
* yani if kismini ( ? ) temsil ediyor else kismini ( : ) temsil ediyor.
* else kismi olmadan( : ) kabul etmez.
* okunabilirligi dusuktur. 
```C#
    Console.WriteLine("Sayi Giriniz");
    int sayi1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Sayi Giriniz");
    int sayi2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Secim Giriniz");
    char secim = char.Parse(Console.ReadLine());

    int result = secim == '+' ? sayi1 + sayi2 : 0;
    Console.WriteLine(result);
```

# Switch Case
```C#
    Console.WriteLine("Ilk Sayiyi Giriniz");
    int sayi1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ikinci Sayiyi Giriniz");
    int sayi2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Islem Tipini Giriniz");
    char tip = char.Parse(Console.ReadLine());
    switch (tip) // tip verisini kontrol edecek
    {
        case '+': // tip + gelirse asagidaki blogu calistir
        Console.WriteLine(sayi1 + sayi2);
        break; // blok sonu

        case '-': // else if
        Console.WriteLine(sayi1 - sayi2);
        break;

        case '*': //else if
        Console.WriteLine(sayi1 * sayi2);
        break;

        case '/': // else if
        Console.WriteLine(sayi1 / sayi2);
        break;

        default: // else
        Console.WriteLine("Gecersiz Islem Tipi");
        break;
    }
```

* Normalde derleyici if, else-ife baktiginda kosullari tek tek gezip dogru olan kosula giriyordu, ancak bu yontemde dogrudan kosulun gerceklestigi adrese gidiyor. 
* Ic ice yapilabilir
```C#
// If ile ic ice yapmak
    case '/':
        // Bolen 0 olamaz Kontrolu
        if (sayi2 != 0)
        {
            Console.WriteLine(sayi1 / sayi2);
        }
        // sayi sifira esit degilse yukardaki blok calisacak, degilse asagidaki else blogu calisacak
        else
        {
        Console.WriteLine("Bolen Sifir Olamaz")
        }
        break;
```
```C#
    // ic ice case
    case '/':
        switch (sayi2)
        {
            case 0:
                Console.WriteLine("Bolen Sifir Olamaz");
            break;
            default:
                Console.WriteLine(sayi1 / sayi2);
            break;
        }
        break;
```
