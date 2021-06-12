using System;

namespace Practice6_9_21
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise31();
            //Exercise32();
            //Exercise33();
            //Exercise34();
            Exercise35();
        }

        static bool RepCheck(string a)
        {
            a.ToLower();

            if (a == "y")
            {
                return true;
            }
            else if (a == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Please indicate Y or N.");
                return RepCheck(Console.ReadLine());
            }
        }

        static void Exercise31()
        {
            //Exercise 31
            bool repeat;
            do
            {
                int[] numArray = new int[5] { 2, 8, 0, 24, 51 };

                Console.WriteLine("Please enter an index: ");
                int userIndex = int.Parse(Console.ReadLine());

                if (userIndex <= numArray.Length && userIndex >= 0)
                {
                    Console.WriteLine($"The value at index {userIndex} is {numArray[userIndex]}");
                }
                else
                {
                    Console.WriteLine("Not a valid index.");
                }

                Console.WriteLine("Would you like to continue? (Y/N)");

                repeat = RepCheck(Console.ReadLine());
               
            } while (repeat == true);

            Console.WriteLine("Goodbye!");

        }

        static void Exercise32()
        {
            bool repeat;
            do
            {
                int[] numArray = new int[5] { 2, 8, 0, 24, 51 };
                Console.WriteLine("Please enter a number: ");
                int userNum = int.Parse(Console.ReadLine());

                if (userNum == numArray[0])
                {
                    Console.WriteLine($"The value {userNum} can be found at index 0.");
                }
                else if (userNum == numArray[1])
                {
                    Console.WriteLine($"The value {userNum} can be found at index 1.");
                }
                else if (userNum == numArray[2])
                {
                    Console.WriteLine($"The value {userNum} can be found at index 2.");
                }
                else if (userNum == numArray[3])
                {
                    Console.WriteLine($"The value {userNum} can be found at index 3.");
                }
                else if (userNum == numArray[4])
                {
                    Console.WriteLine($"The value {userNum} can be found at index 4.");
                }
                else
                {
                    Console.WriteLine("That number could not be found in the array.");
                }

                Console.WriteLine("Would you like to continue? Y/N");

                repeat = RepCheck(Console.ReadLine());
            } while (repeat == true);

            Console.WriteLine("Goodbye!");

        }

        static void Exercise33()
        {
            bool repeat;
            do
            {
                int[] numArray = new int[5] { 2, 8, 0, 24, 51 };
                Console.WriteLine("Please enter an index for the array: ");
                int userIndex = int.Parse(Console.ReadLine());

                if(userIndex <= numArray.Length && userIndex >= 0)
                {
                    Console.WriteLine($"The value at index {userIndex} is {numArray[userIndex]}. Would you like to change it? Y/N");
                    string changeCheck = Console.ReadLine();
                    changeCheck.ToLower();

                    if (changeCheck == "y")
                    {
                        Console.WriteLine("Enter the new value. ");
                        numArray[userIndex] = int.Parse(Console.ReadLine());
                    }
                    else if (changeCheck == "n")
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("That is not a valid index. ");
                }

                Console.WriteLine("Would you like to continue? Y/N");

                repeat = RepCheck(Console.ReadLine());
            } while (repeat == true);

            Console.WriteLine("Goodbye!");
        }

        static void Exercise34()
        {
            bool repeat;
            do
            {
                int[] numArray = new int[5] { 16, 32, 64, 128, 256 };
                Console.WriteLine("Please enter a command, half/double: ");
                string command = Console.ReadLine();
                command.ToLower();

                if (command == "half")
                {
                    for(int i = 0; i < numArray.Length; i++)
                    {
                        numArray[i] /= 2;
                    }
                    Console.WriteLine($"The array now contains: ");
                    for (int i = 0; i < (numArray.Length - 1); i++)
                    {
                        Console.Write(numArray[i] + ", ");
                    }
                    Console.Write(numArray[4] + ".");
                }
                else if (command == "double")
                {
                    for (int i = 0; i < numArray.Length; i++)
                    {
                        numArray[i] *= 2;
                    }
                    Console.WriteLine($"The array now contains: ");
                    for (int i = 0; i < (numArray.Length - 1); i++)
                    {
                        Console.Write(numArray[i] + ", ");
                    }
                    Console.Write(numArray[4] + ".");
                }
                else
                {
                    Console.WriteLine("Not a valid command.");
                }

                Console.WriteLine("Would you like to continue? Y/N");

                repeat = RepCheck(Console.ReadLine());
            } while (repeat == true);

            Console.WriteLine("Goodbye!");
            
        }

        static void Exercise35()
        {
            bool repeat;
            do
            {
                string[] strArray = new string[5] { "cow", "elephant", "jaguar", "horse", "crow" };
                Console.WriteLine("Please enter two indices seperated by a space.");

                string userInput = Console.ReadLine();
                string[] splitInput = userInput.Split(" ");

                string firstIndex;
                int secondIndex;

                if (int.Parse(splitInput[0]) < strArray.Length && int.Parse(splitInput[0]) >= 0)
                {
                    for (int i = 0; i < strArray.Length; i++)
                    {
                        if (splitInput[0] == strArray[i])
                        {
                            firstIndex = strArray[i];
                        }
                        
                    }
                }
                else
                {
                    Console.WriteLine("Those are not valid indices.");
                }

                secondIndex = int.Parse(splitInput[1]);

                for (int i = 0; i < strArray[i].Length; i++)
                {
                    if (secondIndex > strArray[i].Length)
                    {
                        Console.WriteLine("Those are not valid indices.");
                    }
                }

                Console.WriteLine($"The value at index ");
                Console.WriteLine("Would you like to continue? Y/N");

                repeat = RepCheck(Console.ReadLine());
            } while (repeat == true);

            Console.WriteLine("Goodbye!");
            

        }

    }
}
