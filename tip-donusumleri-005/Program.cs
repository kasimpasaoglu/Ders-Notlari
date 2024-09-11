
// Console.WriteLine("Lutfen bir sayi girin :");

// string userInput = Console.ReadLine();
// int convertedUserInput = Convert.ToInt32(userInput);

// convertedUserInput *= 2;
// Console.WriteLine(convertedUserInput);


// Console.WriteLine("Sayi Girin :");
// int userInput = Convert.ToInt32(Console.ReadLine());

// int modUserInput = userInput % 2;

// bool isNumberOdd = modUserInput == 1;

// Console.WriteLine("sayi tek mi?  " + isNumberOdd);


// Console.WriteLine("Yasinizi Girin");

// int userAge = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Toplam Yasadiginiz Gun Sayisi :" + (userAge * 365));

// Console.WriteLine("======================================");

// Console.WriteLine("Ucgenin taban uzunlugunu giriniz (cm)");
// int triangleWidth = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Ucgenin yukseklik uzunlugunu giriniz (cm)");
// int triangleHeight = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Ucgeninizin alani =" + ((triangleWidth * triangleHeight) / 2));

// Console.WriteLine("======================================");

// Console.WriteLine("Yaricapi degerini giriniz");

// int yariCap = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(" Cevresi :" + 2 * Math.PI * yariCap);
// Console.WriteLine(" Alani :" + Math.PI * yariCap * yariCap);


// 10.09.2024 dersi =======================================
#region sayilar ile 4 islem
// Console.WriteLine("ilk sayiyi girin :");
// double firstInput = double.Parse(Console.ReadLine());

// Console.WriteLine();

// Console.WriteLine("ikinci sayiyi girin :");
// double secondInput = double.Parse(Console.ReadLine());

// Console.WriteLine();

// double biggerNumber = Math.Round(Math.Max(firstInput, secondInput), 2);
// double smallerNumber = Math.Round(Math.Min(firstInput, secondInput), 2);

// double total = biggerNumber + smallerNumber;
// double diff = biggerNumber - smallerNumber;
// double multiply = Math.Round(biggerNumber * smallerNumber, 2);
// double divide = Math.Round(biggerNumber / smallerNumber, 2);

// Console.WriteLine("{0} + {1}  = {2}", biggerNumber, smallerNumber, total);
// Console.WriteLine("{0} - {1}  = {2}", biggerNumber, smallerNumber, diff);
// Console.WriteLine("{0} * {1}  = {2}", biggerNumber, smallerNumber, multiply);
// Console.WriteLine("{0} / {1}  = {2}", biggerNumber, smallerNumber, divide);
#endregion

#region random sayi tek mi cift mi
// Random rnd = new Random();
// int randomNumber = rnd.Next();

// bool isNumberOdd = randomNumber % 2 != 0;
// Console.WriteLine("{0} sayisi tek mi? => {1}", randomNumber, isNumberOdd);
// Console.WriteLine();
#endregion

#region kucuk harfi rakamsal deger ile buyuk harfe cevir
// Console.WriteLine("Kucuk Harf Giriniz :");
// char letter = char.Parse(Console.ReadLine());
// int letterInt = Convert.ToInt32(letter);
// Console.WriteLine(letterInt);
// Console.WriteLine((letterInt - 32).ToString());
#endregion

#region random uretilmis karakter yazdiralim

// Random rnd = new Random();

// char randomChar1 = Convert.ToChar(rnd.Next(97, 122)); // kucuk harf araligi
// char randomChar2 = Convert.ToChar(rnd.Next(65, 90));  // buyuk harf araligi
// char randomChar3 = Convert.ToChar(rnd.Next(97, 122));
// char randomChar4 = Convert.ToChar(rnd.Next(65, 90));
// char randomChar5 = Convert.ToChar(rnd.Next(97, 122));


// Console.WriteLine("{0}{1}{2}{3}{4}", randomChar1, randomChar2, randomChar3, randomChar4, randomChar5);

#endregion

#region Cast
// int intDegisken = 10;
// byte byteDegisken = (byte)intDegisken;

// int intDegisken = 300;
// byte byteDegisken = (byte)intDegisken;

// long longDegisken = 10;
// int intDegisken = (int)longDegisken;
// Console.WriteLine(intDegisken);

// int intDegisken = 98;
// char charDegisken = (char)intDegisken;
// Console.WriteLine(charDegisken);

// bool inte donmeyecek 
// bool boolDegisken = true;
// int intDegisken = (int)boolDegisken;

// string chara donusmez
// string stringDegisken = "a";
// char charDegisken = (char)stringDegisken;

#endregion