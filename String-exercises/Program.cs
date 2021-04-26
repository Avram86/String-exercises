using System;

namespace String_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            CountVowels();
        }

        private static void CountVowels()
        {
            /*
             citim un string de la tastatura
            cate vocale are stringul*/

            Console.Write("Please enter the text: ");
            string text = Console.ReadLine();
            text = text.ToUpper();

            int nrVocale = 0;

            for(int i = 0; i < text.Length; i++)
            {
                switch (text[i])
                {
                    case 'A':
                        nrVocale++;
                        break;
                    case 'E':
                        nrVocale++;
                        break;
                    case 'I':
                        nrVocale++;
                        break;
                    case 'O':
                        nrVocale++;
                        break;
                    case 'U':
                        nrVocale++;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"Nr de vocale din text este de : {nrVocale}");

        }
    }
}
