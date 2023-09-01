namespace workshop.Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
     

            //while loop
            int i = 10;
            while (i < 10)
            {
                Console.WriteLine($"The counter is {i}");
                i++;
            }

            //beware of the infinite while!            
            int aVariableThatNeverIncrements = 1;
            while (aVariableThatNeverIncrements < 10)
            {
                Console.WriteLine($"The counter is {aVariableThatNeverIncrements}");
                bool result = 1 == 1 ? 1==2 ? false : true : false;

            }

            //do while
            int j = 10;
            do
            {
                Console.WriteLine($"The counter is {j}");
                j++;
            } while (j < 1);



            //for loop
            for (int k = 0; k < 10; k++)
            {
                Console.WriteLine($"The index is {k}");
            }


            //up
            for (int l = 0; l < 10; l++)
            {
                Console.WriteLine(l);
            }


            //down
            for (int m = 100; m > 0; m--)
            {

                Console.WriteLine(m);
            }


            //upagain
            for (int n = 0; n < 1000; n=n+5)
            {
                Console.WriteLine(n);
            }

            //foreach
            int[] intArray = { 1, 2, 3 };
            foreach (int o in intArray)
            {
                Console.WriteLine(o);
            }

            Console.ReadLine();
        }
    }
}