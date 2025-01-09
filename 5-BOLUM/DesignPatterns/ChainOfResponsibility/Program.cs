// Stock -> Payment -> Invoice -> Shipping

var order = new Order(); // siparis
var stockControl = new StockControl(); // stok kontrol sinifi
var paymentControl = new PaymentControl(); // payment kontrol
var invoiceControl = new InvoiceControl(); // invoice kontrol
var shippingControl = new ShippingControl(); // shipping kontrol

stockControl.SetNext(paymentControl); // stock kontrolun nextine -> payment kontrol verildi
paymentControl.SetNext(invoiceControl); // paymentin nexti -> invoice 
invoiceControl.SetNext(shippingControl); // invoice nexti -> shipping kontrol


stockControl.Handle(order); // zinciri baslat




public interface IOrderHandler
{
    void SetNext(IOrderHandler _next);
    bool Handle(Order order);
}

public class Order
{
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}

public class StockControl : IOrderHandler
{
    private IOrderHandler _next; // bir sonraki islemin ne olacagini iceri alacagiz
    public void SetNext(IOrderHandler next) // bir sonraki islemin ne olacagini disardan iceriye aldik.
    {
        _next = next;
    }
    public bool Handle(Order order)
    {
        bool stockAvailable = true; // servisi kontrol ettik ve stok durumunu kontrol ettik

        if (_next != null && stockAvailable) // eger bir sonraki islem yoksa ve stok islemi basariliysa zincirin sonraki halkasina gonder
        {
            return _next.Handle(order);
        }
        return false; // degilse islem basarisiz olmustur.
    }
}

public class PaymentControl : IOrderHandler
{
    private IOrderHandler _next; // bir sonraki islemin ne olacagini iceri alacagiz
    public void SetNext(IOrderHandler next) // bir sonraki islemin ne olacagini disardan iceriye aldik.
    {
        _next = next;
    }
    public bool Handle(Order order)
    {
        bool paymentSuccess = true; // servisi kontrol ettik ve stok durumunu kontrol ettik

        if (_next != null && paymentSuccess) // eger bir sonraki islem yoksa ve stok islemi basariliysa zincirin sonraki halkasina gonder
        {
            return _next.Handle(order);
        }
        return false; // degilse islem basarisiz olmustur.
    }
}

public class InvoiceControl : IOrderHandler
{
    private IOrderHandler _next; // bir sonraki islemin ne olacagini iceri alacagiz
    public void SetNext(IOrderHandler next) // bir sonraki islemin ne olacagini disardan iceriye aldik.
    {
        _next = next;
    }
    public bool Handle(Order order)
    {
        bool invoiceSuccess = true; // servisi kontrol ettik ve stok durumunu kontrol ettik

        if (_next != null && invoiceSuccess) // eger bir sonraki islem yoksa ve stok islemi basariliysa zincirin sonraki halkasina gonder
        {
            return _next.Handle(order);
        }
        return false; // degilse islem basarisiz olmustur.
    }
}

public class ShippingControl : IOrderHandler
{
    private IOrderHandler _next; // bir sonraki islemin ne olacagini iceri alacagiz
    public void SetNext(IOrderHandler next) // bir sonraki islemin ne olacagini disardan iceriye aldik.
    {
        _next = next;
    }
    public bool Handle(Order order)
    {
        bool shippingSuccess = true; // servisi kontrol ettik ve stok durumunu kontrol ettik

        if (_next != null && shippingSuccess) // eger bir sonraki islem yoksa ve stok islemi basariliysa zincirin sonraki halkasina gonder
        {
            return _next.Handle(order);
        }
        return false; // degilse islem basarisiz olmustur.
    }
}
