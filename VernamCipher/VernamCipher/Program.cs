using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VernamCipher
{
    class Program
    {
        private static readonly Random getrandom = new Random();
        private static readonly object syncLock = new object();
        public static int GetRandomNumber(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return getrandom.Next(min, max);
            }
        }

        static void Main(string[] args)
        {
            string ciphertext = "";
            string plaintext = "";
            char cipherchar;
            int cipherascii;
            //string key = "the quick brown fox jumped over the lazy dog";

            string key = "";

            Console.WriteLine("Please enter a message and press enter to encrypt it:");
            plaintext = Console.ReadLine();

            //add option to change the key

            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"me.cipherkey"))
            {
                for (int i = 0; i < plaintext.Length + 1; i++)
                {
                    key += (char)GetRandomNumber(0, 255);
                }
                file.Write(key);
            }

            //check the size of the key (it should be the same size or bigger than the plaintext
            Console.WriteLine("Your plain text was:");
            Console.WriteLine(plaintext);

            int[] asciiValues = new int[plaintext.Length];

            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"me.cipher"))
            {
                for (int charpos = 0; charpos < plaintext.Length; charpos++)
                {
                    cipherascii = plaintext[charpos] ^ key[charpos]; // ^ is the xor character in C#
                    cipherchar = (char)cipherascii; // this is casting, it changes cipherascii to a char for this line only
                    asciiValues[charpos] = cipherascii;
                    ciphertext = ciphertext + cipherchar;
                    Console.WriteLine("plain: " + plaintext[charpos]);
                    Console.WriteLine("key: " + key[charpos]);
                    Console.WriteLine("cipher: " + cipherascii);

                    file.Write((char)cipherascii);
                }
            }

            Console.WriteLine("Your cipher text is:");
            Console.WriteLine(ciphertext);
            Console.WriteLine("Or as ascii values:");
            for (int value = 0; value < ciphertext.Length; value++)
            {
                Console.WriteLine(asciiValues[value]);
            }

            string text = System.IO.File.ReadAllText(@"me.cipher");

            string newStr = "";
            for (int charpos = 0; charpos < plaintext.Length; charpos++)
            {
                cipherascii = text[charpos] ^ key[charpos]; // ^ is the xor character in C#
                cipherchar = (char)cipherascii; // this is casting, it changes cipherascii to a char for this line only
                asciiValues[charpos] = cipherascii;
                newStr = newStr + cipherchar;
            }

            Console.WriteLine(newStr);

            //add the code to decrypt

            Console.ReadLine();
        }
    }
}