#region carpim tablosu olusturma
/*
var inputStart = 0;
var inputEnd = 0;

do
{
    Console.WriteLine("Hangi sayidan baslasin?");
    inputStart = int.Parse(Console.ReadLine().Trim());

    Console.WriteLine("Hangi sayida bitsin?");
    inputEnd = int.Parse(Console.ReadLine().Trim());
    if (inputStart > inputEnd || inputEnd <= 0 || inputStart <= 0)
    {
        Console.WriteLine("Lutfen gecerli bir aralik giriniz");
    }
} while (inputStart > inputEnd || inputEnd <= 0 || inputStart <= 0);


for (int i = inputStart; i <= inputEnd; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine("{0,2} x {1,2} = {2,3}", i, j, i * j);
    }
    Console.WriteLine("---------------");
}
*/
#endregion

#region ucgen
/*
var height = 0;
do
{
    Console.WriteLine("Yukseklik Giriniz");
    height = int.Parse(Console.ReadLine().Trim());
    if (height <= 0 || height > 9)
    {
        Console.WriteLine("0 ile 9 arasinda bir deger giriniz \n");
    }
} while (height <= 0 || height > 9);
// 0 ile 9 arasi deger gelene kadar tekrar edecek

// piramit ters mi isteniyor sorgusu
var revert = ' ';
do
{
    Console.WriteLine("Piramit ters mi olussun? (e/h)");
    revert = char.Parse(Console.ReadLine().Trim().ToLower());
    if (revert != 'e' && revert != 'h')
    {
        Console.WriteLine("Lutfen gecerli bir secim yapiniz \n");
    }

} while (revert != 'e' && revert != 'h');

// ters pramit istendiyse...
if (revert == 'e')
{
    for (int i = height; i > 0; i--)  // girilen degerden baslayip her dongude 1 eksilterek 0 olana kadar devam et
    {
        // girilen degerden basla, i degerine kadar her defasinda 1 eksilterek.
        // yani height 5 verildiyse, i = 5 iken, j= 5 olacak, bu ilk satir, piramit ters oldugu icin bu satirda bosluk gerekmediginden, ilk satirda calismayacak
        // ikinci satira gecince i=4 olacak, j=5 ten baslayacak, 4 olana kadar 1 kez donecek (yani 1 kez bosluk birakacak)
        // ucuncu satira gecince i=3 olacak, j=5 ten 3 e gelene kadar 2 kez donecek.
        // bu sekilde devam edecek
        for (int j = height; j > i; j--)
        {
            // bosluklari olusturacak kod blogu
            Console.Write(" ");
        }

        // height 5 geldiyse , i = 5 ilk adiminda, k = 1 den baslayip 5*2=10'a kadar doncek, 
        // bir sonraki adimda i=4 gelince k=1 den baslayip 4*2=8 e kadar donecek. Boylece her satirda 2 karakter daha az koyacak, soldan 1 karakter sagdan 1 karakter cikacak gibi dusunebiliriz
        for (int k = 1; k < i * 2; k++)
        {
            // sutunlari olusturacak kod blogu
            Console.Write(i);
        }
        Console.WriteLine(); // en disardaki dongu sadece satirlari olusturacak.
    }
}
else // ters piramit istenmiyorsa bu kod blogu calisacak. 
// burdaki fark, girilen degerden baslamayip, 0 dan baslaniyor donguye,
// girilen degerde bitiyor. ilk satirda 1 karakter, 2 satirda 3, sonra 5 ve bu sekilde gidiyor.
{
    for (int i = 0; i < height + 1; i++)
    {
        for (int j = height; j > i; j--)
        {
            Console.Write(" ");
        }
        for (int k = 1; k < i * 2; k++)
        {
            Console.Write(i);
        }
        Console.WriteLine();
    }
}
*/
#endregion

#region ortalama hesaplama
/*
var numberCount = 0;
do
{
    Console.WriteLine("Kac adet sayi gireceksiniz ?");
    numberCount = int.Parse(Console.ReadLine().Trim());
    if (numberCount <= 0)
    {
        Console.WriteLine("Pozitif bir deger girmelisiniz...");
    }
} while (numberCount <= 0);

var total = 0;

for (int i = 0; i < numberCount; i++)
{
    Console.WriteLine("{0}. Sayiyi Girin", i + 1);
    total += int.Parse(Console.ReadLine().Trim());
}

var avarage = Math.Round((double)total / numberCount, 2);
Console.WriteLine("Girdiginiz sayilarin ortalamasi => {0}", avarage);
*/
#endregion

#region faktoriyel hesaplama
Console.WriteLine("Faktoriyeli Alinacak Sayiyi Giriniz");
var input = int.Parse(Console.ReadLine().Trim());
var result = 1;
for (var i = 1; i <= input; i++)
{
    if (i == input)
    {
        Console.Write(i);
    }
    else
    {
        Console.Write(i + " * ");
    }
    result *= i;
}
Console.Write("= {0}", result);
#endregion

