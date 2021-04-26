using System;

namespace String_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine( $"No of occurences is {NumarOfOccurences("This test is a test", "test")}");

            Console.WriteLine(string.Format("{0,-15}{1,-5}{2,7}{3,7}{4,7}",
                "Produs",
                "UM",
                "Pret",
                "Cant",
                "Total"));
            PrintProductLine("Paine", "buc",4,1);
            PrintProductLine("Cafea", "buc", 7, 2);

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

        private static void GetReverseString_And_CheckIPalindrome()
        {
            string original = "Hello";
            string reversed = Reverse(original);
            Console.WriteLine($"Original: {original}");
            Console.WriteLine($"Reversed: {reversed}");

            bool isPalindrome = IsPalindrome(original);
            Console.WriteLine($"is {original} a palindrome: {isPalindrome}");
        }

        private static int NumarOfOccurences(string text, string substring)
        {
            if (text is null)
            {
                return 0;
            }
            if (string.IsNullOrEmpty(substring))
            {
                return 0;
            }

            int nrOfOccurences = 0;

            bool endOfText = false;
            int indexStart = 0;

            while (!endOfText)
            {
                int foundAtIndex = text.IndexOf(substring, indexStart, StringComparison.OrdinalIgnoreCase);
                if (text.IndexOf(substring,indexStart, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    nrOfOccurences++;
                    indexStart = foundAtIndex+substring.Length;
                }
                else
                {
                    endOfText = true;
                }
            }
            return nrOfOccurences;
        }

        private static void Substring()
        {
            string text = "This is a test and another test";
            string substring = text.Substring(5, 2);

            Console.WriteLine(substring);
        }

        private static void StringJoin()
        {
            string text = string.Concat("This", " is ", "a longer string");
            //="This"+" is "+"a longer string"
            string text2 = string.Join(',', new string[] { "a", "b", "c" });
            Console.Write(text2);
            //output a,b,c
        }

        private static void IsNullOrWhiteSpace()
        {
            Console.WriteLine(string.IsNullOrEmpty(null));
            Console.WriteLine(string.IsNullOrEmpty(""));
            Console.WriteLine(string.IsNullOrEmpty("   "));

            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine(string.IsNullOrWhiteSpace(null));
            Console.WriteLine(string.IsNullOrWhiteSpace(""));
            Console.WriteLine(string.IsNullOrWhiteSpace("   "));

            //string.Empty better than ""
        }

        private static void PrintProductLine(string productName, string um, float price, float quantity)
        {
            float total = price * quantity;
            //string line = productName + um + price + quantity;
            string line = string.Format("{0,-15}{1,-5}{2,7:C}{3,7}{4,7:C}",
                productName,
                um,
                price,
                quantity,
                total);
            Console.WriteLine(line);
        }
    }
}
