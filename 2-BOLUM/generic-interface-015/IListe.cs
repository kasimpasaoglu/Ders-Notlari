public interface IListe<T> : IComparable<T>
{
    public void Add(T value);
    public void Delete(T value);
}