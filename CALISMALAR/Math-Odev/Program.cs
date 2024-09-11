

// {
//     Console.WriteLine("Pozitife Cevirmek Istediginiz Tam Sayiyi Girin:");
//     Console.WriteLine("Sayinin Pozitife donusumu = " + Math.Abs(Convert.ToInt32(Console.ReadLine())));
// }




// {
//     Console.WriteLine("Acisi Hesaplanacak(radyan) Kosinus degerini giriniz (-1<cos<1) :");
//     double userNumber = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
//     Console.WriteLine("Radyan = " + Math.Acos(userNumber));
// }




// {
//     Console.WriteLine("Ters Hiperbolik Kosinus hesapalamak icin deger girin (min deger '1'):");
//     double userNumber = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
//     Console.WriteLine("Ters Hiperbolik Kosinus : " + Math.Acosh(userNumber));
// }




// {
//     System.Console.WriteLine("Kuvveti alinacak sayiyi giriniz :");
//     double baseNumber = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
//     System.Console.WriteLine("Kuvveti giriniz :");
//     double powerNumber = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
//     double result = Math.Pow(baseNumber, powerNumber);
//     Console.WriteLine("{0} 'in {1} 'inci kuvveti = {2}", baseNumber, powerNumber, result);
// }




// {
//     Console.WriteLine("-- En buyuk ve en kucuk sayiyi bulma --");
//     System.Console.WriteLine("1. Sayiyi Girin :");
//     double number1 = Convert.ToDouble(Console.ReadLine());
//     System.Console.WriteLine("2. Sayiyi Girin :");
//     double number2 = Convert.ToDouble(Console.ReadLine());
//     System.Console.WriteLine("3. Sayiyi Girin :");
//     double number3 = Convert.ToDouble(Console.ReadLine());
//     System.Console.WriteLine("4. Sayiyi Girin :");
//     double number4 = Convert.ToDouble(Console.ReadLine());
//     System.Console.WriteLine("5. Sayiyi Girin :");
//     double number5 = Convert.ToDouble(Console.ReadLine());
//     System.Console.WriteLine("6. Sayiyi Girin :");
//     double number6 = Convert.ToDouble(Console.ReadLine());
//     System.Console.WriteLine("7. Sayiyi Girin :");
//     double number7 = Convert.ToDouble(Console.ReadLine());

//     double biggestNumber =
//     Math.Max(number1,
//     Math.Max(number2,
//     Math.Max(number3,
//     Math.Max(number4,
//     Math.Max(number5,
//     Math.Max(number6, number7))))));

//     double smallestNumber =
//     Math.Min(number1,
//     Math.Min(number2,
//     Math.Min(number3,
//     Math.Min(number4,
//     Math.Min(number5,
//     Math.Min(number6, number7))))));

//     Console.WriteLine("En kucuk sayi = " + smallestNumber);
//     Console.WriteLine("En buyuk sayi = " + biggestNumber);
// }

// {
//     Console.WriteLine(Math.DivRem(10, 3)); // out int ramainder ???
// }



// DETAYLI UCGEN COZUMLEME
// {
//     Console.WriteLine("Bir ucgenin alanini ve 3. kenar uzunlugunu bulma...");

//     Console.WriteLine("Birinci Kenar Uzunlugunu Giriniz (A) : ");
//     double sideA = Convert.ToDouble(Console.ReadLine());

//     Console.WriteLine("Ikinci Kenar Uzunlugunu Giriniz (B): ");
//     double sideB = Convert.ToDouble(Console.ReadLine());

//     Console.WriteLine("Bu iki kenar arasindaki Aciyi Giriniz (c): ");
//     double degreesC = Convert.ToDouble(Console.ReadLine());

//     // HESAPLAMALAR

//     // derece olarak gelen aciyi radyan cinsine cevir
//     double radiansC = degreesC * (Math.PI / 180);

//     // kosinus teoremi ile ucuncu kenari bulma (Kok icinde; A^2 + B^2 - 2(A*B*Cos(c)))
//     double sideC = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2) - 2 * sideA * sideB * Math.Cos(radiansC));

//     // alan hesaplama
//     double area = (sideA * sideB * Math.Sin(radiansC) / 2);

//     // Cevresini Hesapla
//     double perimeter = sideA + sideB + sideC;

//     // sinus kurali ile diger acilari hesaplama (arcsin(B/C * sin(c) * `Radyani Dereceye cevir`)

//     double degreesB = (Math.Asin((sideB / sideC) * Math.Sin(radiansC))) * (180 / Math.PI);

//     double degreesA = 180 - degreesB - degreesC;

//     // siniflandirma

//     double longSide = Math.Max(sideA, Math.Max(sideB, sideC));
//     double shortSide = Math.Min(sideA, Math.Min(sideB, sideC));
//     double middleSide = perimeter - longSide - shortSide;

//     double largeAngle = Math.Max(degreesA, Math.Max(degreesB, degreesC));
//     double smallAngle = Math.Min(degreesA, Math.Min(degreesB, degreesC));
//     double middleAngle = 180 - largeAngle - smallAngle;

//     // sonuclar
//     Console.WriteLine(" Uzun Kenar {0} => Karisindaki Aci {1} ", longSide, largeAngle);
//     Console.WriteLine(" Kisa Kenar {0} => Karisindaki Aci {1} ", shortSide, smallAngle);
//     Console.WriteLine(" Orta Kenar {0} => Karisindaki Aci {1} ", middleSide, middleAngle);
//     Console.WriteLine(" Cevresi {0} ve Alani {1} ", perimeter, area);
// }



// {
//     System.Console.WriteLine("Bir Koninin Hacmi ve yuzey alani hesaplama...");

//     Console.WriteLine("Taban Yaricapini Giriniz (r) :");
//     double radius = Convert.ToDouble(Console.ReadLine());

//     Console.WriteLine("Yuksekligi Giriniz (h)");
//     double height = Convert.ToDouble(Console.ReadLine());

//     // pisagor ile yan yuz uzunlugu bul

//     double hypotenuse = Math.Sqrt(Math.Pow(radius, 2) + Math.Pow(height, 2));

//     double volume = ((Math.PI * Math.Pow(radius, 2) * height) / 3);

//     double surfaceArea = Math.PI * radius * (radius + hypotenuse);
//     Console.WriteLine("Yaricapi {0} ve yuksekligi {1} olan koninin, hacmi {2} ve yuzey alani {3} olur...", radius, height, volume, surfaceArea);
// }



// // BIR NESNENIN ACISAL HIZINI KOORDINATLARINI HESAPLAMA
// {
//     Console.WriteLine("Daire Icinde Bir Noktanin Acisal Hizini, Konumunu Hesaplama");

//     Console.WriteLine("Dairenin yaricapini girin (r) :");
//     double radius = Convert.ToDouble(Console.ReadLine());

//     Console.WriteLine("Nesnenin cizgisel hizini girin (v)");
//     double vectoralVelocity = Convert.ToDouble(Console.ReadLine());

//     Console.WriteLine("Gecen Sureyi giriniz (t):");
//     double time = Convert.ToDouble(Console.ReadLine());

//     double angularVelocity = vectoralVelocity / radius;

//     double turnedAngle = angularVelocity * time;
//     double turnedAngleDegree = turnedAngle * (180 / Math.PI);

//     double coordinateX = radius * Math.Cos(turnedAngle);
//     double coordinateY = radius * Math.Sin(turnedAngle);

//     Console.WriteLine("Nesne baslangicta (x= {0}, y= {1}) koordinatlarinda", radius, 0);
//     Console.WriteLine("Nesnenin vektorel hizi = {0}, acisal hizi = {1}", vectoralVelocity, angularVelocity);
//     Console.WriteLine("Hareket Suresi = {0}, toplam donus acisi = {1}", time, turnedAngleDegree);
//     Console.WriteLine("Nesne hareketi tamamladiktan sonra (x= {0}, y= {1}) koordinatlarinda", coordinateX, coordinateY);

// }




// {
//     Console.WriteLine("--Bilesik Faiz Hesaplama--");

//     Console.WriteLine("Baslangic Yatirim tutarini girin (P):");
//     int principal = Convert.ToInt32(Console.ReadLine());

//     Console.WriteLine("Yillik faiz oranini girin (r):");
//     double interestRate = Convert.ToDouble(Console.ReadLine().Replace('.', ','));

//     Console.WriteLine("Yil Sayisi Girin (t):");
//     double years = Convert.ToDouble(Console.ReadLine());

//     Console.WriteLine("Faiz Periyodu Sayisini Giriniz (n) :");
//     int compoundingPeriodsPerYear = Convert.ToInt32(Console.ReadLine());

//     double futureValue = principal * Math.Pow(1 + interestRate / compoundingPeriodsPerYear, compoundingPeriodsPerYear * years);

//     Console.WriteLine("Vade Sonu Toplam Tutar = {0}", futureValue);

// }



// {
//     Console.WriteLine("--Hedef Tutara Ulasmak Icin Gereken Yil Zamani--");

//     Console.WriteLine("Baslangic Yatirim tutarini girin (P):");
//     double principal = Convert.ToDouble(Console.ReadLine());

//     Console.WriteLine("Gelecekteki Hedef Degeri Girin (A):");
//     double expectedFutureValue = Convert.ToDouble(Console.ReadLine());

//     Console.WriteLine("Yillik faiz oranini girin (r):");
//     double interestRate = Convert.ToDouble(Console.ReadLine().Replace('.', ','));

//     Console.WriteLine("Faiz Periyodu Sayisini Giriniz (n) :");
//     double compoundingPeriodsPerYear = Convert.ToDouble(Console.ReadLine());

//     double yearsReq = Math.Log(expectedFutureValue / principal) / (compoundingPeriodsPerYear * Math.Log(1 + (interestRate / compoundingPeriodsPerYear)));

//     Console.WriteLine("{0} Tutarindaki yatirimin {1} faizle, {2} tutarina ulasmasi icin, {3} periotlarla toplam {4} yil vadeye yatirilmasi gerekmektedir", principal, interestRate, expectedFutureValue, compoundingPeriodsPerYear, yearsReq);
// }



// {
//     Console.WriteLine();
//     Console.WriteLine("--Iki Nokta Arasindaki Mesafeyi ve Orta Noktayi Bulma--");

//     Console.WriteLine("Ilk noktanin x koordinatini girin :");
//     double startingPointX = Convert.ToDouble(Console.ReadLine());

//     Console.WriteLine("Ilk noktanin y koordinatini girin :");
//     double startingPointY = Convert.ToDouble(Console.ReadLine());

//     Console.WriteLine("Ikinci noktanin x koordinatini girin :");
//     double endingPointX = Convert.ToDouble(Console.ReadLine());

//     Console.WriteLine("Ikinci noktanin y koordinatini girin :");
//     double endingPointY = Convert.ToDouble(Console.ReadLine());

//     double distance = Math.Sqrt(Math.Pow(endingPointX - startingPointX, 2) + Math.Pow(endingPointY - startingPointY, 2));

//     double middleX = (startingPointX + endingPointX) / 2;
//     double middleY = (startingPointY + endingPointY) / 2;

//     Console.WriteLine("(X:{0}, Y:{1}) koordinatlarindan baslayip, (X:{2}, Y:{3}) koordinatlarinda biten dogrunun uzunlugu {4} olur. Orta noktasinin koordinatlari ise (X:{5}, Y:{6}) olur.", startingPointX, startingPointY, endingPointX, endingPointY, distance, middleX, middleY);

// }



{
    Console.WriteLine();
    Console.WriteLine("--Bakteri Populasyonunu Buyumesini Hesaplama--");
    Console.WriteLine();

    Console.WriteLine("Baslangic Populasyonunu Yaziniz :");
    int initPopulation = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Buyume Oranini Yaziniz :");
    double growthRate = Convert.ToDouble(Console.ReadLine().Replace(".", ","));

    Console.WriteLine("Sureyi yaziniz (saat)");
    double time = Convert.ToDouble(Console.ReadLine().Replace(".", ","));

    double finalPopulation = Math.Round(initPopulation * Math.Pow((1 + growthRate), time), 2);
    Console.WriteLine($"{time} saat sonra populasyin {finalPopulation} olacaktir");

    Console.WriteLine();

    Console.WriteLine("Hedeflenen Populasyonu Girin");
    double targetPopulation = Convert.ToDouble(Console.ReadLine());

    double reqTime = Math.Round(Math.Log(targetPopulation / initPopulation) / Math.Log(1 + growthRate), 2);

    int hours = Convert.ToInt32(Math.Floor(reqTime));  // sadece saati al

    double decimalPartOfTime = reqTime - hours;   // reqTime icindeki ondalik kismi al

    double minutesWithDecimal = decimalPartOfTime * 60;   // ondalik kismi 60 a carparak dakikaya cevir

    int minutes = Convert.ToInt32(Math.Floor(minutesWithDecimal));  // dakika icin ondalik kismi at, minutes olarak kaydet

    double decimalPartOfMinutes = minutesWithDecimal - minutes;   //  ondalikli dakika icindeki ondalik bolumunu al

    int seconds = Convert.ToInt32(Math.Ceiling(decimalPartOfMinutes * 60)); // ondalikli dakika icindeki ondalik bolumunu 60 a carpip saniyeye cevir, ve ondalik kismini at.

    Console.WriteLine("{0} Hedefinde ulasmak icin {1} saat, {2} dakika, {3} saniye gereklidir... ", targetPopulation, hours, minutes, seconds);
}

// double number = 1.5;
// double number = 1,5;

Math.Exp(10);