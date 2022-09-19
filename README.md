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
        
        static void Exercice9()
        {
            int[] tab = {1,4,8,5,3,15,2,35,24,6};
            int[] tabInverse = new int[tab.Length];
            for (int i =0; i < tab.Length; i++)
            {
                tabInverse[i] = tab[tab.Length -i-1];
            }
            Console.WriteLine("[");
            foreach (int argument in tabInverse)
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
            int[] tab = new int[x];

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
        
         static void Exercice11()
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            bool res = true;

            if (n1 != n2) { res = false; }

            int[] tab1 = new int[n1];
            for (int k =0; k< n1; k++) { tab1[k] = int.Parse(Console.ReadLine()); }

            int[] tab2 = new int[n2];
            for (int k = 0; k < n2; k++) { tab2[k] = int.Parse(Console.ReadLine()); }


                for (int i = 0; i < tab1.Length; i++)
                {
                    for (int j = 0; j < tab2.Length; j++)
                    {
                        if (tab1[i] != tab2[j]) { res = false; }
                        else { res = true; }
                    }
                }

            if (res==true) { Console.WriteLine("tableaux égaux"); }
            else { Console.WriteLine("tableaux différents"); }
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
                  
        static int[] TriBulles(int[] Array)
        {
            
            int MaxArray = Array.Length;
            int /*a,*/ /*b,*/ c, d;
            
            
            /*
            for (a = 0; a < MaxArray; a++)
            {
                Console.Write(Array[a] + ", ");
            }
            */
            for (c = MaxArray - 2; c >= 0; c--)
            {
                for (d = 0; d <= c; d++)
                {
                    if (Array[d + 1] < Array[d])
                    {
                        int ar = Array[d + 1];
                        Array[d + 1] = Array[d];
                        Array[d] = ar;
                    }
                }
            }
            return Array;


            ///for (b = 0; b < MaxArray; b++)
            {
                /// Console.Write(", " + Array[b]);
            }
                       
            
        }
        static void Exercice16()

        {
            int[] tab = GenererTableauAleatoire(10, 1, 20);
            AfficherTableau(tab);
            Console.WriteLine(" ");
            TriBulles(tab);
            AfficherTableau(tab);
            //on génère un tableau aléatoirement , on l'affiche on le tri et on l'affiche encore
        
        }   
        static int[,] ProduitMatriciel(int[,]mat1, int[,]mat2) // Exercice 14
        {
            int[,] nul = {};
            int[,] mat3 = new int[mat1.GetLength(0), mat2.GetLength(1)];
            int aux = 0;
            if (mat1.GetLength(1) != mat2.GetLength(0))
            {
                return nul ;
            }
            else
            {
                for (int i=0; i< mat1.GetLength(0);i++)
                {
                    for (int j=0; j< mat2.GetLength(1);j++)
                    {
                        aux = 0;
                        for (int k = 0; k < mat1.GetLength(1); k++)
                        {
                            aux+= mat1[i,k] * mat2[k,j];
                        }
                        mat3[i, j] = aux;
                    }
                }
                return mat3;
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
