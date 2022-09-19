using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TD5_6
{
    internal class Program
    {
        static int SaisiePositif()
        {
            Console.WriteLine("entrez un entire stictement positif");
            int nb= int.Parse(Console.ReadLine());

            while (nb <= 0)
            {
                Console.WriteLine("entrez une valeur strictement positif (>0)");
                nb = int.Parse(Console.ReadLine());
            }
            return nb;
        }

        static bool EstPair(int valeur)
        {

            if (valeur % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void TestEstPair()
        {
            Console.WriteLine("entrez une valeur pour savoir si elle est pair");
            int nb = int.Parse(Console.ReadLine());

            while (nb < 1 || nb>15)
            {
                Console.WriteLine("entrez une valeur strictement positif (>0)");
                nb = int.Parse(Console.ReadLine());
            }
            if (EstPair(nb)== true)
            {
                Console.WriteLine(nb + " est pair");
            }
            else
            {
                Console.WriteLine(nb + " est impair");
            }
        }

        static bool EstStrictementPositif(int value)
        {
            if (value>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void TestEstStrictementPoditif()
        {
            Console.WriteLine("entrez une valeur pour savoir si elle est pair");
            int nb = int.Parse(Console.ReadLine());

            while (nb < -10 || nb > 10)
            {
                Console.WriteLine("entrez une valeur strictement positif (>0)");
                nb = int.Parse(Console.ReadLine());
            }
            if (EstPair(nb) == true)
            {
                Console.WriteLine(nb+" est strictement positif");
            }
            else
            {
                Console.WriteLine(nb+" n'est pas strictement positif");
            }
        } 

        static int PosNeg(int nombre1, int nombre2)
        {


            if (nombre1 == 0 && nombre2 < 0 || nombre1 == 0 && nombre2 > 0 || nombre2 == 0 && nombre1 < 0 || nombre2 == 0 && nombre1 > 0)
            {
                return 0;
            }
            if (nombre1 < 0 && nombre2 > 0 || nombre1 > 0 && nombre2 < 0)
            {
                return -1;
            }
            if (nombre1 > 0 || nombre2 > 0)
            {
                return 1;
            }
            
            
            return 0;
        }

        static void TestPosNeg()
        {
            Console.WriteLine("entrez deux nombres pour savoir si leurs produit est positif, négatif ou nul");
            int nb = int.Parse(Console.ReadLine());
            int nb2 = int.Parse(Console.ReadLine());

            if (PosNeg(nb,nb2) == 1)
            {
                Console.WriteLine("la somme est strictement positif");
            }
            if (PosNeg(nb, nb2) == -1)
            {
                Console.WriteLine("la somme  est strictement négatatif");
            }
            if (PosNeg(nb, nb2) == 0)
            {
                Console.WriteLine("la somme  est strictement nul");
            }
        }

        static int SommeElements(int a, int b)
        {
            if (a <= b)
            {
                int sol = 0;
                for (int i = a; i < b+1 ; i++)
                {
                    sol = sol + i;

                }
                return sol;
            }
            if (a >b)
            {
                int sol2 = 0;
                for (int j = b; j < a+1; j++)
                {
                    sol2 = sol2 + j;
                }
                return sol2;
            }
            return 0;
        }

        static void TestSommeElements()
        {
            Console.WriteLine("entrez deux nombres pour faire la somme entre ces deux nombre");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("la somme est "+SommeElements(a,b));
        }

        static bool EstMultiple(int val, int n)
        {
            if (val % n == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        static void TestEstMultiple()
        {
            Console.WriteLine("entrez deux nombre postitif, pour savoir si le seuxième et un multiple du premier");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if(a>b && EstMultiple(a,b)== true)
            {
                Console.WriteLine(b+" est un multiple de "+a);
            }
            if (a < b && EstMultiple(b,a) == true)
            {
                Console.WriteLine(a + " est un multiple de " + b);
            }
            if (EstMultiple(a, b) == false && EstMultiple(b,a) == false)
            {
                Console.WriteLine(b +" et "+a +" ne sont pas un multiple l'un de l'autre");
            }
        }

        static int EstPlusGrand(int val1, int val2)
        {
            if (val1 < val2)
            {
                return val2;
            }
            if (val1 > val2)
            {
                return val1;
            }
            if (val1 ==val2)
            {
                return val2;
            }
            return 0;
        }

        static void TestEstPlusGrand()
        {
            Console.WriteLine("entrez deux nombre postitif, pour savoir si le seuxième et un multiple du premier");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("le plus grand nombre est "+EstPlusGrand(a,b));
        }

        static bool EstBissextile(int annee)
        {

            if (annee % 4 == 0 && (annee % 100 != 0 || annee % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void TestEstBissextile()
        {
            Console.WriteLine("entrez une année pour savoir si elle est bissextile");
            int annee = int.Parse(Console.ReadLine());

            if (EstBissextile(annee) == true)
            {
                Console.WriteLine(annee + " est une année bissextile");
            }
            if(EstBissextile(annee) == false)
            {
                Console.WriteLine(annee + " n'est pas une année bissextile");
            }
        }

        static int Factorielle(int value)
        {
            if (value == 0)
            {
                return 1;
            }
            else
            {
                return value * Factorielle(value - 1);
            }
            
        }

        static void TestFactorielle()
        {
            int nb;
            do
            {
                Console.WriteLine("entrez une valeur strictement positif (>0)");
                nb = int.Parse(Console.ReadLine());
            }while(nb <= 0);

            Console.WriteLine(Factorielle(nb));
        }

        static int Fibonacci(int n)
        {
            if(n == 0)
            {
                return 0;
            }
            if(n == 1)
            {
                return 1;
            }
            if (n > 1)
            {
               return (n -2) + Fibonacci(n -1);
                
            }
            return 0;
        }

        static void TestFibonacci()
        {

            Console.WriteLine("entrez une valeur strictement positif (>0)");
            int nb = int.Parse(Console.ReadLine());
            Console.WriteLine("le résulat est "+Fibonacci(nb));
        }

        static int NombreOccurrences(string s, char c)
        {
            int occ = 0;
            for(int i = 0; i < s.Length; i++)
            {
                if(s[i] == c)
                {
                    occ++;
                }
            }
            return occ;
        }

        static void TestNombreOccurences()
        {
            Console.WriteLine("entrez un mot (chaine de caractère) puis une lettre");
            string s = Console.ReadLine();
            char c = char.Parse(Console.ReadLine());
            Console.WriteLine(NombreOccurrences(s, c));
        }
        //besoin du pgcd
        static bool EstPremier(int value)
        {
            for (int i = 2; i < value; i++)
            {
                if ((value % i) == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void TestEstPremier()
        {
            Console.WriteLine("entrez un entier pour savoir s'il est premier");
            int c = int.Parse(Console.ReadLine());

            if (EstPremier(c) == true)
            {
                Console.WriteLine(c+" est premier");
            }
            else
            {
                Console.WriteLine(c + " n'est pas premier");
            }
        }

        static void EstPremierliste()
        {
            for (int i = 0; i < 100+1; i++)
            {
                if (EstPremier(i) == true)
                { Console.WriteLine(i + " est premier"); }
                else
                { Console.WriteLine(i + " n'est pas premier"); }
            }

        }

        static int PlusieursPremiers(int debut, int fin, bool affiche)//Exercice13
        {
            int cpt = 0;
            for (int i = debut; i < fin; i++)
            {
                if (EstPremier(i) == true)
                {
                    cpt++;
                    if (affiche == true) { 
                        Console.WriteLine(i + " est premier"); 
                    }
                }
            }
            return cpt;
        }

        static void TestPlusieursPremiers()
        {
            Console.WriteLine("Saisir deux entiers ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            string c;
            do
            {
                Console.WriteLine("Voulez vous afficher les nombre premiers (oui ou non) ? ");
                c = Console.ReadLine();
            } while (c != "oui" && c != "non");
            

            if (c == "oui")
            {
                bool d = true;
                Console.WriteLine("Il y a " + PlusieursPremiers(a, b, d)+" premiers entre "+a+" et "+b );
            }
            if(c=="non")
            {
                bool d = false;
                Console.WriteLine("Il y a " + PlusieursPremiers(a, b, d) + " premiers entre " + a + " et " + b);
            }
        }

        static bool EstPresent(string s, char c)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                {
                    return true;
                }
            }
            return false;
        }

        static void TestEstPresent()
        {
            Console.Write("Saisir un mot (chaine de caractère)");
            string s = Console.ReadLine();
            Console.Write("saisir un caractère");
            char c = char.Parse(Console.ReadLine());

            if (EstPresent(s, c) == true)
            { 
                Console.WriteLine(c+" est dans "+s); 
            }
            else { 
                Console.WriteLine(c+" n'est pas dans "+s); 
            }
        }
        static bool EstPalindrome(string s)
        {
            string inv = string.Empty;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                inv = inv+ s[i];
            }

            if (s == inv)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void TestEstPalindrome()
        {
            Console.WriteLine("saisir un mot (pour palindrome)");
            string s = Console.ReadLine();

            if (EstPalindrome(s) == true)
            { 
                Console.WriteLine(s+" est un palindrome");
            }
            else
            { 
                Console.WriteLine(s+" n'est pas un palindrome"); 
            }
        }

        static bool EstContenu(string s1, string s2)
        {
            bool b = s1.Contains(s2);

            if (b == true) { 
                return true; 
            }
            else 
            { 
                return false; 
            }

        }

        static void TestEstContenu()
        {
            Console.WriteLine("Entrez un mot ");
            string s1 = Console.ReadLine();
            Console.WriteLine("Entrez un deuxième mot ");
            string s2 = Console.ReadLine();

            if (EstContenu(s1, s2) == true) 
            { 
                Console.Write(s2+" est dans "+s1); 
            }
            else 
            { 
                Console.Write(s2+" n'est pas dans "+ s1); 
            }
        }

        static bool Debut(string s1, string s2)
        {
            string a = s1[0].ToString();
            string b = s2[0].ToString();

            if (a.ToLower() == b.ToLower())
            { 
                return true; 
            }
            else { 
                return false; 
            }
        }

        static void TestDebut()
        {
            Console.WriteLine("entrez un mot");
            string s1 = Console.ReadLine();
            Console.WriteLine("entrez un mot");
            string s2 = Console.ReadLine();

            if (Debut(s1, s2) == true) 
            { 
                Console.WriteLine(s1+" et"+s2+" commencent par la même lettre"); 
            }
            else 
            { 
                Console.WriteLine(s1+" et " +s2+" ne commencent pas par la même lettre"); 
            }
        }
        static string SousChaine(string s, int debut, int longueur)
        {
            string s1 = s.Substring(debut, longueur);
            return s1;
        }
        static void PartieChaine()
        {
            Console.WriteLine("entrez une chaîne de caractère (< 10 lettres)  ");
            string s = Console.ReadLine();

            Console.WriteLine("entrez le debut et la longueur ");
            int debut = int.Parse(Console.ReadLine());
            int longueur = int.Parse(Console.ReadLine());

            Console.WriteLine(SousChaine(s, debut, longueur));
        }
        static bool TailleEgale(string s1, string s2)
        {
            bool result = s1.Equals(s2);
            return result;
        }
        static void TesterTailleEgale()
        {
            Console.WriteLine("entrez un mot ");
            string s1 = Console.ReadLine();
            Console.WriteLine("Entrez un deuxième mot");
            string s2 = Console.ReadLine();

            if (TailleEgale(s1, s2) == true) 
            { 
                Console.WriteLine(s1+" et "+s2+" ont la même taille"); 
            }
            else 
            { 
                Console.WriteLine(s1+" et "+s2+" n'ont pas la même taille "); 
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(SaisiePositif());
            //TestEstPair();
            //TestEstStrictementPoditif();
            //TestPosNeg();
            //TestSommeElements();
            //TestEstMultiple();
            //TestEstPlusGrand();
            //TestEstBissextile();
            //TestFactorielle();
            //TestFibonacci();
            //TestNombreOccurences();
            //TestEstPremier();
            //EstPremierliste();
            //TestPlusieursPremiers();
            //TestEstPresent();
            //TestEstPalindrome();
            //TestEstContenu();
            //TestDebut();
            //PartieChaine();
            TesterTailleEgale();
            Console.ReadKey();
        }
    }
}
