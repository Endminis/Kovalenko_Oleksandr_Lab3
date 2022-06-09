using System.Linq;
using System.Text;
    namespace Lab3_3
{
    class Program
    {
        static void Main()
        {
            List<string> stringList = new List<string>() { "Personal", "Identification", "Number"};
            string query = stringList.Where(s => !string.IsNullOrEmpty(s))
                                      .Aggregate("", (xs, x) => xs + x.First());
            Console.WriteLine(query);


        }
    }
}