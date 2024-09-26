#region giris
/*
int[] intArray = new int[3];

var intArray2 = new int[3];
*/
#endregion

#region ornek1
/*
int[] intArray = new int[10];

for (int i = 0; i < intArray.Length; i++)
{
    // bu dongu dizinin boyutu kadar donecektir
    // 0. indexten baslayip dizinin uzunlugu kadar doner
    Console.WriteLine(intArray[i]);
}
*/
#endregion

#region ogrenciden kac adet not girecegini sorun, sonra notlari bir dizi icine yaziniz. Giris bittikten sonra, notlari yazdiriniz
/*
Console.WriteLine("Kac Adet Not Girilecek?");

var notes = new int[int.Parse(Console.ReadLine().Trim())];

for (int i = 0; i < notes.Length; i++)
{
    Console.WriteLine("{0}. Notu Giriniz", i + 1);
    notes[i] = int.Parse(Console.ReadLine().Trim());
}
for (int i = 0; i < notes.Length; i++)
{
    Console.WriteLine($"{i + 1}. Not => {notes[i]}");
}
*/
#endregion

#region 10 adet eleman tasiyan dizi tanimla, dizinin tum elemanlarini 1 ile 100 arasi random sayi ile doldur
/*
var randomNumbers = new int[10];
var rnd = new Random();
for (int i = 0; i < randomNumbers.Length; i++)
{
    randomNumbers[i] = rnd.Next(1, 101);
    Console.WriteLine($"{i + 1}. Sayi => {randomNumbers[i]}");
}
*/
#endregion

#region 10 elemanli bir string dizi yapip dizinin her elemanina 10 karakterli random kelime yazdiriniz
/*
var stringArray = new string[10];

var rnd = new Random();

for (int i = 0; i < stringArray.Length; i++)
{

    for (int j = 0; j < 10; j++)
    {
        stringArray[i] += Convert.ToChar(rnd.Next('a', 'z'));
    }

}

for (int i = 0; i < stringArray.Length; i++)
{

    Console.WriteLine($"{i + 1}. Eleman => {stringArray[i]}");

}
*/
#endregion

#region sayisal loto. -> kullanicidan 6 adet 1 ile 49 arasinda sayi aliniz. 6 adet 1-49 arasi random sayi olusturunuz (diziye doldur). bu iki diziyi birbiri ile karsilastiriniz
/*
var rnd = new Random();
var luckyNumbers = new int[6];
var userInputs = new int[6];

for (var i = 0; i < luckyNumbers.Length; i++)
{
    luckyNumbers[i] = rnd.Next(1, 50);
    Console.WriteLine($"{i + 1}. Sayiyi Giriniz");
    userInputs[i] = int.Parse(Console.ReadLine().Trim());
}


var correctAnswersCount = 0;
for (var i = 0; i < userInputs.Length; i++)
{
    for (var j = 0; j < luckyNumbers.Length; j++)
    {
        if (userInputs[i] == luckyNumbers[j])
        {
            correctAnswersCount++;
            Console.WriteLine($"Eslesmle!\n {i + 1} nolu tahmin = {userInputs[i]} <=> {j + 1} nolu sonuc = {luckyNumbers[j]}");
        }
    }
}
Console.WriteLine("--------------------------");
Console.WriteLine($"Toplam Dogru Tahmin => {correctAnswersCount}");
*/
#endregion

#region sayi lotoda 6 adet sayi belirleyip devamli farkli random sayilar cekip, bu sayilar ile karsilastirin. 
// her bir for dongusu 1 haftayi temsil etsin, kac hafta ayni sayilara oynayip, 5 sayi tutuyor. 
// cikti => 500 hafta sonra 5 sayi dogru ve bilinen sayilar sunlar .... 
// her hafta bilet tutari 15 tl olarak hesaplayin, 5 rakam buldugumuz haftayi ve ne kadar para odedigimizi bulun.
// date time kullanarak her hafyai datetime olarak atayin. 5 tutturma zamani hangi yilda olacak ve ne kadar para harcanmis olacak bunu ekrana yazdirin
/*
var numbers = new int[6];
numbers[0] = 33;
numbers[1] = 45;
numbers[2] = 47;
numbers[3] = 15;
numbers[4] = 18;
numbers[5] = 21;

var rnd = new Random();

var luckyNumbers = new int[6];

var weeksPassed = 0;

var date = DateTime.Now;

for (int i = 0; i < 10000; i++)   // hafta
{
    var correctAnswersCount = 0;

    for (int j = 0; j < luckyNumbers.Length; j++)   // yeni numaralar
    {
        luckyNumbers[j] = rnd.Next(0, 50);
    }

    for (int k = 0; k < numbers.Length; k++)  // kontrol, kullanici sayilari
    {
        for (int x = 0; x < luckyNumbers.Length; x++) // kontrol, random sayilar
        {
            if (numbers[k] == luckyNumbers[x]) // karsilastirma
            {
                correctAnswersCount++;
            }
        }
    }

    weeksPassed++;
    date = date.AddDays(7);
    Console.WriteLine("Tarih : {0} -- {1} Hafta Gecti. -- Toplam Maliyet {2}tl -- {3} Adet Dogru Tahmin Yapildi", date, weeksPassed, weeksPassed * 15, correctAnswersCount);
    // System.Threading.Thread.Sleep(50);

    if (correctAnswersCount == 5)
    {

        Console.WriteLine("5 adet dogru tahmin {0} Tarihinde Geldi", date.ToShortDateString());
        Console.WriteLine("{0} hafta surdu", weeksPassed);
        Console.WriteLine("Toplam bilet maliyeti => {0} tl", weeksPassed * 15);
        break;
    }
}
*/
#endregion

#region ekrandan aldiginiz 10 elemanli diziyi, ekrandan aldiginiz degerlere doldurunuz sonra diziyi ters cevirin
/*
var numbers = new int[10];
var numbersReversed = new int[numbers.Length];



for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine("{0}. Sayiyi giriniz", i + 1);
    numbers[i] = int.Parse(Console.ReadLine());
}

var counter = 0;
for (int i = numbers.Length - 1; i >= 0; i--)
{
    numbersReversed[counter] = numbers[i];
    counter++;
}

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine("{0}. => {1}", i + 1, numbersReversed[i]);
    System.Threading.Thread.Sleep(50);
}
*/
#endregion

#region ODEV: BOBBLE SORTING ILE 20 ELEMANLI BIR DIZIYI SIRALAYINIZ.
/*
var rnd = new Random();

var numbers = new int[20];
// var copy = new int[numbers.Length]; // kontrol icin arrayin ilk halini buraya yazcaz

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rnd.Next(0, 100);
}

// Array.Copy(numbers, copy, numbers.Length); // ilk halini kaydet kontrol amacli

for (int i = 0; i < numbers.Length; i++)
{
    for (int j = 1; j < numbers.Length - i; j++)
    {
        if (numbers[j - 1] > numbers[j])
        {
            var hold = numbers[j - 1];
            numbers[j - 1] = numbers[j];
            numbers[j] = hold;
        }
    }
}
Console.WriteLine();

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine("{0} => {1}", i + 1, numbers[i]);
    System.Threading.Thread.Sleep(300);
}
*/
#endregion

#region 

#endregion