using System;

namespace ConditionalSatements
{
    class Program
    {
        public static void Main(String[] args)
        {
            int option = 1;

            if (option == 0)
            {
                string output = "Your chosen option is '0'";
                Console.WriteLine(output);
            }

            else if (option == 1)
            {
                string output = "Your chosen option is '1'";
                Console.WriteLine(output);
            }

            else
            {
                string output = "Your chose option is invalid";
                Console.WriteLine(output);
            }

        }
    }
}
