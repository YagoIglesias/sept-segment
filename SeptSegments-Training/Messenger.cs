/// ETML
/// Auteur : Yago Iglesias Rodriguez
/// Date : 13.02.2024
/// Description : Classe qui permet de créer l'object sept segment

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace SeptSegments_Training
{
    internal class Messenger
    {


        public Messenger() 
        {
            

        }
        
        /// <summary>
        /// méthode pour afficher le chiffre 
        /// </summary>
        /// <param name="selectedNumber"> numero à afficher </param>
        public void Display(int selectedNumber)
        {
            Segment sevenDisplay = new Segment();

            switch (selectedNumber)
            {
                case 0:
                    
                    Console.WriteLine(" " + " " + sevenDisplay.GetSegmentA() + sevenDisplay.GetSegmentA());
                    Console.Write(" " + sevenDisplay.GetSegmentF() + " ");
                    Console.WriteLine(" " + sevenDisplay.GetSegmentB());
                    Console.WriteLine();
                    Console.Write(" " + sevenDisplay.GetSegmentE() + " ");
                    Console.WriteLine(" " + sevenDisplay.GetSegmentC());
                    Console.Write(" " + " " + sevenDisplay.GetSegmentD() + sevenDisplay.GetSegmentD() + " " + " ");
                    break; 

                case 1:
                    Console.WriteLine(" " + sevenDisplay.GetSegmentF());
                    Console.Write(" " + sevenDisplay.GetSegmentE() + " " + " ");
                    break;

                case 2:
                    Console.WriteLine(" " + " " + sevenDisplay.GetSegmentA() + sevenDisplay.GetSegmentA());
                    Console.Write(" " + " " + " ");
                    Console.WriteLine(" " + sevenDisplay.GetSegmentB());
                    Console.WriteLine(" " + " " + sevenDisplay.GetSegmentG() + sevenDisplay.GetSegmentG());
                    Console.WriteLine(" " + sevenDisplay.GetSegmentE());
                    Console.Write(" " + " " + sevenDisplay.GetSegmentD() + sevenDisplay.GetSegmentD() + " " + " ");
                    break;

                case 3:
                    Console.WriteLine(" " + " " + sevenDisplay.GetSegmentA() + sevenDisplay.GetSegmentA());
                    Console.Write(" " + " " + " ");
                    Console.WriteLine(" " + sevenDisplay.GetSegmentB());
                    Console.WriteLine(" " + " " + sevenDisplay.GetSegmentG() + sevenDisplay.GetSegmentG());
                    Console.Write(" " + " " + " ");
                    Console.WriteLine(" " + sevenDisplay.GetSegmentC());
                    Console.Write(" " + " " + sevenDisplay.GetSegmentD() + sevenDisplay.GetSegmentD() + " " + " ");
                    break;

                case 4:
                    Console.WriteLine();
                    Console.Write(" " + sevenDisplay.GetSegmentF() + " ");
                    Console.WriteLine(" " + sevenDisplay.GetSegmentB());
                    Console.WriteLine(" " + " " + sevenDisplay.GetSegmentG() + sevenDisplay.GetSegmentG());
                    Console.Write(" " + " " + " ");
                    Console.Write(" " + sevenDisplay.GetSegmentC() + " " + " ");
                    break;

                case 5:
                    Console.WriteLine(" " + " " + sevenDisplay.GetSegmentA() + sevenDisplay.GetSegmentA());
                    Console.WriteLine(" " + sevenDisplay.GetSegmentF());
                    Console.WriteLine(" " + " " + sevenDisplay.GetSegmentG() + sevenDisplay.GetSegmentG());
                    Console.WriteLine(" " + " " + " " + " " + sevenDisplay.GetSegmentC());
                    Console.Write(" " + " " + sevenDisplay.GetSegmentD() + sevenDisplay.GetSegmentD() + " " + " ");
                    break;

                case 6:
                    Console.WriteLine();
                    Console.WriteLine(" " + sevenDisplay.GetSegmentF());
                    Console.WriteLine(" " + " " + sevenDisplay.GetSegmentG() + sevenDisplay.GetSegmentG());
                    Console.Write(" " + sevenDisplay.GetSegmentE() + " ");
                    Console.WriteLine(" " + sevenDisplay.GetSegmentC());
                    Console.Write(" " + " " + sevenDisplay.GetSegmentD() + sevenDisplay.GetSegmentD() + " " + " ");
                    break;

                case 7:
                    Console.WriteLine(" " + sevenDisplay.GetSegmentA() + sevenDisplay.GetSegmentA());
                    Console.WriteLine(" " + " " + " " + sevenDisplay.GetSegmentB());
                    Console.Write(" " + " " + " " + sevenDisplay.GetSegmentC() + " " + " ");
                    break;

                case 8:
                    Console.WriteLine(" " + " " + sevenDisplay.GetSegmentA() + sevenDisplay.GetSegmentA());
                    Console.Write(" " + sevenDisplay.GetSegmentF() + " ");
                    Console.WriteLine(" " + sevenDisplay.GetSegmentB());
                    Console.WriteLine(" " + " " + sevenDisplay.GetSegmentG() + sevenDisplay.GetSegmentG());
                    Console.Write(" " + sevenDisplay.GetSegmentE() + " ");
                    Console.WriteLine(" " + sevenDisplay.GetSegmentC());
                    Console.Write(" " + " " + sevenDisplay.GetSegmentD() + sevenDisplay.GetSegmentD() + " " + " ");
                    break;

                case 9:
                    Console.WriteLine(" " + " " + sevenDisplay.GetSegmentA() + sevenDisplay.GetSegmentA());
                    Console.Write(" " + sevenDisplay.GetSegmentF() + " ");
                    Console.WriteLine(" " + sevenDisplay.GetSegmentB());
                    Console.WriteLine(" " + " " + sevenDisplay.GetSegmentG() + sevenDisplay.GetSegmentG());
                    Console.Write(" " + " " + " ");
                    Console.WriteLine(" " + sevenDisplay.GetSegmentC());
                    Console.Write(" " + " " + sevenDisplay.GetSegmentD() + sevenDisplay.GetSegmentD() + " " + " ");
                    break;

                default:
                    Console.WriteLine("Uniquement des chiffres de 0 à 9 ");
                    break;
            }
        }

        /// <summary>
        /// méthode pour afficher ou pas afficher le DP
        /// </summary>
        /// <param name="dp"></param>
        public void DisplayDot(bool dp) 
        {
            if (dp == true)
            {
                Segment dot = new Segment();
                Console.WriteLine(dot.GetSegmentDp());
            }
            else
            {

            }
        }


    }
}
