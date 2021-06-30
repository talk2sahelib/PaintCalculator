using System;

namespace PaintCalculator
{
     public class Program
    {
        static void Main(string[] args)
        {

            Program.PaintCalculationInput(12, 10, 11);
            Console.ReadLine();


        }

        public static void PaintCalculationInput(double length, double width, double height)
        {
            //Calculation of room painting requirements

            //Defining required variables
            double wallArea, floorArea, volume, paintRequired;
            string widthString, lengthString, heightString;
            double paintPerSquareFoot = .06;//Suppose for 1 squire foot .06 litre of paint is required 

            Console.WriteLine("Paint Calculator:");


            Console.WriteLine("Enter Room Length and press enter...");
            lengthString = Console.ReadLine();
            length = double.Parse(lengthString);

            Console.WriteLine("Enter Room Width and press enter...");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("Enter Room Height and press enter...");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);//all required data collect from user

            //now calculating

            floorArea = length * width;//calculating floor area
            wallArea = 2 * (length + width) * height;//calculating wall area
            paintRequired = wallArea * paintPerSquareFoot;//Calculating paint
            volume = length * width * height;//calculating volume


            //now display result
            Console.WriteLine("The Area of the floor is: " + floorArea + " square feet.");
            Console.WriteLine("The amount of paint required to paint the walls is: " + paintRequired + " litres.");
            Console.WriteLine("The Volume of the room is: " + volume + " square feet.");

        }

    }
}
