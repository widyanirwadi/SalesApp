using System.Collections;

namespace LearnEnumerable
{
    public class NumberCollection : IEnumerable<string>
    {
        private List<string> numbers = new List<string>();

        // Metode untuk menambahkan angka ke dalam koleksi
        public void AddNumber(string number)
        {
            numbers.Add(number);
        }

        // Implementasi metode GetEnumerator() dari IEnumerable
        public IEnumerator<string> GetEnumerator()
        {
            return numbers.GetEnumerator();
        }

        // Implementasi metode non-generik dari IEnumerable
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        
    }
}
