using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnigmaMachine
{
    // This class handles all the translations in the enigma machine
    abstract class Translator : Substitutor
    {
        protected string permutation; // a string to store the permutation
        protected string reverse; // a string to store the reverse permutation

        protected Translator(string Permutation) // creates a new translator with the permutation given
        {
            if (Permutation.Length != 26) throw new Exception("Permutation string length is not 26"); // checks the length of the permuation
            LetterCheck(Permutation);
            permutation = Permutation;
            reverse = ReversePerm(Permutation);
        }

        protected string ReversePerm(string Permutation) // automatically creates a reverse permutation from the given permutation
        {
            char[] rev = new char[Permutation.Length];
            for (int i = 0; i < 26; i++)
            {
                rev[LetterToIndex(Permutation[i])] = IndexToLetter(i);
            }
            return new string(rev);
        }

        protected Translator() // an empty constructor for translator
        {
        }

        public override char ForwardTranslation(char Letter)
        {
            return permutation[LetterToIndex(Letter)];
        }

        public override char ReverseTranslation(char Letter)
        {
            return reverse[LetterToIndex(Letter)];
        }
    }
}
