using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // saisie de la hauteur du sapin 
            Console.Write("Choisissez la taille de votre sapin entre 0 et 30 : ");
            int hauteurSapin = int.Parse(Console.ReadLine());

            // contrôle de saisie de la hauteur du sapin + ajouter le contrôle de saisie de caractères 
            while (hauteurSapin < 0 || hauteurSapin > 30)
            { Console.WriteLine("Merci de saisir une hauteur comprise entre 1 et 30"); }
            Console.Clear();

            int nombreFeuilles = 0;
            string rangFeuilles;
            int largeurMax = 120;
            int posInitiale = largeurMax / 2;
            Random boule = new Random();
            int proba = boule.Next(1, 10);


            int DessinerFeuilles(int hauteurSapin)
            {
                for (int i = 0; i < hauteurSapin; i++)
                {
                    Console.SetCursorPosition((posInitiale - i), i + 2);
                    nombreFeuilles = (2 * i) + 1;
                    rangFeuilles = new string('\u002A', nombreFeuilles);

                    Console.WriteLine(rangFeuilles);
                }

                Console.SetCursorPosition((posInitiale - 1), hauteurSapin + 2);
                Console.WriteLine("|||");

                return nombreFeuilles;
            }

            DessinerFeuilles(hauteurSapin);

        }
    }
    }