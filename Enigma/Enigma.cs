using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaMachine
{
    // This class is the enigma machine
    class Enigma : Substitutor
    {
        string[] rotors = { "EKMFLGDQVZNTOWYHXUSPAIBRCJ", // Storing the permutatiobs of the standard 5 rotors
                            "AJDKSIRUXBLHWTMCQGZNPYFVOE",
                            "BDFHJLCPRTXVZNYEIWGAKMUSQO",
                            "ESOVPZJAYQUIRHXLNFTGKDCMWB",
                            "VZBRGITYUPSDNHLXAWMJQOFECK" };

        int[] notches = { 'Q' - 'A' + 1, 'E' - 'A' + 1, 'V' - 'A' + 1, 'J' - 'A' + 1, 'Z' - 'A' + 1 };

        string reflectorPerm = "YRUHQSLDPXNGOKMIEBFZCWVJAT";

        public Rotor L, M, R; // define 3 rotors fo the machine
        public Plugboard Plug; // define the plugboard
        private Reflector reflector; // define the reflector

        public Enigma(int Rotor1, int Rotor2, int Rotor3)
        {
            L = new Rotor(rotors[Rotor1 - 1], notches[Rotor1 - 1]); // define the 3 rotors the machine has and the reflector
            M = new Rotor(rotors[Rotor2 - 1], notches[Rotor2 - 1]);
            R = new Rotor(rotors[Rotor3 - 1], notches[Rotor3 - 1]);
            reflector = new Reflector(reflectorPerm);
        }

        public string Translate(string source) // this function encodes/decodes a string
        {
            string result = "";
            for (int i = 0; i < source.Length; i++)
            {
                char translation = ForwardTranslation(source[i]);
                if (translation != ' ') result += translation;
            }
            return result;
        }

        public override char ForwardTranslation(char Letter) // this function encodes a single letter
        {
            if (Char.ToUpper(Letter) < 'A' || Char.ToUpper(Letter) > 'Z') return ' '; // checks if the input is alphabetic
            if (R.Notch() || M.Notch()) // checks notch position and advances the offset accordingly
            {
                if (M.Notch())
                    L.AdvanceOffset();
                M.AdvanceOffset();
            }
            R.AdvanceOffset();

            char result = Plug.ForwardTranslation(Letter);
            result = R.ForwardTranslation(result);
            result = M.ForwardTranslation(result);
            result = L.ForwardTranslation(result);
            result = reflector.ForwardTranslation(result);
            result = L.ReverseTranslation(result);
            result = M.ReverseTranslation(result);
            result = R.ReverseTranslation(result);
            return Plug.ReverseTranslation(result);
        }

        public override char ReverseTranslation(char Letter) // no need for reverse translation
        {
            return '\0';
        }
    }
}
