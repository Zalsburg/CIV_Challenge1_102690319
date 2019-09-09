using System;
using ShapesClasses;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp {
    class Program {
        static void Main(string[] args) {
            List<Shape> Shapes = new List<Shape>();

            string choice = "";

            while (choice.ToLower() != "e") {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("What would you like to create?");
                Console.WriteLine("a. Square");
                Console.WriteLine("b. Rectangle");
                Console.WriteLine("c. Right Angle Triangle");
                Console.WriteLine("d. Equilateral Triangle");
                Console.WriteLine("e. Exit");
                Console.WriteLine();
                Console.Write("Selection: ");

                choice = Console.ReadLine();

                try {
                    Console.WriteLine();
                    if (choice.ToLower() == "a") {
                        Console.WriteLine("---------------------------------");
                        Console.Write("Colour: ");
                        string colour = Console.ReadLine().ToLower();
                        Console.Write("Side Length: ");
                        int side = int.Parse(Console.ReadLine());
                        if(side < 1) {
                            throw new LengthBelowOne("Please input a length greater that one");
                        }

                        Square newSquare = new Square(colour, side);
                        Shapes.Add(newSquare);
                        Console.WriteLine();
                        Console.WriteLine("Shape created");
                        Console.WriteLine();
                    }
                    else if (choice.ToLower() == "b") {
                        Console.WriteLine("---------------------------------");
                        Console.Write("Colour: ");
                        string colour = Console.ReadLine().ToLower();
                        Console.WriteLine("Side 1 Length: ");
                        int side1 = int.Parse(Console.ReadLine());
                        if (side1 < 1) {
                            throw new LengthBelowOne("Please input a length greater that one");
                        }
                        Console.WriteLine("Side 2 Length: ");
                        int side2 = int.Parse(Console.ReadLine());
                        if (side2 < 1) {
                            throw new LengthBelowOne("Please input a length greater that one");
                        }

                        Rectangle newRectangle = new Rectangle(colour, side1, side2);
                        Shapes.Add(newRectangle);
                        Console.WriteLine();
                        Console.WriteLine("Shape created");
                        Console.WriteLine();
                    }
                    else if (choice.ToLower() == "c") {
                        Console.WriteLine("---------------------------------");
                        Console.Write("Colour: ");
                        string colour = Console.ReadLine().ToLower();
                        Console.Write("Side 1 Length: ");
                        string side1Input = Console.ReadLine();
                        if (side1Input.Contains(".")) {
                            throw new NoDecimal("Please input a whole number");
                        }
                        float side1 = float.Parse(side1Input);
                        if (side1 < 1) {
                            throw new LengthBelowOne("Please input a length greater that one");
                        }
                        Console.Write("Side 2 Length: ");
                        string side2Input = Console.ReadLine();
                        if (side2Input.Contains(".")) {
                            throw new NoDecimal("Please input a whole number");
                        }
                        float side2 = float.Parse(side2Input);
                        if (side2 < 1) {
                            throw new LengthBelowOne("Please input a length greater that one");
                        }

                        RightAngleTriangle newRightTriangle = new RightAngleTriangle(colour, side1, side2);
                        Shapes.Add(newRightTriangle);
                        Console.WriteLine();
                        Console.WriteLine("Shape created");
                        Console.WriteLine();
                    }
                    else if (choice.ToLower() == "d") {
                        Console.WriteLine("---------------------------------");
                        Console.Write("Colour: ");
                        string colour = Console.ReadLine().ToLower();
                        Console.Write("Side Length: ");
                        string sideInput = Console.ReadLine();
                        if (sideInput.Contains(".")) {
                            throw new NoDecimal("Please input whole number");
                        }
                        int side = int.Parse(sideInput);
                        if (side < 1) {
                            throw new LengthBelowOne("Please input a length greater than one");
                        }

                        EquilateralTriangle newETriangle = new EquilateralTriangle(colour, side);
                        Shapes.Add(newETriangle);
                        Console.WriteLine();
                        Console.WriteLine("Shape created");
                        Console.WriteLine();
                    }
                    else {
                        throw new InvalidChoice("Please choose a valid option");
                    }

                }
                catch (FormatException e) {
                    Console.WriteLine("Error: " + e.Message);
                }
                catch (InvalidChoice e) {
                    Console.WriteLine("Error: " + e.Message);
                }
                catch (LengthBelowOne e) {
                    Console.WriteLine("Error: " + e.Message);
                }
                catch (NoDecimal e) {
                    Console.WriteLine("Error: " + e.Message);
                }
                finally {
                    Console.WriteLine();
                }
            }
        }
    }
}
