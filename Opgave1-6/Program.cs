using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //opgave 2
            /*
            Console.WriteLine("skriv dit tal: ");
            string str = Console.ReadLine();
            int i = Int32.Parse(str);
            int output = 0;

            do
            {
                i = i / 2;
                output++;

            } while (i >= 2);
            Console.WriteLine(output);
            Console.ReadKey();
            */

            //opgave 3
            /*
            Console.WriteLine("Skriv en sætning, ord eller andet");
            string str = Console.ReadLine();
            
            Console.WriteLine("Skriv hvor mange gange den skal gentages");
            string stri = Console.ReadLine();
            int tal = Int32.Parse(stri);
            Console.Clear();
            do
            {

                Console.WriteLine(str);
                tal--;
                
            } while (tal > 0);
            Console.ReadKey();
            */

            //opgave 4
            /*
            Console.WriteLine("skriv et tal som du vil have faktualiteten på");
            string str = Console.ReadLine();
            int tal = Int32.Parse(str);
            int tal2 = tal - 1;
            int resultat = 1;
            Console.ReadKey();
            Console.Clear();
            do
            {
                if (tal == 1)
                {
                    resultat = resultat * tal;
                    Console.Write(tal + " = ");
                }
                else
                {
                    resultat = resultat * tal;
                    Console.Write(tal + " * ");
                }
                tal--;
            } while (tal > 0);
            Console.WriteLine(resultat);
            Console.ReadKey();
            */

            //opgave 5
            /*
            Console.WriteLine("skriv et tal");
            string str = Console.ReadLine();
            int tal = Int32.Parse(str);
            Console.WriteLine("skriv et tal mere");
            string str2 = Console.ReadLine();
            int tal2 = Int32.Parse(str2);
            Console.WriteLine();
            if (tal > tal2)
            {
                Console.WriteLine(tal + " er større end " + tal2);
            }
            else if (tal < tal2)
            {
                Console.WriteLine(tal2 + " er større end " + tal);
            }
            else
            {
                Console.WriteLine("begge tal er lige store");
            }
            Console.ReadKey();
            */

            //opgave 6
            /*
            Console.WriteLine("Skriv hvor mange gange den skal gentages");
            string str = Console.ReadLine();
            int antal = Int32.Parse(str);
            int divider = antal;
            int sum = 0;
            int resultat = 0;
            Console.WriteLine();
            do
            {

                string str1 = Console.ReadLine();
                sum = Int32.Parse(str1) + sum;


                antal--;
            } while (antal > 0);
            Console.WriteLine();
            Console.WriteLine("summen er " + sum);

            resultat = sum / divider;
            Console.WriteLine("gennemsnittet af " + sum + " er " + resultat);

            Console.ReadKey();
            */

            //opgave 7
            /*
            for (int i = 1; i < 11; i++)
            {
                for (int x = 1; x < 11; x++)
                {
                    int resultat = i * x;
                    Console.Write(resultat.ToString().PadLeft(4));
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            */

            //opgave 8
            /*
            int stop = 2;
            do
            {
                Console.WriteLine("skriv det tal som du vil haves tabel");
                string str = Console.ReadLine();
                int tal = Int32.Parse(str);
                for (int i = 1; i <= 10; i++)
                {
                    int resultat = i * tal;
                    Console.Write(resultat.ToString().PadLeft(4));
                }

                Console.WriteLine();
                Console.WriteLine("skriv 2 for at prøve igen og skriv 1 for at stoppe");


                string str1 = Console.ReadLine();
                stop = stop = Int32.Parse(str1);
            } while (stop == 2);
            */

            //opgave 9
            /*
            int tal1 = 0;
            int tal2 = 0;
            int resultat = 0;
            string svar;

            do
            {

                Console.WriteLine("skriv dit første tal");
                string str = Console.ReadLine();
                tal1 = Int32.Parse(str);
                Console.WriteLine("vælg mellem +, -, * og /");
                string str1 = Console.ReadLine();
                Console.WriteLine("skriv det næste tal");
                string str2 = Console.ReadLine();
                tal2 = Int32.Parse(str2);

                if (str1 == "+")
                {
                    resultat = tal1 + tal2;
                    Console.WriteLine("resultat = " + resultat);
                }
                else if (str1 == "-")
                {
                    resultat = tal1 - tal2;
                    Console.WriteLine("resultat = " + resultat);
                }
                else if (str1 == "*")
                {
                    resultat = tal1 * tal2;
                    Console.WriteLine("resultat = " + resultat);
                }
                else if (str1 == "/")
                {
                    resultat = tal1 / tal2;
                    Console.WriteLine("resultat = " + resultat);
                }

                Console.WriteLine("vil du prøve igen J/N");
                svar = Console.ReadLine();


            }while(svar == "J" || svar == "j");
            */

            //opgave 10
            /*
            int tal1 = 0;
            int tal2 = 0;
            int resultat = 0;
            string svar;

            do
            {

                Console.WriteLine("skriv dit første tal");
                string str = Console.ReadLine();
                tal1 = Int32.Parse(str);
                Console.WriteLine("vælg mellem +, -, * og /");
                string str1 = Console.ReadLine();
                Console.WriteLine("skriv det næste tal");
                string str2 = Console.ReadLine();
                tal2 = Int32.Parse(str2);

                switch (str1)
                {
                    case ("+"):
                        resultat = tal1 + tal2;
                        break;
                    case ("-"):
                        resultat = tal1 - tal2;
                        break;
                    case ("*"):
                        resultat = tal1 * tal2;
                        break;
                    case ("/"):
                        resultat = tal1 / tal2;
                        break;
                }
                Console.WriteLine("resultat = " + resultat);

                Console.WriteLine("vil du prøve igen J/N");
                svar = Console.ReadLine();


            } while (svar == "J" || svar == "j");
            */
        }
     }
}
