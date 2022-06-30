using Coding_Challange.LeetCode.Algos.Binary_Search;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Search_Insert_Position search = new Search_Insert_Position();
            var res = search.SearchInsert(new int[] { 1, 3, 5, 6 }, 0);
            Console.WriteLine($"{res} is the bad version");
            Console.WriteLine("Hello World!");
        }
    }
}