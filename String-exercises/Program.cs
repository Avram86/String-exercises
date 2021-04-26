using System;

namespace String_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //string original = "Hello";
            //string reversed=Reverse(original);
            //Console.WriteLine($"Original: {original}");
            //Console.WriteLine($"Reversed: {reversed}");

            bool isPalindrome = IsPalindrome("Hello");
            Console.WriteLine($"is Hello a palindrome: {isPalindrome}");
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
                char c = text[i];

                //verificam daca este cifra
                //bool isDigit = char.IsDigit(c);


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

        private static bool IsNumber(string text)
        {
            /*considerand un text dat, intoarcem un flag care ne spune daca textul e numar sau nu*/

            bool isNumber =int.TryParse(text, out int result);
            //eroare daca textul depaseste int.maxValue
            //varianta:
            //bool isNumber =long.TryParse(text, out long result);


            foreach (char c in text)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return false;
        }
        private static void ReadNumber(string label ,int maxAttempts, int defaultValue)
        {
            /*Read a text from console, and validate that it is a number
             If not a number, repeat read(maxAttempts count)
            If maxAttempts exceeded, return default*/

            Console.Write(label);
            string text = Console.ReadLine();
            bool isNumber = IsNumber(text);

            
        }

        private static string Reverse(string text)
        {
            char[] reversed = new char[text.Length];

            for(int i = 0; i < text.Length; i++)
            {
                reversed[i] = text[text.Length - 1 - i];
            }

            //foreach(var c in reversed)
            //{
            //    Console.Write(c);
            //}

            //return reversed.ToString();
            return new string(reversed);
        }

        private static bool IsPalindrome(string text)
        {
            string reversed = Reverse(text);
            bool isPalindrome = string.Equals(text, reversed, StringComparison.OrdinalIgnoreCase);
            return isPalindrome;
        }
    }
}
