using System;

namespace ROTX
{
    class Program
    {
        private static int shiftAmount = 13;
        private static void Main(string[] args)
        {
            while (GameLoop())
            { }

            Console.WriteLine("Thank you for using ROTX");
            Console.ReadLine();
        }

        public static char Shift(char toShift, int shiftAmount)
        {
            if(shiftAmount == 0) { return toShift; }
            if(toShift == ' ') { return ' '; }

            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            
            int indexOf = alphabet.IndexOf( Char.ToLower(toShift) );
            char result;

            shiftAmount %= 26;
#if false
            if ( (indexOf - shiftAmount) < 0)
            {
                result = alphabet[20 + (indexOf - shiftAmount) ];
            } 
            else
            {
                result = alphabet[indexOf - shiftAmount];
            }
#endif

            if( indexOf + shiftAmount < 26)
            {
                result = alphabet[indexOf + shiftAmount];
            } 
            else
            {
                result = alphabet[indexOf + shiftAmount - 26];
            }

            return char.IsUpper(toShift) ? char.ToUpper(result) : char.ToLower(result);
        }

        public static bool GameLoop()
        {
            Console.WriteLine("Input the string you would like to convert");
            Console.WriteLine("abcdefghijklmnopqrstuvwxyz");
            char[] input = Console.ReadLine().ToCharArray();

            Console.WriteLine("Input the value you would like to shift your input by");
            shiftAmount = Convert.ToInt32( Console.ReadLine() );


            char[] outputArr = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                outputArr[i] = Shift(input[i], shiftAmount);
            }
            string output = String.Join("", outputArr);
            Console.WriteLine($"The output is: {output}");
            
            Console.WriteLine();
            Console.Write("Would you like to go again? (y/n): ");
            string goAgain = Console.ReadLine();
            while(true)
            {
                if (goAgain.ToUpper() == "YES" || goAgain.ToUpper() == "Y")
                {
                    return true;
                } else if (goAgain.ToUpper() == "NO" || goAgain.ToUpper() == "N")
                {
                    return false;
                } 
                else
                {
                    Console.WriteLine("Please write either y, n, or yes, no.");
                    Console.WriteLine("Case is being ignored");
                    goAgain = Console.ReadLine();
                }
            }
        }
    }
}
