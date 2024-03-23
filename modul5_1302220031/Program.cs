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
        Console.WriteLine(Penjumlahan.JumlahTigaAngka<float>(13,02,22));
    }
}
