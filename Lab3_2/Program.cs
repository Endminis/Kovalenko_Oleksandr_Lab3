using Newtonsoft.Json;

namespace Lab3_2
{
    class Program
    {
        static void Main()
        {
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>()
            {
                {1, 6},
                {2, 1},
                {3, 21},
                {4, 9},
                {5, 12},
                {6, 11},
            };
            Console.WriteLine("Dictionary:");
            int multipliedKey = 1;
            foreach (var currentPair in keyValuePairs)
            {
                Console.WriteLine($"key: {currentPair.Key} value: {currentPair.Value}");
                multipliedKey*=currentPair.Key;
            }
            Console.WriteLine("\nMultiplied key: " + multipliedKey);
            var sortedDictonary = from entry in keyValuePairs orderby entry.Value ascending select entry;
            Console.WriteLine("\nSorted Dictionary:");
            foreach (var currentPair in sortedDictonary)
            {
                Console.WriteLine($"key: {currentPair.Key} value: {currentPair.Value}");
            }
            File.WriteAllText("Dictionary.json", JsonConvert.SerializeObject(sortedDictonary));

        }

    }
}