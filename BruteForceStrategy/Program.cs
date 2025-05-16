namespace BruteForceStrategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = [1,2,3,5,6,7];
            int target = 11;
            var result = Contains(numbers, target);
            Console.WriteLine($"'{target} {(result ? "Found":"Not Found")}'");
        }

        static bool Contains(int[] source , int target)
        {
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] == target)
                    return true;
            }
            return false;
        }
    }
}
