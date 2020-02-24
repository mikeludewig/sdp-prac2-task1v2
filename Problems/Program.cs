using System;


namespace Problems
{
    public class Program
    {
        public static string Prefix(string input)
        {
            int numChar = input.Length;
            string num = numChar.ToString();
            
            //int numWords = input.Split().Length;
            string[] inputSplit = input.Split();
            int numWords = 0;
            int i = 0;

            while (i < inputSplit.Length)
            {
                if (string.IsNullOrWhiteSpace(inputSplit[i]))
                {
                    i++;
                    continue;
                }
                else
                {
                    i++;
                    numWords++;
                    
                }
                
            }

            string numW = numWords.ToString();
            
            string value = num + "," + numW + ":" + input ;

            
            return value;
        }

        static void Main(string[] args)
        {
            string word = "Hello World!";
            string sentence = Prefix(word);
            Console.WriteLine(sentence);
        }
    }
}
