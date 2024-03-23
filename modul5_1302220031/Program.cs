// See https://aka.ms/new-console-template for more information

class Penjumlahan
{
    public static T JumlahTigaAngka <T> (T a, T b, T c)
    //a,b, dan c merupakan parameter generic
    {
        dynamic A = a;
        dynamic B = b;
        dynamic C = c;
        return A + B + C;
    }
}

class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Hasil penjumlahan ketiga angka: ");
        Console.WriteLine(Penjumlahan.JumlahTigaAngka<float>(13,02,22) + "\n");
        SimpleDataBase<float> Data = new SimpleDataBase<float>();
        Data.AddnewData(13);
        Data.AddnewData(02);
        Data.AddnewData(22);
        Data.PrintAllData();
    }
}

class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        this.storedData = new List<T>();
        this.inputDates = new List<DateTime>();
    }

    public void AddnewData(T data)
    {
        this.storedData.Add(data);
        this.inputDates.Add(DateTime.Now);
    }

    public void PrintAllData() {
        for (int i = 0; i < this.storedData.Count; i++) 
        {
            Console.WriteLine("Data " + i + " berisi: " + this.storedData[i] + ", yang disimpan pada waktu UTC: " + this.inputDates[i]);
        }
    }
}