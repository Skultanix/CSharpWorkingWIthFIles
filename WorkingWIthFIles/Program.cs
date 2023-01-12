namespace WorkingWithFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\cajar\Desktop\UdemyProjects\CSharpFundamentals\WorkingWithFiles\Tomorrow&tommorow&tomorrow.txt";
            var allChars = File.ReadAllText(path);
            var words = new List<string>(allChars.Split(new char[] { },StringSplitOptions.RemoveEmptyEntries));

            void ExerciseOne()
            {
                Console.WriteLine(string.Format("The number of words in the text file is {0} words.", words.Count()));
                
                foreach(var word in words)
                {
                    Console.WriteLine(word);
                }
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
            ExerciseTwo();
        }
    }
}