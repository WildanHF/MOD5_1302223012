namespace MOD5_1302223012
{
    public class Penjumlahan<T>
    {
        public T JumlahTigaAngka<T>(T angka1, T angka2, T angka3) where T : IAdditionOperators<T, T, T>
        {
            return angka1 + angka2 + angka3;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Penjumlahan<float> JumlahTigaAngka = new Penjumlahan<float>();

            Console.WriteLine(JumlahTigaAngka.JumlahTigaAngka(13, 02, 22));
        }
    }
}