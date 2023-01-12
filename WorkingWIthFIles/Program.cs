using System;

namespace WorkingWithFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Note that for local testing on your machine, you will need to adjust the path string

            var path = @"C:\Users\cajar\Desktop\UdemyProjects\CSharpFundamentals\WorkingWithFiles\Tomorrow&tommorow&tomorrow.txt";
            var allChars = File.ReadAllText(path);
            var words = new List<string>(allChars.Split(new char[] { },StringSplitOptions.RemoveEmptyEntries));

            void ExerciseOne()
            {
                Console.WriteLine(string.Format("The number of words in the text file is {0} words.", words.Count()));
                
            }
            void ExerciseTwo()
            {
                if (words.Count > 0)
                {
                    var longestIndex = 1;
                    var longestWord = words[0];
                    for(var i = 1; i < words.Count; i++)
                    {
                        var item = words[i];
                        if(item.Length > longestWord.Length)
                        {
                            longestWord = item;
                            longestIndex = i + 1;
                        }
                    }
                    Console.WriteLine(string.Format("The longest word in the text file is '{0}'.\nIt is word number {1} in the document.", longestWord, longestIndex));
                }
            }
            //calling Exercises
            //ExerciseOne();
            //ExerciseTwo();

            Console.WriteLine("Hello, which exercise would you like to test out (1 or 2)?");
            var input = Console.ReadLine();

            if(string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Error.");
                return;
            }

            try
            {
            if(int.Parse(input) == 1)
                {
                    ExerciseOne();
                }
            if(int.Parse(input) == 2)
                {
                    ExerciseTwo();
                }
            }
            catch
            {
                Console.WriteLine("Error.");
                return;
            }
        }
    }
}