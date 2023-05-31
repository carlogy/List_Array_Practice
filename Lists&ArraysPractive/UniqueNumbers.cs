using System;
namespace Lists_ArraysPractice
{
	public class UniqueNumbers
	{
		public static void UniqueNumberList()
		{
			string input;
			List<string> Allinputs = new List<string>();

			do
			{
                Console.Write("Enter a number or type quit to quit program: ");
				input = Console.ReadLine();


				if (input != "quit")
				{
                    Allinputs.Add(input);
				}
				else
				{
					break;
				}
				



            } while (input != "quit");


			Allinputs = Allinputs.Distinct().ToList();
			foreach (var item in Allinputs)
			{
				Console.Write($"{item}");
			}

			Console.ReadLine();
			
		}
	}
}

