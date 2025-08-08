using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersToWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number (0-999): ");
            int number = int.Parse(Console.ReadLine());

            if (number < 0 || number > 999)
            {
                Console.WriteLine("Number out of range.");
                return;
            }
            if (number == 0)
            {
                Console.WriteLine("Zero");
                return;
            }
            string result = ConvertNumberToWords(number);
            Console.WriteLine(result.Trim());
        }
        static string ConvertNumberToWords(int num)
        {
            string words = "";

            // Handle hundreds place
            if (num >= 100)
            {
                int hundreds = num / 100;
                words += GetUnitsWord(hundreds) + " Hundred ";
                num %= 100;
            }
            // Handle tens and units
            if (num > 0)
            {
                if (num < 20)
                {
                    words += GetUnitsWord(num);
                }
                else
                {
                    int tens = num / 10;
                    words += GetTensWord(tens);
                    int units = num % 10;
                    if (units != 0)
                    {
                        words += " " + GetUnitsWord(units);
                    }
                }
            }
            return words;
        }
        static string GetUnitsWord(int num)
        {
            switch (num)
            {
                case 1: return "One";
                case 2: return "Two";
                case 3: return "Three";
                case 4: return "Four";
                case 5: return "Five";
                case 6: return "Six";
                case 7: return "Seven";
                case 8: return "Eight";
                case 9: return "Nine";
                case 10: return "Ten";
                case 11: return "Eleven";
                case 12: return "Twelve";
                case 13: return "Thirteen";
                case 14: return "Fourteen";
                case 15: return "Fifteen";
                case 16: return "Sixteen";
                case 17: return "Seventeen";
                case 18: return "Eighteen";
                case 19: return "Nineteen";
                default: return "";
            }
        }
        static string GetTensWord(int num)
        {
            switch (num)
            {
                case 2: return "Twenty";
                case 3: return "Thirty";
                case 4: return "Forty";
                case 5: return "Fifty";
                case 6: return "Sixty";
                case 7: return "Seventy";
                case 8: return "Eighty";
                case 9: return "Ninety";
                default: return "";
            }
        }
    }
}
