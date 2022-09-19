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
            int[] tableau1 = { 15, 19, 8, 5, 17, 10 };
            int[] tableau2 = { 2, 25, 11, 6 };
            int[] tableau3 = new int[tableau1.Length + tableau2.Length];
            for (int i = 0; i < tableau1.Length; i++)
            {
                tableau3[i] = tableau1[i];
                }
            for (int j = 0; j< tableau2.Length;j++)
            {
                tableau3[j+tableau1.Length] = tableau2[j];
            }
            Console.WriteLine("[");
            foreach (int argument in tableau3)
            {
                Console.Write("[{0}]", argument);
            }
            Console.WriteLine("]");
        }
        
        //Exercice 10
        static int[] GenererTableauAleatoire(int x,int y, int k)
        {
            Random rand = new Random(); // générateur aléatoire
            int val = rand.Next(y, k); // génère une valeur entre 0 et 40 
            int[] tab = new int[val];

            for(int i = 0; i < x; i++)
            {
                val = rand.Next(y, k);
                tab[i] = val;
                
            }
            return tab;
        }

        static int Moyenne(int []tab)
        {
            
            int somme = 0;
            for(int i=0; i<tab.Length; i++)
            {
                somme += i;
            }
            somme=somme/ tab.Length;
            return somme;
        }

        static void Affichertab()
        {
            int[] tableau = GenererTableauAleatoire(10, 0, 40);

            for(int i=0; i<10; i++)
            {
                Console.WriteLine(tableau[i]);
            }

            double moyenneTab = Moyenne(tableau);
            Console.WriteLine("Moyenne ="+moyenneTab);
        }
        static void Exercice12()
        {
            int compteur = 1;
            Console.WriteLine("Saisir les dimensions de la matrice");
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int[,] array = new int[N, M];
            for (int i = 0; i < N; i++)
            {
                for(int j = 0; j<M; j++)
                {
                    array[i,j] = compteur;
                    compteur += 1;
                }
            }
            for (int i = 0; i < N; i++)
            {
                   for (int j =0; j<M ; j++)
                        {
                            Console.Write(array[i,j]);
                        }
                Console.WriteLine("");
            }
            
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
            //Exercice8();
            Console.ReadKey();
        }
    }
   
}
