using System.ComponentModel.Design;

namespace Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string screening = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());   
            int columns = int.Parse(Console.ReadLine());

            double totalPrice = rows * columns;

            if (screening == "Premiere")
            {
                totalPrice = totalPrice * 12;
            } else if (screening == "Normal")
            {
                totalPrice = totalPrice * 7.5;
            }else if (screening == "Discount")
            {
                totalPrice *= 5;
            }
            Console.WriteLine($"{totalPrice:f2} Leva");
        }
    }
}