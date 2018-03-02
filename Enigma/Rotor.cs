using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaMachine
{
    // this class defines the rotor of the enigma machine
    class Rotor : Translator
    {
        int offset; // the offset of the rotor (ground setting)
        int ringSetting; // the ring setting of the rotor
        int notch; // the position of the notch

        public int Offset
        {
            get { return offset; }
            set { offset = value; }
        }

        public int RingSetting
        {
            get { return ringSetting; }
            set { ringSetting = value; }
        }

        public Rotor(string Permutation, int Notch) : base(Permutation)
        {
            ringSetting = RingSetting;
            notch = Notch;
        }

        public void AdvanceOffset() // advances the offset
        {
            offset++;
            if (offset > 26) offset -= 26;
        }
        public override char ForwardTranslation(char Letter) // forward translation through the rotor
        {
            return IndexToLetter(LetterToIndex(base.ForwardTranslation(IndexToLetter(LetterToIndex(Letter) + offset - ringSetting))) - offset + ringSetting);
        }

        public override char ReverseTranslation(char Letter) // reverse translation through the rotor
        {
            return IndexToLetter(LetterToIndex(base.ReverseTranslation(IndexToLetter(LetterToIndex(Letter) + offset - ringSetting))) - offset + ringSetting);
        }

        public bool Notch() // returs true if the rotor is at the notch position
        {
            return notch == offset;
        }
    }
}
