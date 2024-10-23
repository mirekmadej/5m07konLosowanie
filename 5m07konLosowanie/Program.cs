/*
 * przedziału[0,100]
metoda losująca
*metoda wypisująca, która liczba wylosowana była najwięcej razy
*metoda przyjmują jako argument liczbę i wypisująca ile razy wystąpiła
*/
namespace _5m07konLosowanie
{
    class Liczby
    {
        const int N = 1000;
        const int M = 100;
        private int[] liczby = new int[M+1];
        public Liczby()
        {
            losuj();
        }
        private void losuj()
        {
            for(int i =0; i < M+1; i++)
                liczby[i] = 0;
            Random r = new Random();
            for (int i = 0; i < N; i++) 
                liczby[ r.Next(0, M + 1) ]++  ;
        }
        public int najwiecej()
        {
            int poz = 0, pozWart = liczby[0];
            for(int i = 0;i < liczby.Length;i++)
                if(liczby[i] >pozWart)
                {
                    poz = i;
                    pozWart = liczby[i];
                }
            return poz;
        }
        public int ileRazy(int n)
        {
            return liczby[n];
        }

        public void wypisz()
        {
            foreach (var n in liczby)
                Console.Write($"{n}, ");
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Liczby liczby = new Liczby();
            Console.WriteLine($"najwięcej razy wolosowana bylo liczba {liczby.najwiecej()}");
            int i = 15;
            Console.WriteLine($"liczba {i} wylosowana była {liczby.ileRazy(i)} razy");
        
        }
    }
}
