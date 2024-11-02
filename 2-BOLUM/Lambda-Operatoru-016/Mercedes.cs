public class Mercedes
{
    public int chasisNo { get; set; }
    public string model { get; set; }
    public string engine { get; set; }
    public Mercedes(int chasisNo, string model, string engine)
    {
        this.chasisNo = chasisNo;
        this.model = model;
        this.engine = engine;
    }
}