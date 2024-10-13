namespace Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Input";

            Console.WriteLine("Please Enter Your Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Welcome " + name + "!" );
            Console.ReadKey();
        }
    }
}
