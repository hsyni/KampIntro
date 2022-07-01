//using GenericsIntro;

//MyList<string> isimler = new MyList<string>();
//isimler.Add("Huseyin");

Mylist<string> mylist = new Mylist<string>();
mylist.Add("Huseyin");
mylist.Add("Huseyin");
mylist.Add("Huseyin");

Console.WriteLine(mylist.Count());

class Mylist<T>
{
    T[] array;

    public Mylist()
    {
        array = new T[0];
    }
    public void Add(T item)
    {
        T[] tempArray = array;
        array = new T[array.Length + 1];
        for (int i = 0; i < tempArray.Length; i++)
        {
            array[i] = tempArray[i];
        }
        array[array.Length - 1] = item;
    }

    public int Count()
    {
        return array.Length;
    }
}