namespace workshop.Main
{
    internal class Program
    {
        static void Main(string[] args)
        {


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