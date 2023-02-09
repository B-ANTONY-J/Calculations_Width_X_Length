﻿namespace Calculations_Width_X_Length
{
    internal class Program
    {       //Const values moved outside of Function to add more stability to the code and to define the values here so they can reused if NEC
        const int SQ_FOOT_BY_HOUR = 20;
        const double FLOORING_PER_HOUR = 86.00;
        static void Main(string[] args)
        {

            Console.WriteLine($"\nHello, Florian & Michael!!!\n");
                        
            Console.WriteLine("Please enter a value For both width and length(after each value press enter).");
            double widthCalc = Convert.ToInt32(Console.ReadLine());
            double lengthCalc = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            double calculationTotal = widthCalc * lengthCalc;
            Console.WriteLine("The square footage of your Area is: " + calculationTotal + " sq Feet");

            Console.WriteLine($"\nPlease Enter the Cost per Unit per Square Feet.");
            double areaCostPerUnit = Convert.ToDouble(Console.ReadLine());

            double areaCost = (widthCalc * areaCostPerUnit) + (lengthCalc * areaCostPerUnit);
            Console.WriteLine($"\nThe Total cost for units per square footage is " + "$" + areaCost + " dollars.\n");

            Console.WriteLine("You can divide sq footage by hours here to find out your labor cost. Enter your total sq footage below.");
            int sqFootTotal = Convert.ToInt32(Console.ReadLine());
            int sqFootageByHours = sqFootTotal / SQ_FOOT_BY_HOUR;
            double sqFootageHrResult = (double)sqFootTotal / (double)SQ_FOOT_BY_HOUR;

            double flooringPerHourCalc = FLOORING_PER_HOUR * sqFootageHrResult;
            double laborCostMerge = areaCost;
            double laborAndAreaCalc = (double)(flooringPerHourCalc) + laborCostMerge;

            
            Console.WriteLine($"\nYou have a total of " + sqFootTotal + " sq feet" + ", which is estimated to take " + sqFootageHrResult + " hours of time." + " Your total labor cost to complete this build is $" + flooringPerHourCalc + " Dollars.");
            
            Console.WriteLine($"\nThe combined total for labor cost and unit cost by sq footage is " + "$" + laborAndAreaCalc + " dollars.");

            
            Console.WriteLine($"\nPlease enter your estinated labor hours below to confirm the calculated flooring work(Cost of Flooring Per Hr is $86.00) is accurate for your request.");
            
            double inputFlooringPerHour = Convert.ToDouble(Console.ReadLine());
            double flooringPerHourTotal = inputFlooringPerHour * FLOORING_PER_HOUR;
            //The code below is used to verify the accuracy of the code through out this function
            Console.WriteLine($"\nYou have requested " + inputFlooringPerHour + " hours of Labor " + "for a total cost of $ " + flooringPerHourTotal + " dollars\n");
            




        }
    }
}