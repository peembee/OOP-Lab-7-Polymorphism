namespace Tekning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tekning rektangel = new Rektangel();
            Tekning fyrkant = new Fyrkant();
            Tekning cirkel = new Cirkel();
            Console.WriteLine("-------");
            Console.WriteLine("Key to enter program");
            Console.ReadKey();
            Console.Clear();
            Menu menu = new Menu();
            menu.runProgram();           
        }
    }
}