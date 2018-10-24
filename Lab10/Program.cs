using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Circle Creation Station.");
            int circleCount = 0;

            while (true)
            {
                //prompt user to enter a radius
                double radius = GetDouble("Enter a radius: ", circleCount);
                Circle userCircle = new Circle(radius);

                //calculate area and circumference, round to nearest 2 decimals
                string circumference = userCircle.CalculateFormattedCircumference();
                string area = userCircle.CalculcateFormattedArea();
                Console.WriteLine($"The Circumference of your circle is {circumference}, and the Area is {area}.");

                //increases count of objects user has created
                circleCount++;

                //prompt user to continue
                string userResponse = GetString("Would you like to make another circle?  Press Y to keep going.");

                if (userResponse.ToUpper() != "Y")
                {
                    //display goodbye and number of circles the user built when they quit
                    Console.WriteLine($"K bye!  You created {circleCount} circles.");
                    Console.ReadLine();
                    break;
                } 
            }  
        }

        public static double GetDouble(string message, int circleCount)
        {
            double radius; 

            while (true)
            {
                Console.Write(message);
                bool parsed = double.TryParse(Console.ReadLine(), out radius);
                if (!parsed || radius <= 0)
                {
                    Console.WriteLine("That is not valid, please enter a positive number. ");
                    if (circleCount == 0)
                    {
                        continue;
                    }
                    else
                    {
                        circleCount--;
                        continue;
                    }
                }
                else
                {
                    return radius;
                }
            }
        }

        public static string GetString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
    }
}
