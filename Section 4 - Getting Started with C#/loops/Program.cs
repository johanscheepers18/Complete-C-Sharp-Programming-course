using System;

namespace Loops
{
    class Progam
    {
        public static void Main(String[] args)
        {
            List<string> collection = new List<string>() {"hello", "people", "of", "the", "world" };
            for(int i=0; i < collection.Count; i++)
            {
                Console.WriteLine(collection[i]);
            }

            int count = collection.Count;

            while(count > 0)
            {
                Console.WriteLine(count);
                count--;
            }
        }
    }
}