using System;
namespace Lists_ArraysPractice
{
	public class CSVNumberList
	{
		public static void  NumberList()
		{
			Console.Write("Enter a list of 5 numbers separated by a comma:  ");
			var input = Console.ReadLine();

			var NumArray = input.Split(separator: ", ").ToArray();
			Array.Sort(NumArray);

		
			

			if (input.Length <= 5)
			{
				Console.WriteLine("Invalid List. Please retry. ");
			}
			else
			{
                   

                string[] firstThreeItems = new string[3];

                for (int i = 0; i < 3; i++)
                {
                    firstThreeItems[i] = NumArray[i];
					Console.Write(firstThreeItems[i]);
					
                }

				
            }

			Console.ReadLine();

		

		}
	}
}

