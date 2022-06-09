namespace Lab3_3{
    class Program
    {
        static void Main()
        {
            List<int> numbersList = new List<int>() {0, 1, 2, 3, 4, 5 };
            Console.WriteLine("Enter k: ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if(!k.Equals(null) && !c.Equals(null) && k < numbersList.Count){
                for(int i=0; i<numbersList.Count; i++)
                {
                    if (i >= k)
                    {
                        numbersList[i-1]= numbersList[i];
                    }
                }
                numbersList.Insert(k, c);

                numbersList.RemoveAt(numbersList.Count-1);
                Console.WriteLine("\nPrinting new list...\n");
                for (int i = 0; i < numbersList.Count; i++)
                {
                    Console.WriteLine("[" + i + "] " + numbersList[i]);
                }
            }
            else
            {
                Console.WriteLine("Wrong input!");
            }

        }
    }
    }