using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnigmaMachine
{
    // this class defines the reflector
    class Reflector : Translator
    {
        public Reflector(string Permutation)
        {
            LetterCheck(Permutation); // checks the validity of the permutation
            char[] s = Permutation.ToCharArray();
            char[] r = ReversePerm(Permutation).ToCharArray();

            for (int i = 0; i < s.Length; i++)
                if (s[i] != r[i]) // checks wether the permutation is symmetric
                    throw new Exception("Reflector permutation string is not symmetric!");

            permutation = Permutation;
            reverse = new string(r);
        }
    }
}
