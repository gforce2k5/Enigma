using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnigmaMachine
{
    // The main abstract class which all of the other classes derives from
    abstract class Substitutor
    {
        protected int LetterToIndex(char Letter) // returns a number which represents the letter
        {
            return (Char.ToUpper(Letter) - 'A') % 26;
        }

        protected char IndexToLetter(int index) // returns a letter which is represented by the number
        {
            if (index < 0) index += 26;
            if (index > 25) index -= 26;
            return (char)(index + 'A');
        }

        protected void LetterCheck(string Permutation) // checks wether the permutation is valid (no letter appears more than once)
        {
            int[] letterFreq = new int[26];
            for (int i = 0; i < Permutation.Length; i++)
            {
                int index = LetterToIndex(Permutation[i]);
                letterFreq[index]++;
                if (letterFreq[index] > 1) throw new Exception("Letter cannot appear twice in permutation or letterpairs");
                if (Char.ToUpper(Permutation[i]) < 'A' || Char.ToUpper(Permutation[i]) > 'Z')
                    throw new Exception("Only letters can be part of letter pairs!");
            }
        }

        public abstract char ForwardTranslation(char Letter); // abstratct forward translation method

        public abstract char ReverseTranslation(char Letter); // abstract reverse translation method
    }
}
