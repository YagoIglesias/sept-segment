/// ETML
/// Auteur : Yago Iglesias Rodriguez
/// Date : 13.02.2024
/// Description : Programme pour afficher un  sept segments avec le chiffre choisi par l'utilisateur

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeptSegments_Training
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creation d'un sept segments 
            Messenger sevenDisplayMessenger = new Messenger();
            // afficher le 5
            sevenDisplayMessenger.Display(5);
            // afficher DP
            sevenDisplayMessenger.DisplayDot(true);

            // pas fermer la console pour voir le resultat
            Console.ReadLine();


        }
    }
}
