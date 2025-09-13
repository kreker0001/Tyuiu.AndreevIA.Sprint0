using Tyuiu.AndreevIA.Sprint0.Task5.V0.Lib;

namespace Tyuiu.AndreevIA.Sprint0.Task5.V0
{
    class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B = " + DataService.Addition(1, 5));
            Console.WriteLine("A - B = " + DataService.Subtraction(15, 5));
            Console.WriteLine("A * B = " + DataService.Multiplication(10, 10));
            Console.WriteLine("A / B = " + DataService.Division(9, 3));

            Console.ReadKey();


        }
    }
}
