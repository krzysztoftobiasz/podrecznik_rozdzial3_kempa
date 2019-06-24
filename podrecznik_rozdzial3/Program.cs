using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podrecznik_rozdzial3
{
    class Program
    {
        /* static void Main(string[] args) //przyklad 3.1
         {
             int a, b;
             a = 3;
             b = 5;
             if (a < b)
                 Console.WriteLine("{0} jest mniejsze od {1}", a, b);
             Console.ReadKey();
         }*/


       /* static void Main(string[] args) //przykład 3.5
        {
            int x = 1, y = 2, z = 3;
            if (x == 1 || y != 5 && z < 1)
                Console.WriteLine("Warunek spełniony");
            else
                Console.WriteLine("Warunek niespełniony");
            Console.ReadKey();
        }
        */
            
        /*    static void Main(string[] args) // przyklad 3.6
        {
            string imie, nazwisko, tekst;
            Console.WriteLine("Podaj imie");
            imie = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko");
            nazwisko = Console.ReadLine();
            if (imie.Length + nazwisko.Length < 30)
            {
                tekst = imie + " " + nazwisko;
                Console.WriteLine(tekst);
            }
            else
            {
                Console.WriteLine("Imię i nazwisko jest za długie!");
            }
            Console.ReadKey();
        }
        */
        /*    public static void Main() //DZIAŁA!!
        {
            double przychod, koszty, dochod;
            
            Console.WriteLine("Wpisz przychód:");
             przychod = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wpisz koszty:");
            koszty = Convert.ToInt32(Console.ReadLine());
            dochod = przychod - koszty;
            if (dochod == 0)
            {
                Console.WriteLine("Mamy dochód zerowy");
            }
            else
            {
                if (dochod > 0)
                    Console.WriteLine("Mamy zysk");
                else
                    Console.WriteLine("Mamy stratę");
            }
            Console.ReadKey();
        } */

        static void Main(string[] args)  //przykład 3.9
        {
            int y, x = 1;
            y = (x > 0) ? ++x : --x;
            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}
