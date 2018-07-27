using System;

namespace maths
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine("This programme is for calculations where you can add subtract divide 2 numbers");
            string firstnumber = Console.ReadLine();
            // i will now turn the number from a string to integer

            int firstnumb = int.Parse(firstnumber);
            Console.WriteLine("the first number" + firstnumb + "thesecondnumber" + ".");

            // will input the second number and change itfrom a string toan integer

            string secondnumber = Console.ReadLine();
            int secondnumb = int.Parse(secondnumber);
            Console.WriteLine("numbers are" + firstnumb + "and " + secondnumb + ".");
            Console.Write("would love to add, subtract, multiply and divide");

            // i will use the maths operator and find a value on each output 

            string mathsoperator = Console.ReadLine();
            int lastnumb = 0;

            if (mathsoperator == "add")
            {

                lastnumb = firstnumb + secondnumb;
            }

            else if (mathsoperator == "subtraction")
            {

                lastnumb = firstnumb - secondnumb;
            }


            else if (mathsoperator == "multiplication")
            {

                lastnumb = firstnumb * secondnumb;
            }
            else if (mathsoperator == "divide")
            {
                lastnumb = firstnumb / secondnumb;
            }
            else
            {
                Console.WriteLine("incorrect");
            }
            Console.WriteLine(".");
            Console.ReadLine();
        }
    }
}
