public class Product
{
    public int id;
    public string name;
    public decimal price;

    public Product(int id, string name, decimal price)
    {
        this.id = id;
        this.name = name;
        this.price = price;
        // burdaki this 'ben sinifin uyesiyim demek. Yani bu sinifa ait id degeri = parametreden gelen id degeri.
        // ayni isimde degisken kullanirken bu keywordu kullanacagiz.
    }
}