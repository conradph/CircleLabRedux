using System;
using System.Collections.Generic;
using System.Text;

namespace CircleLabRedux
{
    class CircleList
    {
        public List<Circle> circles = new List<Circle>();

        public void AddCircle(double radius)
        {
            circles.Add(new Circle(radius));
        }
        public string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }
        public void UserInputCircle()
        {
            Console.WriteLine("Welcome to the Circle Tester");
            Circle c;
            double radius = 0;
            
            bool goOn = true;
            while (goOn)
            {
                bool invalidInput = true;
                while (invalidInput)
                {
                    string response = GetInput("Enter Radius: ");
                    try
                    {
                        radius = double.Parse(response);
                        if (radius >= 0)
                        {
                            invalidInput = false;

                        }

                        else
                        {
                            Console.WriteLine("Please enter a number greater than 0.");
                        }

                    }
                    catch
                    {
                        Console.WriteLine("Please enter a valid number");
                    }
                }
                c = new Circle(radius);
                circles.Add(c);
                //Console.WriteLine($"Circumference: {Math.Round(c.CalculateCircumference(),2)}");
                Console.WriteLine($"Area: {Math.Round(c.CalculateArea(),2)}");
                goOn = GoOn();
            }
            Console.WriteLine("Here are all of the circles that you created!");
            PrintEntireList();
            Console.WriteLine($"You created {circles.Count} circles.");
            Console.WriteLine("Goodbye!");

        }
        public bool GoOn()
        {
            while (true)
            {
                string response = GetInput("Continue? (y/n)").ToLower().Trim();
                if (response == "y")
                {
                    return true;
                }
                else if (response == "n")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Please enter only y or n");
                    continue;
                }
            }
        }
        public void PrintEntireList()
        {
            for(int i = 0; i < circles.Count; i++)
            {
                Console.WriteLine(circles[i]);
            }
        }

    }
}
