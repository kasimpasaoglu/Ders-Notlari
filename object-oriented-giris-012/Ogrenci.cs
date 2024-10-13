public class Ogrenci
{
    public string name; //(simdilik name kucuk harf - kapsulleme icin)
    public string lastname;
    public int age;
}

public class Product
{
    public string image;
    public string name;
    public string details;
    public double price;
    public double discount;
}

public class Personel
{
    public string ad;
    public string soyad;
    public int yas;

    public Personel()
    {
        ad = "Muhittin";
        soyad = "Kemal";
        yas = 70;
    }
    public Personel(string a, string b, int c)
    {
        ad = a;
        soyad = b;
        yas = c;
    }
}