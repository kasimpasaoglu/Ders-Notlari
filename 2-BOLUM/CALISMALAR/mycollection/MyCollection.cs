using System.Collections;


public class MyCollection<T> : IEnumerable<T>
{
    private List<T> list = new List<T>();
    public int Count
    {
        get { return list.Count; }
    }

    public int Capacity
    {
        get { return list.Capacity; }
    }


    //indexer siniftaki verilere index ile ersimeyi saglar
    // indexer tanimi this keyword ile yapilir ve int turunden index parameteresi alir. 
    // koseli parantez icine yazilir, tipki prop gibi get ve set metodlari yazilir.
    // temel islevi verilen indexi kontrol edip gecerli aralikta ise ordaki degeri vermek, gecerli aralikta degilse hata firlatmaktir. 
    public T this[int index]
    {
        get
        {
            if (index >= 0 && index < list.Count)
            {
                return list[index];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        set
        {
            if (index >= 0 && index < list.Count)
            {
                list[index] = value;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }

        }
    }
    public void Add(T item)
    {
        list.Add(item);
    }
    public bool Remove(T item)
    {
        int index = list.IndexOf(item);
        if (index == -1)
        {
            return false;
        }
        else
        {
            list.RemoveAt(index);
            return true;
        }
    }

    public void RemoveAt(int index)
    {
        list.RemoveAt(index);
    }
    public int IndexOf(T item)
    {
        return list.IndexOf(item);
    }

    public IEnumerator<T> GetEnumerator()
    {
        foreach (var item in list)
        {
            yield return item;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}