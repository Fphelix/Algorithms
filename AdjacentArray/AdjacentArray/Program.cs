using System;

namespace AdjacentArray
{
    class Program
    {
        static void Main(string[] args)
        {
      
            int[] array = { 3, -2, -2, -5, 7, 3 };
            int max = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                int new_max = array[i] * array[i + 1];
                if (new_max > max)
                {
                    max = new_max;

                }
            }
            Console.WriteLine(max); 
        }






        //int  currNumber = array[0] * array[1];

        // int product = 0;
        // int MaxProduct = 0;

        //for ( i = 1; i < array.Length; i++ )
        // {
        //     int currNumber = array[0] * array[i];
        //     product = array[i] * array[i - 1];
        //      MaxProduct = Math.Max(currNumber, product);

        // }
        // Console.WriteLine(  MaxProduct);
    }
}
