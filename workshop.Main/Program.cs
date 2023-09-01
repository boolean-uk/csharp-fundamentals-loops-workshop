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


            //do while
            int j = 10;
            do
            {
                Console.WriteLine($"The counter is {j}");
                j++;
            } while (j < 10);



            //for loop
            for (int k = 0; k < 10; k++)
            {
                Console.WriteLine($"The index is {k}");
            }


            //up
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }


            //down
            for (int j = 100; j > 0; j--)
            {

                Console.WriteLine(j);
            }


            //up
            for (int k = 0; k < 1000; k=k+5)
            {
                Console.WriteLine(k);
            }


            Console.ReadLine();
        }
    }
}