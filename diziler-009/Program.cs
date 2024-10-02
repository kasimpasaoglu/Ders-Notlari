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

#region 10 sayi alip tekse tek ciftse cift arrayde olusturunuz.
/*
var userInputs = new int[10];
var evenNumbersCount = 0;
var oddNumbersCount = 0;

for (int i = 0; i < userInputs.Length; i++)
{
    Console.WriteLine("{0}. Sayiyi Giriniz:", i + 1);
    userInputs[i] = int.Parse(Console.ReadLine());
    if (userInputs[i] % 2 == 0)
    {
        evenNumbersCount++;
    }
    else
    {
        oddNumbersCount++;
    }
}
var evenNumbers = new int[evenNumbersCount];
var oddNumbers = new int[oddNumbersCount];


var evenCounter = 0;
var oddCounter = 0;
for (int i = 0; i < userInputs.Length; i++)
{
    if (userInputs[i] % 2 == 0)
    {
        evenNumbers[evenCounter] = userInputs[i];
        evenCounter++;
        Console.WriteLine("{0}. Cift Sayi", evenCounter);

    }
    else
    {
        oddNumbers[oddCounter] = userInputs[i];
        oddCounter++;
        Console.WriteLine("{0}. Tek Sayi", oddCounter);
    }
}
*/
#endregion

#region Bir String Dizisi icinde 10 adet isim yazin.( Kullanicidan almaya gerek yok). ilk harfi ve son harfi gosterip aradaki harfleri ** yapan (sansurleyen) uygulama
/*
var users = new string[10];
users[0] = "Kasim";
users[1] = "Emrah";
users[2] = "Arda";
users[3] = "Hayriye";
users[4] = "Fatma";
users[5] = "Jale";
users[6] = "Orhan";
users[7] = "Umit";
users[8] = "Alp";
users[9] = "Selcuk";

var usersCensored = new string[users.Length];

for (int i = 0; i < users.Length; i++)
{
    var firstLetter = users[i].Substring(0, 1);
    var lastLetter = users[i].Substring(users[i].Length - 1, 1);
    var censor = "";
    for (int j = 0; j < users[i].Length - 2; j++)
    {
        censor += '*';
    }
    usersCensored[i] = firstLetter + censor + lastLetter;
    Console.WriteLine(firstLetter + censor + lastLetter);
}
*/
#endregion

#region Uygulama 5 adet not istesin, ve bu notlari dizide tutalim, notlari aldiktan sonra kullaniciya asagidaki soruyu sorup, geregini yapalim. Degistirmek istediginiz not varsa 1 e basin, (hangi notun degisecegini sorup degeri sormak gerekecek) notlari siralanmis listelemek icin 2 e basin, cikmak icin 3 e basin.
/*
var notes = new int[5];

for (int i = 0; i < notes.Length; i++)
{
    Console.WriteLine("{0}. Notunuzu Girin", i + 1);
    notes[i] = int.Parse(Console.ReadLine().Trim());
}

Console.WriteLine("Girmis Oldugunuz Notlar:");
for (int i = 0; i < notes.Length; i++)
{
    Console.WriteLine("{0} => {1}", i + 1, notes[i]);
}

while (true)
{
    Console.WriteLine("Degistirmek Istediginiz Not Varsa 1'e Basininiz");
    Console.WriteLine("Notlari Siralamak Icin Not Varsa 2'e Basininiz");
    Console.WriteLine("Cikmak Icin 3'e Basininiz");
    var input = int.Parse(Console.ReadLine().Trim());

    if (input == 1)
    {
        Console.WriteLine("Degistirmek Istediginiz Notun Sirasini Giriniz");
        var editNumber = int.Parse(Console.ReadLine().Trim());
        Console.WriteLine("Yeni Notu Giriniz");
        notes[editNumber - 1] = int.Parse(Console.ReadLine().Trim());
    }
    if (input == 2)
    {
        Array.Sort(notes);
        for (int i = 0; i < notes.Length; i++)
        {
            Console.WriteLine("{0} => {1}", i + 1, notes[i]);
        }

    }
    if (input == 3)
    {
        break;
    }


}
*/
#endregion

#region ornek string'in char dizisi olmasi ile alakali. 10 adet isim alin, daha sonra bu isimlerin tersten yazilislarini ekrana yazdirin
/*
var names = new string[10];
for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine("{0}. Ismi Giriniz :", i + 1);
    var name = Console.ReadLine().Trim();

    for (int j = name.Length - 1; j >= 0; j--)
    {
        names[i] += name[j];
    }
}
for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine("{0}. Isim => {1}", i + 1, names[i]);
}
*/
#endregion

#region kopyalama islemi
/*
string[] stringDizi = { "Ali", "Mehmet", "Alper", "Kasim", "Kerem" };
string[] newStringDizi = new string[15];

Array.Copy(stringDizi, 0, newStringDizi, 5, stringDizi.Length);
*/
#endregion

#region queue ile arac listesi
/*
using System.Collections;

Queue cars = new Queue();

cars.Enqueue("Renault");
cars.Enqueue("Mercedes");
cars.Enqueue("Audi");
cars.Enqueue("BMW");
cars.Enqueue("Opel");
cars.Enqueue("Honda");
cars.Enqueue("Tofas");
cars.Enqueue("Togg");
cars.Enqueue("Hyundai");




var counter = cars.Count;
for (int i = 0; i < counter; i++)
{
    // Console.WriteLine($"{cars.Peek()}");
    Console.WriteLine("Diziden Eleman Cikarmak Icin Enter'a basiniz");
    Console.ReadLine();
    Console.WriteLine(cars.Dequeue().ToString());
    Console.WriteLine("Kalan Eleman Sayisi => {0}", cars.Count);
}
*/
#endregion

#region stack
/*
using System.Collections;

Stack stackDizisi = new Stack();

stackDizisi.Push("Yuk 1");
stackDizisi.Push("Yuk 2");
stackDizisi.Push("Yuk 3");
stackDizisi.Push("Yuk 4");
stackDizisi.Push("Yuk 5");
stackDizisi.Push("Yuk 6");
stackDizisi.Push("Yuk 7");

int counter = stackDizisi.Count;

for (int i = 0; i < counter; i++)
{
    Console.WriteLine("Stack Kolleksiyonundan bir eleman cikarmak icin enter'a basiniz");
    Console.ReadLine();
    string currentItem = stackDizisi.Pop().ToString();
    Console.WriteLine("Silinen => {0} -- Kolleksiyon Oge Sayisi => {1}", currentItem, stackDizisi.Count);
}
*/
#endregion

#region Array list
/*
using System.Collections;

ArrayList arrayList = new ArrayList();

arrayList.Add("Mercedes");
arrayList.Add("Audi");
arrayList.Add("Fiat");
arrayList.Add("Opel");
arrayList.Add("Honda");
arrayList.Add("BMW");


arrayList.TrimToSize();
arrayList.GetRange(1, 3);
Console.WriteLine(arrayList);
*/
#endregion

#region for dongusu ile array list doldurma
/*
using System.Collections;


ArrayList arrayList = new ArrayList();

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Eleman Giriniz");
    arrayList.Add(Console.ReadLine());
    Console.WriteLine("Count : {0} -- Capacity : {1}", arrayList.Count, arrayList.Capacity);
}
*/
#endregion

#region ogrenciden 10 adet not alip bu notlarin toplami ve ortalamsini yazdirin
/*
using System.Collections;

ArrayList notes = new ArrayList();

var total = 0;
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("{0}. Notu Giriniz", i + 1);
    notes.Add(int.Parse(Console.ReadLine()));
    total += (int)notes[i];
}
Console.WriteLine("Toplam => {0}", total);
Console.WriteLine("Ortalama => {0}", total / notes.Count);
*/
#endregion

#region random sayi oyununu array list ile yapalaim, tahminleri arrayde tutalim 
/*
using System.Collections;

var rnd = new Random();
ArrayList guesses = new ArrayList();

var randomNumber = rnd.Next(0, 100);

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("{0}. Tahmininizi Girin", i + 1);
    guesses.Add(int.Parse(Console.ReadLine()));
    if ((int)guesses[i] == randomNumber)
    {
        Console.WriteLine("Tebrikler Kazandiniz");
        break;
    }
    else if (i == 9)
    {
        Console.WriteLine("Kaybettiniz");
        break;
    }
    else if ((int)guesses[i] > randomNumber)
    {
        Console.WriteLine("Asagi");
    }
    else if ((int)guesses[i] < randomNumber)
    {
        Console.WriteLine("Yukari");
    }
}

Console.WriteLine("Yaptiginiz Tahminler :");
for (int i = 0; i < guesses.Count; i++)
{
    Console.Write("-{0}-", guesses[i]);
}
*/
#endregion

#region sayisal loto ornegi
/*
using System.Collections;

var rnd = new Random();
ArrayList userInputs = new ArrayList(6);
ArrayList random = new ArrayList(6);
ArrayList correctAnswers = new ArrayList();

for (int i = 0; i < userInputs.Capacity; i++)
{
    Console.WriteLine("{0}. Sayiyi Girin");
    userInputs.Add(int.Parse(Console.ReadLine()));
    random.Add(rnd.Next(1, 50));
}

Console.WriteLine("Tahminler Bitti, Cekilisi Gormek Icin Enter'a Basiniz");
Console.ReadLine();

for (int i = 0; i < userInputs.Count; i++)
{
    for (int j = 0; j < random.Count; j++)
    {
        if ((int)userInputs[i] == (int)random[j])
        {
            correctAnswers.Add(userInputs[i]);
            continue;
        }
    }
}

Console.WriteLine("Bilinen Sayilar");
for (int i = 0; i < correctAnswers.Count; i++)
{
    Console.Write("-{0}-", correctAnswers[i]);
}
*/
#endregion

#region ders disi calisma
/*
using System.Collections;

var rnd = new Random();
var notes = new ArrayList(10);
var names = new ArrayList(10) { "Ahmet", "Ayse", "Ali", "Merve", "Cansu", "Kasim", "Selcuk", "Burak", "Sahin", "Ozge", };

double total = 0;

for (int i = 0; i < notes.Capacity; i++)
{
    notes.Add(rnd.Next(0, 101));
    total += (int)notes[i];
}

double avarage = Math.Round(total / notes.Count, 2);

var studentsSuccess = new ArrayList();
var studentsSuccessNames = new ArrayList();
var studentsFail = new ArrayList();
var studentsFailNames = new ArrayList();

Console.WriteLine("Sinif Ortalamasi => {0}", avarage);
Console.WriteLine("Gecme Notunu Giriniz:");
var successNote = int.Parse(Console.ReadLine().Trim());
for (int i = 0; i < notes.Count; i++)
{
    if ((int)notes[i] >= successNote)
    {
        studentsSuccess.Add(notes[i]);
        studentsSuccessNames.Add(names[i]);
    }
    else
    {
        studentsFail.Add(notes[i]);
        studentsFailNames.Add(names[i]);
    }
}
Console.WriteLine("-------------------------------------");
Console.WriteLine("Sinifi Gecen Ogrenciler:");

for (int i = 0; i < studentsSuccess.Count; i++)
{
    Console.WriteLine("{0} => {1}", studentsSuccessNames[i], studentsSuccess[i]);
    System.Threading.Thread.Sleep(100);
}
Console.WriteLine("-------------------------------------");
Console.WriteLine("Sinifta Kalan Ogrenciler:");
for (int i = 0; i < studentsFail.Count; i++)
{
    Console.WriteLine("{0} => {1}", studentsFailNames[i], studentsFail[i]);
    System.Threading.Thread.Sleep(100);
}

*/
#endregion

#region Market sepeti simulasyonu
/*
using System.Collections;

var products = new ArrayList() { "Elma", "Armut", "Muz", "Uzum", "Cilek", "Sut", "Ekmek", "Peynir", "Yogurt", "Yumurta" };
var prices = new ArrayList() { 3.50, 3.75, 4.75, 2.98, 4.85, 6.15, 2.50, 4.95, 2.70, 2.45 };

var cartProducts = new ArrayList();
var cartPrices = new ArrayList();

while (true)
{
    Console.WriteLine("Urunler :");
    for (int i = 0; i < products.Count; i++)
    {
        Console.WriteLine("{0} -> {1}TL", products[i], prices[i]);
        System.Threading.Thread.Sleep(100);
    }
    Console.WriteLine("Sepetinize urun eklemek icin, urunun adini yaziniz");
    Console.WriteLine("Sonlandirmak ve odeme sayfasina gecmek icin 'exit' yaziniz");
    var input = Console.ReadLine().Trim();


    if (products.Contains(input))
    {
        var index = products.IndexOf(input);
        cartProducts.Add(products[index]);
        cartPrices.Add(prices[index]);
    }
    else if (input == "exit")
    {
        double total = 0;
        Console.WriteLine("Alisveris Sepetiniz: ");
        for (int i = 0; i < cartProducts.Count; i++)
        {
            Console.WriteLine("{0} -> {1}tl", cartProducts[i], cartPrices[i]);
            total += (double)cartPrices[i];
            System.Threading.Thread.Sleep(300);
        }

        Console.WriteLine("Toplam -> {0}tl", Math.Round(total, 2));
        Console.WriteLine("-----------------------------");
        while (true)
        {
            Console.WriteLine("Odeme yapmak icin tutar giriniz");
            double payment = double.Parse(Console.ReadLine().Trim());
            if (payment < total)
            {
                Console.WriteLine("Odemeniz gereken tutar => {0}tl", Math.Round(total, 2));
                Console.WriteLine("Lutfen Tekrar Deneyiniz");
            }
            else
            {
                Console.WriteLine("Para ustu => {0}tl", Math.Round(payment - total, 2));
                Console.WriteLine("TESEKKURLER");
                break;
            }
        }
        break;
    }
    else
    {
        Console.WriteLine("Girdiginiz urun bulunamadi, lutfen tekrar deneyiniz.");
    }

}
*/
#endregion

#region rasgele sayilar ile calisma

/*
Console.WriteLine("Kac Adet Sayi Olusturulsun ?");
var numberCount = int.Parse(Console.ReadLine().Trim());

var rnd = new Random();

var numbers = new ArrayList(numberCount);
var oddNumbers = new ArrayList();
var evenNumbers = new ArrayList();
var maxValue = int.MinValue;
var minValue = int.MaxValue;
double total = 0;

for (int i = 0; i < numbers.Capacity; i++)
{
    int number = rnd.Next(0, 101);
    numbers.Add(number);
    total += number;

    if (number > maxValue) maxValue = number;
    if (number < minValue) minValue = number;

    if (number % 2 == 0)
    {
        evenNumbers.Add(number);
    }
    else
    {
        oddNumbers.Add(number);
    }
}
evenNumbers.Sort();
oddNumbers.Sort();
Console.WriteLine("Uretilen Cift Sayilar ({0} Adet) :", evenNumbers.Count);

for (int i = 0; i < evenNumbers.Count; i++)
{
    Console.Write("-{0}-", evenNumbers[i]);
}

Console.WriteLine();
Console.WriteLine("------------------------------");
Console.WriteLine("Uretilen Tek Sayilar ({0} adet) :", oddNumbers.Count);

for (int i = 0; i < oddNumbers.Count; i++)
{
    Console.Write("-{0}-", oddNumbers[i]);
}

Console.WriteLine();
Console.WriteLine("------------------------------");
Console.WriteLine("En buyuk sayi : {0}", maxValue);
Console.WriteLine("En kucuk sayi : {0}", minValue);
Console.WriteLine("Sayilarin toplami : {0}", total);
Console.WriteLine("Sayilarin ortalamasi : {0}", Math.Round(total / numbers.Count, 2));
*/
#endregion

#region konu disina cikmak gerekti... metni ters cevirme, kelimeler ayni yerinde kalacak, ancak her kelime tersten yazilacak.
/*
Console.WriteLine("Bir Metin Giriniz");
var text = Console.ReadLine().Trim();
var inputArray = new ArrayList(text.Split(' '));

for (int i = 0; i < inputArray.Count; i++)
{
    char[] charArray = inputArray[i].ToString().ToCharArray(); // inputArrayden aldigimiz objeyi stringe cevirip, sonra bir char arraye donusturuyoruz.
    Array.Reverse(charArray); // olusturdugumuz charArrayi ters ceviriyoruz
    inputArray[i] = new string(charArray); // inputArray[i]' ye charArrayi bir string olarak yaziyoruz. 
}


Console.WriteLine();
*/
#endregion

#region Anagram Kontrolu Yapan Uygulama
/*
Console.WriteLine("1. Kelimeyi Girin");
var firstLetter = Console.ReadLine().Trim().ToLower();

Console.WriteLine("2. Kelimeyi Girin");
var secondLetter = Console.ReadLine().Trim().ToLower();

char[] firstArray = firstLetter.ToCharArray();
char[] secondArray = secondLetter.ToCharArray();

if (firstArray.Length != secondArray.Length)
{
    Console.WriteLine("Uzunluklari farkli, Anagram Degil!");
}
else
{
    Array.Sort(firstArray);
    Array.Sort(secondArray);
    string firstArraySorted = new string(firstArray);
    string secondArraySorted = new string(secondArray);

    if (firstArraySorted == secondArraySorted) Console.WriteLine("{0} ve {1} Anagramdir", firstLetter, secondLetter);
    else Console.WriteLine("{0} ve {1} Anagram Degildir", firstLetter, secondLetter);
}
*/
#endregion

#region kutuphane uygulamasi
/*
var books = new ArrayList() { "Sefiller", "Suc ve Ceza", "Simyaci", "1984", "Hayvan Ciftligi" };
var takenBooks = new Queue();

while (true)
{
    Console.WriteLine("Mevcut Kitaplar:");
    for (int i = 0; i < books.Count; i++)
    {
        Console.WriteLine("{0}. {1}", i + 1, books[i]);
    }
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine("Cikmak Icin 'exit' yazin");
    Console.WriteLine("Kitap Iade Etmek Icin 'return' yaziniz");
    Console.WriteLine("Kitap Odunc Almak Icin Enter'a Basiniz");
    Console.WriteLine("--------------------------------------------");
    var input = Console.ReadLine().Trim().ToLower();
    if (input == "exit")
    {
        if (takenBooks.Count > 0)
        {
            Console.WriteLine("Cikmadan Once Kitaplari Iade Ediniz");
        }
        else break;
    }
    else if (input == "return")
    {
        if (takenBooks.Count > 0)
        {
            var returnedBook = takenBooks.Dequeue();
            books.Add(returnedBook);
            Console.WriteLine("Kitap Iade Edildi : {0}", returnedBook);
        }
        else Console.WriteLine("Odunc Alinmis Kitap Yok");
    }
    else
    {
        Console.Write("Bir Kitap Secin (1-{0}): ", books.Count);
        var choosenBookIndex = int.Parse(Console.ReadLine().Trim()) - 1;
        Console.WriteLine("Kitap Odunc Alindi : {0}", books[choosenBookIndex]);
        takenBooks.Enqueue(books[choosenBookIndex]);
        books.RemoveAt(choosenBookIndex);
        Console.WriteLine();
    }
}
*/
#endregion

#region randevu olusturma uygulamasi
/*
var name = new Queue();
var time = new Queue();

var completedName = new ArrayList();
var completedTime = new ArrayList();

while (true)
{
    Console.WriteLine(" ");
    Console.WriteLine("1. Yeni Randevu Ekle");
    Console.WriteLine("2. Siradaki Randevuyu Tamamla");
    Console.WriteLine("3. Gecmis Randevulari Goruntule");
    Console.WriteLine("4. Cikis");
    Console.WriteLine(" ");
    Console.Write("Seciminizi Yapin (1-4) :");

    var input = Console.ReadLine().Trim();


    if (input == "1" || input == "2" || input == "3" || input == "4")
    {
        if (input == "1")
        {
            Console.WriteLine("Isim Giriniz :");
            name.Enqueue(Console.ReadLine().Trim());

            Console.WriteLine("Saat Giriniz (HH:mm) :");
            time.Enqueue(TimeOnly.Parse(Console.ReadLine().Trim()));

            Console.WriteLine("Randevu Basariyla Eklendi");
        }
        else if (input == "2")
        {
            if (name.Count > 0)
            {
                completedName.Add(name.Peek().ToString());
                completedTime.Add(time.Peek().ToString());
                Console.WriteLine("Siradaki Randevu : {0} - {1}", name.Dequeue(), time.Dequeue());
                Console.WriteLine("Randevu Tamamlandi");
            }
            else Console.WriteLine("Bekleyen Randevu Bulunmamaktadir");
        }
        else if (input == "3")
        {
            if (completedName.Count > 0)
            {
                Console.WriteLine("Tamamlanmis Randevular :");
                for (int i = 0; i < completedName.Count; i++)
                {
                    Console.WriteLine("Isim => {0} - Saat => {1}", completedName[i], completedTime[i]);
                }
            }
            else Console.WriteLine("Henuz Bir Randevuyu Tamamlamadiniz");
        }
        else if (input == "4")
        {
            break;
        }
    }
    else
    {
        Console.WriteLine("Gecersiz Secim");
    }
}
*/
#endregion

#region 

using System.Collections;
/*

SortedList sortedList = new SortedList();
sortedList.Add(1, "Ali"); 
sortedList.Add(9, "Hande"); 
sortedList.Add(6, "Elif"); 
sortedList.Add(7, "Selcuk"); 

for (int i = 0; i < sortedList.Count; i++)
{
    string value = sortedList.GetByIndex(i).ToString();
    Console.WriteLine(value);
    int key = (int)sortedList.GetKey(i);
    Console.WriteLine(key);
}
*/

#endregion

#region Turkiye il plaka ve il adi listesini sorted list ile tanimlayiniz sonra ekrana yazdiriniz
/*
SortedList cities = new SortedList();

string[] cityNames = { "Adana", "Adiyaman", "Afyonkarahisar", "Agri", "Amasya", "Ankara", "Antalya", "Artvin", "Aydin", "Balikesir", "Bilecik", "Bingol", "Bitlis" };

for (int i = 0; i < cityNames.Length; i++)
{
    cities.Add(i + 1, cityNames[i]);
}

for (int i = 0; i < cities.Count; i++)
{
    if (i < 9)
    {
        Console.WriteLine("0{0}, {1}", cities.GetKey(i), cities.GetByIndex(i));
    }
    else
    {
        Console.WriteLine("{0}, {1}", cities.GetKey(i), cities.GetByIndex(i));
    }
}
*/
#endregion



