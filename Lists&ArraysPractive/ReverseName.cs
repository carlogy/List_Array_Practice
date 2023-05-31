using System;
namespace Lists_ArraysPractice
{
    public class ReverseName
    {
        public static void NameReversal()
        {
            Console.WriteLine("Let's revers you name. ");
            Console.Write("Enter your name: ");
            var nameinput = Console.ReadLine();

            char[] CharArray = nameinput.ToCharArray();

            Array.Reverse(CharArray);



            Console.WriteLine(new string(CharArray));




            Console.ReadLine();

        }
    }

}

