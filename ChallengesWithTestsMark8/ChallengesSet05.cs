using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            if (startNumber == 0)
            {
                return n;
            }

            List<int> firstlist = new List<int>();
            int maxLoop = startNumber * n;
            int[] numbersDivisiblebyN = new int[0];
            var result = 0;

            for (int i = startNumber; i < maxLoop; i++)
            {

                if (i > startNumber && i % n == 0)
                {
                    result = i;
                    break;
                }
            }
            return result;
        }
    }

    public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
    {
        for (int i = 0; i < businesses.Length; i++)
        {
            if (businesses[i].TotalRevenue == 0)
            {
                businesses[i].Name = "CLOSED";
            }
        }
    }

    public bool IsAscendingOrder(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            return false;
        }
        for (int i = 1; i < numbers.Length; i++)
        {

            if (numbers[i] < numbers[i - 1])
            {
                return false;
            }
        }
        return true;
    }
            
    

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
        {
            return 0;
        }
        int sum = 0;

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i - 1] % 2 == 0)
            {
                sum += numbers[i];
            }
        }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";
            }
        
        int goodwords = 0;
        List<string> wordlist = new List<string>();

        for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == "" || words[i] == " " || words[i] == " ")
                {
               
                }
                else
                    {
                    wordlist.Add(words[i].Trim());
                    goodwords += 1;
                    }
            }
                if (goodwords == 0)
        {
            return "";
        }
                else
         {
            return String.Join(" ", wordlist) + ".";
        }
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            throw new NotImplementedException();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            throw new NotImplementedException();
        }
    }
}
