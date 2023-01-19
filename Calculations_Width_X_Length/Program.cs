namespace Calculations_Width_X_Length
{
    internal class Program
    {       //Const values moved outside of Function to add more stability to the code and to define the values here so they can reused if NEC
           const int sqFootByHours = 20;
           const double flooringPerHour = 86.00;
        static void Main(string[] args)
        {
          
            Console.WriteLine();
                        
            Console.WriteLine("Hello, Florian & Michael!!!");
            
            Console.WriteLine();
            Console.WriteLine("Please enter a value For both width and length(after each value press enter).");
            double widthTwo = Convert.ToInt32(Console.ReadLine());
            double lengthTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            double calculationTwo = widthTwo * lengthTwo;
            Console.WriteLine("The square footage of your Area is: " + calculationTwo + " sq Feet");

            Console.WriteLine("Please Enter the Cost per Unit for the Width.");
            double widthCostPerUnit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Please Enter the Cost per Unit for the Length.");
            double lengthCostPerUnit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            double laborCost = (widthTwo * widthCostPerUnit) + (lengthTwo * lengthCostPerUnit);
            Console.WriteLine("The Total cost for units per square footage is " + "$" + laborCost + " dollars." );

            Console.WriteLine("You can divide sq footage by hours here to find out your labor cost. Enter your total sq footage below.");
            int sqFootTotal = Convert.ToInt32(Console.ReadLine());
            int sqFootageByHours = sqFootTotal / sqFootByHours;
            double sqFootageHrResult = (double)sqFootTotal / (double)sqFootByHours;
           // double sqFootageByHours1 = (double)(sqFootageByHours); code removed because line 34 calculated the variable with better accuracy
            double flooringPerHourCalc = flooringPerHour * sqFootageHrResult;
            double laborCost1 = laborCost;
            double laborAndAreaCalc = (double)(flooringPerHourCalc) + laborCost1;

            Console.WriteLine();
            Console.WriteLine("You have a total of " + sqFootTotal + " sq feet" + ", which is estimated to take " + sqFootageHrResult + " hours of time." + " Your total labor cost to complete this build is $" + flooringPerHourCalc + " Dollars.");
            Console.WriteLine();
            Console.WriteLine("The combined total for labor cost and unit cost by sq footage is " + "$" + laborAndAreaCalc + " dollars.");

            Console.WriteLine();
            Console.WriteLine("Please enter your estinated labor hours below to confirm the calculated flooring work(Cost of Flooring Per Hr is $86.00) is accurate for your request.");
            Console.WriteLine();
            double inputFlooringPerHour = Convert.ToDouble(Console.ReadLine());
            double flooringPerHourTotal = inputFlooringPerHour* flooringPerHour;
            Console.WriteLine("You have requested " + inputFlooringPerHour + " hours of Labor " + "for a total cost of $ " + flooringPerHourTotal + " dollars");
            Console.WriteLine();
            



        }
    }
}