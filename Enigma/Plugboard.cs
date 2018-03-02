using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaMachine
{
    // this class represents the plugboard of the enigma machine
    class Plugboard : Translator
    {
        public Plugboard(string LetterPairs) // the basic constructor uses a string to create a letter pairs
        {
            if ((LetterPairs.Length > 20) || (LetterPairs.Length % 2 != 0))
                throw new Exception("Letter Pairs String is Incorrect!"); // if the length of the string is not even or more than 10 pairs defined it is wrong
            LetterCheck(LetterPairs);

            char[] perm = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray(); // this is the permutation if no pairs are defined

            for (int i = 0; i < LetterPairs.Length; i += 2) // changes the basic permutation to include the letter pairs
            {
                perm[LetterToIndex(LetterPairs[i])] = LetterPairs[i + 1];
                perm[LetterToIndex(LetterPairs[i + 1])] = LetterPairs[i];
            }

            permutation = new string(perm);
            reverse = permutation; // the permutation of the plugboard is symmetric
        }
    }
}
