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

#endregion