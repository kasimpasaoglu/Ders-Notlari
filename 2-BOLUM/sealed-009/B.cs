public class B : A
{
    // sealed keywordu verildikten sonra artik B sinifindan kalitilan siniflarda override edilemez.. Yani C sinifinda Bu metodlarin override edilmesi engellendi
    // kalitim ile gelen bir metodun override edilmesini engellemis olur
    // C sinifi icinden hala erisilebilir!!! sadece override edilmesini engeler
    public sealed override void Metod1()
    {
        base.Metod1();
    }
    public sealed override void Metod2()
    {
        base.Metod2();
    }
}