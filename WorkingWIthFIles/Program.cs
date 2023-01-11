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

            }
            //calling Exercises
            ExerciseOne();
        }
    }
}