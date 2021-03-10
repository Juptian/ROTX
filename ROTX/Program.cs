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

        public static string Shift(char toShift, int shiftAmount)
        {
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            
            int indexOf = Array.IndexOf( alphabet, Convert.ToChar( toShift.ToString().ToLower() ) );
            char result = new char();
            
            while(shiftAmount >= 26)
            {
                shiftAmount -= 26;
            }

            if ((indexOf - shiftAmount) < 0)
            {
                result = alphabet[indexOf - shiftAmount + 20];
            }
            else
            {
                result = alphabet[indexOf - shiftAmount];
            }
            if ( toShift.ToString() == toShift.ToString().ToUpper() )
                return result.ToString().ToUpper();
            else
                return result.ToString().ToLower();
        }

        public static bool GameLoop()
        {
            Console.WriteLine("Input the string you would like to convert");
            char[] input = Console.ReadLine().ToCharArray();

            Console.WriteLine("Input the value you would like to shift your input by");
            shiftAmount = Convert.ToInt32( Console.ReadLine() );


            string[] outputArr = new string[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                outputArr[i] = Shift(input[i], shiftAmount);
            }
            string output = String.Join("", outputArr);
            Console.WriteLine($"The output is: {output}");


            /*foreach (string s in outputArr)
            {
                Console.Write($"{s}");
            }*/
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
