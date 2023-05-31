using System;
namespace Lists_ArraysPractice
{
    public class NumberChecker
    {
        public static void CheckNumbers()

        {

            List<int> Numbers = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter a number: ");
                var input = Console.ReadLine();
                int number = Int32.Parse(input);



                if (!Numbers.Contains(number))
                {
                    Numbers.Add(number);

                }
                else
                {
                    Console.WriteLine("Numer already exists. Try Again");
                    continue;
                }

            }

            Numbers.Sort();
            foreach (var number in Numbers)
            {
                Console.Write($"{number} ");
            }



            Console.ReadLine();

        }
    }
}

