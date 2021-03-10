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
            char result = new char();
            int a = Array.IndexOf(alphabet, Convert.ToChar(toShift.ToString().ToLower()));
            
            if ((a - shiftAmount) < 0) {
                Console.WriteLine(alphabet[a + shiftAmount]);
                result = alphabet[a + shiftAmount];
            } 
            else
            {
                result = alphabet[a - shiftAmount];
            }

            //hehe I'm dumb ignore this
            /*Console.WriteLine(toShift.ToString().ToUpper());
            int convertIndex = Array.IndexOf(alphabet, toShift.ToString().ToUpper());

            if (convertIndex - shiftAmount < 0)
            {
                Console.WriteLine($"{convertIndex}, ${shiftAmount}");
                result = alphabet[convertIndex + Math.Abs(convertIndex - shiftAmount)];
            } else
            {
                result = alphabet[convertIndex - shiftAmount];
            }

            if(toShift.ToString().ToLower() == toShift.ToString().ToLower())
            {
                result = result.ToLower();
            }*/
            if (toShift.ToString() == toShift.ToString().ToUpper())
                return result.ToString().ToUpper();
            else
                return result.ToString();
        }
        public static bool GameLoop()
        {
            Console.WriteLine("Input the string you would like to convert");
            char[] input = Console.ReadLine().ToCharArray();

            Console.WriteLine("Input the value you would like to shift your input by");
            shiftAmount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(shiftAmount);

            string[] outputArr = new string[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                outputArr[i] = Shift(input[i], shiftAmount);
            }

            Console.WriteLine("The output is: ");

            foreach (string s in outputArr)
            {
                Console.Write($"{s}");
            }

            Console.WriteLine("Would you like to go again? (y/n)");
            string goAgain = Console.ReadLine();
            while(true)
            {
                if (goAgain.ToUpper() == "YES" || goAgain.ToUpper() == "Y")
                {
                    return true;
                } else if (goAgain.ToUpper() == "NO" || goAgain.ToUpper() == "N")
                {
                    return false;
                } else
                {
                    Console.WriteLine("Please write either y, n, or yes, no.");
                    Console.WriteLine("Case is being ignored");
                    goAgain = Console.ReadLine();
                }
            }
        }
    }
}
