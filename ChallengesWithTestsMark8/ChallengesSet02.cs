using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (alphabet[i] == c)
                {
                    return true;
                }
                
            }
            return false;
            //return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            //if (vals.Length % 2 == 0) 
            //{
            //    return true;
            //}
            //return false;

            return vals.Length % 2 == 0;    
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

            //return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
           

            //return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            //if (numbers == null || numbers.Count() <= 0)
            //{
            //    return 0;
            //}

            //double max = 0;
            //double min = 0;

            //var list = numbers.ToList();

            //for (int i = 0; i > list.Count - 1; i++)

            //{
            //    if (list[i] > list[i + 1])
            //    {
            //        max = list[i];
            //    }
            //}
            //for (int i = 0; i < list.Count - 1; i++)
            //{
            //    if (list[i] < list[i + 1])
            //    {
            //        min = list[i];
            //    }
            //}
            //return min + max;


            return numbers?.Any() ?? false ? numbers.Min() + numbers.Max() : 0;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }

        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            var sum = 0; 
            for (var i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
            //return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            int sum = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                { 
                    sum += number;               
                }
            }
            return sum;

            //return numbers.Where(number => number % 2 == 0).Sum();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            
            var sum = 0;
            for (var i = 0; i < numbers.Count; i++) 
            { 
                sum += numbers[i];
            }
            return (sum % 2 != 0);
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 0)
            {
                return 0;
            }
            else
            {
                return number / 2;
            }
        }
    }
}
