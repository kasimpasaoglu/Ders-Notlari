using System.Threading.Tasks.Dataflow;

int birinciSayi = 84;
int ikinciSayi = 38;
int toplam, carpim, bolum, mod, cikartim = 0;

toplam = birinciSayi + ikinciSayi;
cikartim = birinciSayi - ikinciSayi;
carpim = birinciSayi * ikinciSayi;
bolum = birinciSayi / ikinciSayi;
mod = birinciSayi % ikinciSayi;

Console.WriteLine(toplam);
Console.WriteLine("Çıkartım :" + cikartim);
Console.WriteLine("{0}+{1}={2}", birinciSayi, ikinciSayi, toplam);

Console.WriteLine("{0} ve {1} sayılarının, toplamı: {2}, farkı :{3}, çarpımı :{4}, bölümü :{5}, modu :{6}", birinciSayi, ikinciSayi, toplam, cikartim, carpim, bolum, mod);

Console.WriteLine("------");

int buyukSayi = 100;
int kucukSayi = 8;

bool kucukMu = kucukSayi < buyukSayi;
bool buyukMu = kucukSayi > buyukSayi;
bool esitMi = kucukSayi == buyukSayi;
bool esitDegilMi = kucukSayi != buyukSayi;

Console.WriteLine(" {0}, {1}'den kücük mü  :  {2}", kucukSayi, buyukSayi, kucukMu);
Console.WriteLine(" {0}, {1}'den büyük mü  :  {2}", kucukSayi, buyukSayi, buyukMu);
Console.WriteLine(" {0} esit mi {1} :  {2}", kucukSayi, buyukSayi, esitMi);
Console.WriteLine(" {0} esit değil mi {1} :  {2}", kucukSayi, buyukSayi, esitDegilMi);


Console.WriteLine("------");

string veriTabanindakiUserName, veriTabanindakiPassword, kullanicidanGelenUserName, kullanicidanGelenPassword;

veriTabanindakiUserName = "root";
veriTabanindakiPassword = "2020";

kullanicidanGelenUserName = "wissen";
kullanicidanGelenPassword = "1010";

bool girisOk = kullanicidanGelenUserName == veriTabanindakiUserName && kullanicidanGelenPassword == veriTabanindakiPassword;

Console.WriteLine("Giriş Yapıldı mı  :" + girisOk);

Console.WriteLine("------");

bool girisOrOk = kullanicidanGelenUserName == veriTabanindakiUserName || kullanicidanGelenPassword == veriTabanindakiPassword;

Console.WriteLine("Giriş Yapıldı mı  :" + girisOrOk);

Console.WriteLine("------");

int sayi1 = 4;
int sayi2 = 5;
int sayi3 = 6;
int sayi4 = 10;
int sayi5 = 54;
int sayi6 = 5;
int sayi7 = 9;

bool result = (sayi1 != sayi4 && sayi2 == sayi6) || (sayi4 < sayi5 || sayi3 >= sayi7);

Console.WriteLine(result);

Console.WriteLine("------");

int degisken = 10;
degisken += 1;

/*
int birinciDegisken = 10;
int ikinciDegisken = 80;

birinciDegisken += ikinciDegisken;
*/


/*
int birinciDegisken = 10;
birinciDegisken *=5;

int birinciDegisken = 10;
birinciDegisken -= 5;


int birinciDegisken = 10;
birinciDegisken /= 5;
*/

Console.WriteLine("------");

// int deger=0;
// deger++;

int deger = 0;
int sonuc = ++deger;
