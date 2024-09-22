## `break`
Belirli bir sart saglandiginda donguden cikmak icin kullanilir

```C#
    for (int i = 1; i < 100; i++)
    {
        Console.WriteLine(i);
        if (i % 3 == 0)
        {
            Console.WriteLine("{0} sayisi 3'e tam bolundu", i);
            break;
        }
    }
```
>  Break ifadesi, çalıştırıldığında, eğer bir döngü var ise, bu döngüden çıkılır.

## `continue`
Belirli bir sart saglandiginda dongunun o noktada sonlanip bir sonraki donguye devam etmesini saglar

```C#
for (int i = 0; i < 100; i++)
{
    if (i == 10)
    {
        continue;
    }
    Console.WriteLine(i);
}
```
> Continue ifadesi, çalıştığı zaman, döngü continue ifadesini gördüğü anda, alt satırları çalıştırmaya devam etmez, direk i'nin değerini bir artırır, sonrasında dönmeye devam eder.