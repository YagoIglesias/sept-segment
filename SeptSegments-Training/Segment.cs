/// ETML
/// Auteur : Yago Iglesias Rodriguez
/// Date : 13.02.2024
/// Description : Classe qui va activer ou desactiver les segments nécessaires pour afficher le chiffre

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeptSegments_Training
{
    internal class Segment
    {
        // variables A - G 
        /// <summary>
        /// segment A 
        /// </summary>
        private char _a = '-';
        /// <summary>
        /// segment B
        /// </summary>
        private char _b = '|';
        /// <summary>
        /// segment C
        /// </summary>
        private char _c = '|';
        /// <summary>
        /// segment D
        /// </summary>
        private char _d = '-';
        /// <summary>
        /// segment E
        /// </summary>
        private char _e = '|';
        /// <summary>
        /// segment F
        /// </summary>
        private char _f = '|';
        /// <summary>
        /// segment G
        /// </summary>
        private char _g = '-';

        /// <summary>
        /// dp du sept segment
        /// </summary>
        private char _dp = '°';

        /// <summary>
        /// méthode pour recuperer le segment A
        /// </summary>
        /// <returns name = "_a"> segment a </returns>
        public char GetSegmentA() 
        {  
            
            return _a; 
        }

        /// <summary>
        /// méthode pour recuperer le segment B
        /// </summary>
        /// <returns name = "_b"> segment b </returns>
        public char GetSegmentB() 
        { 
            
            return _b; 
        }

        /// <summary>
        /// méthode pour recuperer le segment C
        /// </summary>
        /// <returns name "_c"> segment c </returns>
        public char GetSegmentC() 
        { 
            return _c; 
        }

        /// <summary>
        /// méthode pour recuperer le segment D
        /// </summary>
        /// <returns name "_d"> segment b </returns>
        public char GetSegmentD() 
        { 
            return _d;
        }

        /// <summary>
        /// méthode pour recuperer le segment E
        /// </summary>
        /// <returns name = "_e"> segment e </returns>
        public char GetSegmentE() 
        { 
            return _e;
        }

        /// <summary>
        /// méthode pour recuperer le segment F
        /// </summary>
        /// <returns name = "_f"> segment f </returns>
        public char GetSegmentF() 
        { 
            return _f;
        }

        /// <summary>
        /// méthode pour recuperer le segment G
        /// </summary>
        /// <returns name = "_g"> segment g </returns>
        public char GetSegmentG() 
        { 
            return _g;
        }

        /// <summary>
        /// méthode pour afficher le dp
        /// </summary>
        /// <returns name " _dp"> segment dp </returns>
        public char GetSegmentDp() 
        { 
            return _dp;
        }



    }
}
