# Diziler (Array)

Birden fazla ayni tipte veriyi tasiyabilen yapilara dizi(Array) denir
"Ekrandan 1000 adet not degeri aliniz" denildiginde normalde 1000 tane degisken tanimlayip her degeri bir degiskene girmek zorunda kalirdik.
Bir noktadan sonra bir suru degisken tanimlamak imkansiz hale gelir.
> 30 tane yumurtayi tasimak icin nasil yumurta kolisine ihtiyacimiz varsa, 100 tane int degerini tasimak icin de array'e ihtiyacimiz var.


:bulb: *syntax* => `int[] intDizisi = new int[1000]` => 1000 adet int degeri tasiyacak, adi intDizisi olan bir array tanimladik.

## Kurallar
1. Dizi tanimlanirken hangi tipi tasiyacagi belirtilmelidir. Dizi sadece tanimlandigi tipte veri icerebilir.
2. Dizi tanimlanirken kac adet veri tasiyacagi belirtilmelidir.
3. Dizilerin baslangic degerleri, onlarin kapasitesini belirler. Kapasite asimi yapilmaya calisilirsa runtime hatasi alirsiniz.
4. Dizi olusturulduktan sonra icine bir deger atanmazsa, dizi int dizisi ise, elemanlarin hepsi baslangicta 0 degeri alir. 
5. Dizilerde index numaralari 0'dan baslar.
6. var keyword'u ile dizi tanimlanabilir `var dizi = new dizi[10]`

## Dizinin Icindeki Elemana Ulasmak

```C#
    int[] intArray = new int[3];

    Console.WriteLine(intArray[1])// index1 e ulastik. Deger atamadigimiz icin 0 yazdi    
```
>koseli parantez icinde index numarasini vererek dizi icindeki elemana ulasilir.

## Dizi Icerisine Eleman Atamak

```C#
    int[] intArray = new int[3];
    intArray[1]=80; // 1. index elemanina 80 degeri verildi.
    Console.WriteLine(intArray[1]) // 80 degeri ekrana gelir  
```