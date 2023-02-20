namespace Calculations_Width_X_Length
{
    internal class Program
    {       //Const values moved outside of Function to add more stability to the code and to define the values here so they can reused if NEC
        const int SQ_FOOT_BY_HOUR = 20;
        const double FLOORING_PER_HOUR = 86.00;
        static void Main(string[] args)
        {

            Console.WriteLine($"\nHello, Florian & Michael!!!\n");
                        
            Console.WriteLine("Please enter a value For both width and length(after each value press enter).");
            double width = Convert.ToInt32(Console.ReadLine());
            double length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            double calculationTotal = width * length;
            Console.WriteLine("The square footage of your Area is: " + calculationTotal + " sq Feet");

            Console.WriteLine($"\nPlease Enter the Cost per Unit per Square Feet.");
            double areaCostPerUnit = Convert.ToDouble(Console.ReadLine());

            double areaCost = calculationTotal * areaCostPerUnit;
            Console.WriteLine($"\nThe Total cost for units per square footage is " + "$" + areaCost + " dollars.\n");

            double totalArea = calculationTotal;
            
            double sqFootageHrResult = totalArea / SQ_FOOT_BY_HOUR;

            double flooringPerHourCalc = FLOORING_PER_HOUR * sqFootageHrResult;
            
            double laborAndAreaCalc = (double)(flooringPerHourCalc) + areaCost;

            
            Console.WriteLine($"\nYou have a total of " + totalArea + " sq feet" + ", which is estimated to take " + sqFootageHrResult + " hours of time." + " Your total labor cost to complete this build is $" + flooringPerHourCalc + " Dollars.");
            
            Console.WriteLine($"\n\nThe combined total for labor cost and unit cost by sq footage is " + "$" + laborAndAreaCalc + " dollars.");

            
            



        }
    }
}