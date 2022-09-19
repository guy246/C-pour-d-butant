using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Exercice1()
        {
            int i = 0;
            string[] tab = new string[4] {"a","b","c","d"};
            while (i != tab.Length) 
            {
                Console.WriteLine(tab[i]);
                i += 1;
            }
            for (int k = 0; k< tab.Length; k++)
            {
                Console.WriteLine(tab[k]);
            }

        }
        static void Exercice2()
        {
            int[] tab = new int[6] { 15, 19, 8, 5, 17, 10 };
            int i = 0;
            while (i != tab.Length)
            {
                Console.WriteLine(tab[i]);
                i += 1;
            }
            for (int k = 0; k < tab.Length; k++)
            {
                Console.WriteLine(tab[k]);
            }
            foreach (int argument in tab)
            {
                Console.WriteLine(argument);
            }
        }
        static void Exercice3()
        {
            int[] tab = new int[6] { 15, 19, 8, 5, 17, 10 };
            for ( int k = 0; k< tab.Length -1; k++)
            {
                Console.Write("{0}; ", tab[k]);
            }
            Console.WriteLine(tab[tab.Length -1]);
        }
        static void Exercice4()
        {
            Console.WriteLine("Saisissez la taille du tableau");
            int n = int.Parse(Console.ReadLine());
            int[] tab = new int[n];
            Console.Write("[");
            for (int k = 0; k < n; k++)
            {
                tab[k] = k + 1;
                Console.Write("["+tab[k]+"]");
            }
            Console.Write("]");
        }
        static void Exercice5()
        {
            Console.WriteLine("Saisissez le taille du tableau");
            int n = int.Parse(Console.ReadLine());
            int[] tab = new int[n];
            Console.Write("[");
            for (int k = 0; k < n; k++)
            {
                tab[k] = n-k;
                Console.Write("[" + tab[k] + "]");
            }
            Console.Write("]");
        }
        static void Exercice6()
        {

            Console.WriteLine("Saisissez le taille du tableau");
            int n = int.Parse(Console.ReadLine());
            int[] tab = new int[n];
            Console.Write("[");
            for (int k = 0; k < n; k++)
            {
                tab[k] = 2*k+1;
                Console.Write("[" + tab[k] + "]");
            }
            Console.Write("]");
        }
        static void Exercice7()
        {
            Console.WriteLine("Saisissez le taille du tableau");
            int n = int.Parse(Console.ReadLine());
            int[] tab = new int[n];
            Console.Write("[");
            for (int k = 0; k < n; k++)
            {
                tab[k] = (int)Math.Pow(2,k+1);
                Console.Write("[" + tab[k] + "]");
            }
            Console.Write("]");
        }
        static void Exercice8()
        {

        }
        static void Main(string[] args)
        {
            //Exercice1();
            //Exercice2();
            //Exercice3();
            //Exercice4();
            //Exercice5();
            //Exercice6();
            //Exercice7();
            Console.ReadKey();
        }
    }
   
}
