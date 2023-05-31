using System;
namespace Lists_ArraysPractice
{
	public class NameListInput
	{
        public static void InputNames()
        {

            string input;
            List<string> NamesList = new List<string>();
            int total;




            do
            {
                Console.Write("Enter names, onec your are done enter a blank space to quit: ");
                input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input))
                {
                    NamesList.Add(input);
                }

            } while (!string.IsNullOrEmpty(input));


            total = NamesList.Count();

            if (total <= 2)
            {
                for (int name = 0; name < total; name++)
                {
                    Console.Write("Total names added: " + total);
                    Console.WriteLine(NamesList[name]);
                }
            }
            else
            {
                Console.Write("You have quit the program. ");
                Console.WriteLine("Total list of names: " + total);
            }


            Console.ReadLine();


        }
    }
}

