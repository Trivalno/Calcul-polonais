using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Température
{
    class Program
    {
        static void Main(string[] args)
        {
            //déclaration
            int nbsup=0, taille=6;

            //tableau des température 
            float[] t = new float[taille];

            //saise des temp
            float moyenne = 0;
            for (int k = 1; k < taille; k++)
            {
                Console.WriteLine("Entrez la température n° " + k);
                t [k] = float.Parse(Console.ReadLine());
                moyenne += t[k];
            }
            //calcul de la moyenne
            moyenne = moyenne / taille;

            //Calcul du nombre de température au dessus de la moyenne 
            for(int k=0; k<taille; k++)
            {
                if(t[k] > moyenne)
                {
                    nbsup++;
                }
            }

            //affichage du résultat
            Console.WriteLine("Le nombre de température supérieur a la moyenne est de "+nbsup);

            Console.ReadLine();
            
        }
    }
}
