using System;
using System.Text;

namespace StringCompression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the sentence");
            string sentence = Console.ReadLine();
            Console.WriteLine(StringCompression(sentence));
            Console.ReadLine();
        }

        static string StringCompression(string sentence)
        {
            int CountRepeats = 0;
            char[] Chars = sentence.ToCharArray();
            StringBuilder Result = new StringBuilder();

            for(int i=0; i<sentence.Length; i++)
            {
                ++CountRepeats;
                if ((i+1) >= sentence.Length || Chars[i] != Chars[i + 1])
                {
                    Result.Append(Chars[i].ToString() + CountRepeats);
                    CountRepeats = 0;
                }
            }

            return Result.ToString();
        }
    }
}
