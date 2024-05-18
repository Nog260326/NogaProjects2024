using System.Collections.Generic;
using System;

namespace Object_Oriented_Programming
{
    class NumericalExpression
    {
        public int Number { get; set; }
        public NumericalExpression(int number)
        {
            Number = number;
        }
        public int GetValue()
        {
            return Number;
        }
        private int[] Numbers(int num)
        {
            int current = num;
            int counter = 0;
            int number_length = 0;
            while (current != 0)
            {
                if (current != 0)
                {
                    number_length += 1;
                    current = current / 10;
                }
                else
                {
                    break;
                }
            }
            current = num;
            if (number_length == 0)
            {
                int[] result = new int[1];
                result[0] = 0;
                return result;
            }
            int[] numbers = new int[number_length];
            while (counter != number_length)
            {
                if (current != 0)
                {
                    numbers[counter] = current % 10;
                    current = current / 10;
                    counter += 1;
                }
            }
            return numbers;
        }
        private string[] Find_Words(int[] numbers)
        {
            string[] ones = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            string[] teens = { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            string[] tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
            string[] sentence = new string[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == 0)
                {
                    if(numbers.Length == 1 && numbers[i] == 0)
                    {
                        sentence[i] = "Zero";
                    }
                    else
                    {
                        sentence[i] = ones[numbers[i]] + " ";
                    }
                }
                if (i == 1)
                {
                    if(numbers[i] == 0)
                    {
                        sentence[i] = ones[numbers[i]] + " ";
                    }
                    if (numbers[i] == 1)
                    {
                        sentence[i] = teens[numbers[i - 1]] + " ";
                        sentence[i - 1] = "";
                    }
                    if (numbers[i] > 1)
                    {
                        sentence[i] = tens[numbers[i]] + " ";
                    }
                }
                if (i == 2)
                {
                    if (numbers[i] == 0)
                    {
                        sentence[i] = ones[numbers[i]] + " ";
                    }
                    sentence[i] = ones[numbers[i]] + " Hundred ";
                }
                if (i == 3)
                {
                    if (numbers[i] == 0)
                    {
                        sentence[i] = ones[numbers[i]] + " ";
                    }
                    sentence[i] = ones[numbers[i]] + " Thousand ";
                }
                if (i == 4)
                {
                    if (numbers[i] == 0)
                    {
                        sentence[i] = ones[numbers[i]] + " ";
                    }
                    if (numbers[i] == 1)
                    {
                        sentence[i] = teens[numbers[i - 1]] + " Thousand ";
                        sentence[i - 1] = "";
                    }
                    if (numbers[i] > 1)
                    {
                        sentence[i - 1] = "";
                        sentence[i] = tens[numbers[i]] + " " + ones[numbers[i - 1]] + " Thousand ";
                    }
                }
                if (i == 5)
                {
                    if (numbers[i] == 0)
                    {
                        sentence[i] = ones[numbers[i]] + " ";
                    }
                    sentence[i] = ones[numbers[i]] + " Hundred ";
                    sentence[i - 2] = ones[numbers[i - 2]] + " Thousand ";
                    if (numbers[i - 1] == 1)
                    {
                        sentence[i - 1] = teens[numbers[i - 2]] + " Thousand ";
                        sentence[i - 2] = "";
                    }
                    else
                    {
                        sentence[i - 1] = tens[numbers[i - 1]] + " ";
                        sentence[i - 2] = ones[numbers[i - 2]] + " Thousand ";
                    }
                }
                if (i == 6)
                {
                    if (numbers[i] == 0)
                    {
                        sentence[i] = ones[numbers[i]] + " ";
                    }
                    sentence[i] = ones[numbers[i]] + " Million ";
                }
                if (i == 7)
                {
                    if (numbers[i] == 0)
                    {
                        sentence[i] = ones[numbers[i]] + " ";
                    }
                    if (numbers[i] == 1)
                    {
                        sentence[i] = teens[numbers[i - 1]] + " Million ";
                        sentence[i - 1] = "";
                    }
                    else
                    {
                        sentence[i] = tens[numbers[i]] + " ";
                        sentence[i - 1] = ones[numbers[i - 1]] + " Million ";
                    }
                }
                if (i == 8)
                {
                    if (numbers[i] == 0)
                    {
                        sentence[i] = ones[numbers[i]] + " ";
                    }
                    sentence[i] = ones[numbers[i]] + " Hundred ";
                    if (numbers[i - 1] == 1)
                    {
                        sentence[i - 1] = teens[numbers[i - 2]] + " Million ";
                        sentence[i - 2] = "";
                    }
                    else
                    {
                        sentence[i - 1] = tens[numbers[i - 1]] + " ";
                        sentence[i - 2] = ones[numbers[i - 2]] + " Million ";
                    }
                }
                if (i == 9)
                {
                    if (numbers[i] == 0)
                    {
                        sentence[i] = ones[numbers[i]] + " ";
                    }
                    sentence[i] = ones[numbers[i]] + " Billion ";
                }
                if (i == 10)
                {
                    if (numbers[i] == 0)
                    {
                        sentence[i] = ones[numbers[i]] + " ";
                    }
                    if (numbers[i] == 1)
                    {
                        sentence[i] = teens[numbers[i - 1]] + " Billion ";
                        sentence[i - 1] = "";
                    }
                    else
                    {
                        sentence[i] = tens[numbers[i]] + " ";
                        sentence[i - 1] = ones[numbers[i - 1]] + " Billion ";
                    }
                }
                if (i == 11)
                {
                    if (numbers[i] == 0)
                    {
                        sentence[i] = ones[numbers[i]] + " ";
                    }
                    sentence[i] = ones[numbers[i]] + " Hundred ";
                    if (numbers[i - 1] == 1)
                    {
                        sentence[i - 1] = teens[numbers[i - 2]] + " Billion ";
                        sentence[i - 2] = "";
                    }
                    else
                    {
                        sentence[i - 1] = tens[numbers[i - 1]] + " ";
                        sentence[i - 2] = ones[numbers[i - 2]] + " Billion ";
                    }
                }
            }
            return sentence;
        }
        public string[] Make_String()
        {
            int[] numbers = Numbers(Number);
            string[] words = Find_Words(numbers);
            string[] final_sentence = new string[words.Length];
            Stack<string> s = new Stack<string>();
            for (int i = 0; i < words.Length; i++)
            {
                s.Push(words[i]);
            }
            for (int i = 0; i < words.Length; i++)
            {
                if (s.Count != 0)
                {
                    final_sentence[i] = s.Pop();
                }
            }
            return final_sentence;
        }
        public long SumLetters(int number)
        {
            long sum_word = 0;
            for(int i = 0; i < number+1; i++)
            {
                sum_word += Calculate(i);
            }
            return sum_word;
        }
        // overloadingהעיקרון בתכנות מונחה עצמים שבא לידי ביטוי במפונקציה הוא עיקרון ה
        // מפני שיש כאן דוגמה לשתי פונקציות שפועלות באופן כמעט זהה רק שהממשק של הפונקציה השנייה מעט יותר מורב
        public long SumLetters_Object(NumericalExpression number)
        {
            long sum_word = 0;
            for (int i = 0; i < number.Number + 1; i++)
            {
                sum_word += Calculate(i);
            }
            return sum_word;
        }
        public int Calculate(int num)
        {
            int[] numbers = Numbers(num);
            string[] sentence = Find_Words(numbers);
            int counter = 0; 
            for(int i = 0; i < sentence.Length; i++)
            {
                string word = sentence[i];
                for (int j = 0; j < sentence[i].Length; j++)
                {
                    if((word[j] >= 'a' && word[j] <= 'z') || (word[j] >= 'A' && word[j] <= 'Z'))
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }
    }
}
