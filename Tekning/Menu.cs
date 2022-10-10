using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekning
{
    internal class Menu
    {
        Rektangel rectangle = new Rektangel(""); // Overload constructor: empty string to pick another constructor
        Fyrkant square = new Fyrkant("");
        Cirkel circle = new Cirkel("");

        private int userInput;
        private string displayCalculate; // will be displayed for user after choosing what calculation will be made
        private string displayShape; // will be displayed for user after choosing shape
        public void runProgram()
        {
            while (true)
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("   SUPER CALCULATOR");
                Console.WriteLine(" Choose    your    shape");
                Console.WriteLine("---------------------");
                Console.WriteLine("#1: " + rectangle);
                Console.WriteLine("#2: " + square);
                Console.WriteLine("#3: " + circle);
                Console.WriteLine("#4: Exit program");                
                userInput = inputFromUser("Enter shape", 1, 4);
                Console.Clear();
                if (userInput == 4)
                {
                    break;
                }
                switch (userInput)
                {
                    case 1:
                        displayShape = rectangle.ToString();
                        break;
                    case 2:
                        displayShape = square.ToString();
                        break;
                    case 3:
                        displayShape = circle.ToString();
                        break;
                }
                Console.WriteLine("#1: circumference");
                Console.WriteLine("#2: Area");
                if (displayShape != circle.ToString()) // user dont want circle, 3 option will be available
                {
                    Console.WriteLine("#3: Volume");
                    userInput = inputFromUser("Enter calculation", 1, 3);
                }
                else // if user want's circle, only 2 option available
                {
                    userInput = inputFromUser("Enter calculation", 1, 2);
                }
                Console.Clear();
                switch (userInput)
                {
                    case 1:
                        displayCalculate = "circumference";
                        break;
                    case 2:
                        displayCalculate = "Area";
                        break;
                    case 3:
                        displayCalculate = "Volume";
                        break;
                }
                Console.Clear();
                Console.WriteLine("Shape: " + displayShape + "   -    Calculate: " + displayCalculate);
                if (displayShape != circle.ToString()) // if user enter Circle, different variables will be implemented
                {
                    double width = 0;
                    double length = 0;
                    double height = 0;
                    width = inputFromUser("Enter width", width);
                    length = inputFromUser("Enter length", length);
                    if (displayCalculate == "Volume")
                    {
                        height = inputFromUser("Enter height", height);
                    }
                    loadingScene();
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Shape: " + displayShape + "   -    Calculate: " + displayCalculate);
                    Console.ResetColor();                   
                    if (userInput == 1) // Rectangle Shape
                    {
                        if (userInput == 1)  // Calculate Circumference
                        {
                            rectangle.GetCircumference(width, length);
                            Console.WriteLine("Circumference: " + rectangle.Circumference);
                        }
                        else if (userInput == 2) // Calculate Area
                        {
                            rectangle.GetArea(width, length);
                            Console.WriteLine("Area: " + rectangle.Area);
                        }
                        else // Calculate Volume
                        {
                            Console.WriteLine("Volume: " + rectangle.getVolume(width, length, height));
                        }
                    }
                    else// Square-Shape
                    {
                        if (userInput == 1) // Calculate Circumference
                        {
                            square.GetCircumference(width, length);
                            Console.WriteLine("Circumference: " + square.Circumference);
                        }
                        else if (userInput == 2) // Calculate Area
                        {
                            square.GetArea(width, length);
                            Console.WriteLine("Area: " + square.Area);
                        }
                        else // Calculate Volume
                        {
                            Console.WriteLine("Volume: " + square.getVolume(width, length, height));
                        }
                    }
                }
                else // Circle - Shape
                {
                    double radius = 0;
                    radius = inputFromUser("Enter Radius", radius);
                    loadingScene();
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Shape: " + displayShape + "   -    Calculate: " + displayCalculate);
                    Console.ResetColor();
                    if (userInput == 1) // Calculate Circumference 
                    {
                        circle.GetCircumference(radius);
                        Console.WriteLine("Circumference: " + circle.Circumference);
                    }
                    else // Calculate Area 
                    {
                        circle.GetArea(radius, radius);
                        Console.WriteLine("Area: " + circle.Area);
                    }
                }
                Console.WriteLine("\nkey for menu..");
                Console.ReadKey();
            }
        }
        /// <summary>
        /// minNr = nr 1 option in menu, maxNr = last option in menu
        /// </summary>
        /// <param name="userInput"></param>
        /// <param name="minMenuNumber"></param>
        /// <param name="maxMenuNumber"></param>
        /// <returns></returns>
        private int inputFromUser(string askUser, int minMenuNumber, int maxMenuNumber = int.MaxValue)  // int.max = if we not need a max number, 
        {
            while (true)
            {
                Console.Write(askUser + ": ");
                try
                {
                    userInput = Convert.ToInt32(Console.ReadLine());

                }
                catch (Exception)
                {
                    // do nothing
                }
                if (userInput >= minMenuNumber && userInput <= maxMenuNumber)
                {
                    break;
                }
                else
                {
                    nonValidInput();
                }

            }
            return userInput;
        }
        private double inputFromUser(string askUser, double userInput)
        {
            while (true)
            {
                Console.Write(askUser + ": ");
                try
                {
                    userInput = Convert.ToInt32(Console.ReadLine());

                }
                catch (Exception)
                {
                    // do nothing
                }
                if (userInput > 0)
                {
                    break;
                }
                else
                {
                    nonValidInput();
                }
            }
            return userInput;
        }
        private void loadingScene()
        {
            Console.WriteLine("+");
            System.Threading.Thread.Sleep(200);
            Console.WriteLine("  -");
            System.Threading.Thread.Sleep(200);
            Console.WriteLine("    *");
            System.Threading.Thread.Sleep(200);
            Console.WriteLine("   +");
            System.Threading.Thread.Sleep(200);
            Console.WriteLine("  -");
            System.Threading.Thread.Sleep(200);
            Console.WriteLine("    *");
            System.Threading.Thread.Sleep(200);
            Console.WriteLine("  +");
            System.Threading.Thread.Sleep(200);
            Console.WriteLine(" -");
            System.Threading.Thread.Sleep(200);
        }
        private void nonValidInput()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Non valid input");
            Console.ResetColor();
        }
    }
}
