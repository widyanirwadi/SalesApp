namespace LearnEnumerable
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Membuat koleksi custom menggunakan IEnumerable
            var numbers = new NumberCollection();

            // Menambahkan beberapa angka ke dalam koleksi
            numbers.AddNumber("XXX");
            numbers.AddNumber("YYY");
            numbers.AddNumber("ZZZ");
            numbers.AddNumber("AAA");

            // Menggunakan foreach untuk meloopi elemen koleksi
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}