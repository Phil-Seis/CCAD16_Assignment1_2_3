using System.Net.Http.Headers;

namespace CCAD16_Assignment1_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a menu driven application to perform calculation functions like addition, subtraction, multiplication, and division.
            //Call them appropriately when user selects the option.
            //Give the user the option to continue or exit the program.

            //added a boolean to give the option at the end to either continue or not. default is to continue, hence the true value
            bool continueProgram = true;

            //loop begins. I have nested the switch statments within this loop.
            while (continueProgram)
            {
                //menu for user
                Console.WriteLine("Let's do some calculation! Please select an operation from the menu below: ");
                Console.WriteLine("");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. EXIT THE PROGRAM");
                Console.WriteLine("");

                //variable for users selection
                int choice = Convert.ToInt32(Console.ReadLine());

                //if statement, logic to run a loop specifically to rule out exiting the program right away.
                if (choice == 5)
                {
                    Console.WriteLine("Thanks for checking out the program. See you later!");
                }

                //logic if user chooses a selection outside of choices, will not continue the program
                else if (choice > 5)
                {
                    Console.WriteLine("Please enter a valid choice (1-5)");
                }

                //moving on with logic to complete the program via users choice
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Enter your first number: ");
                    double firstValue = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("");
                    Console.WriteLine("Enter your second value: ");
                    double secondValue = Convert.ToDouble(Console.ReadLine());

                    //switch statement
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine($"Your result: {firstValue} + {secondValue} = {firstValue + secondValue}");
                            break;
                        case 2:
                            Console.WriteLine($"Your result: {firstValue} - {secondValue} = {firstValue - secondValue}");
                            break;
                        case 3:
                            Console.WriteLine($"Your result: {firstValue} * {secondValue} = {firstValue * secondValue}");
                            break;
                        case 4:
                            Console.WriteLine($"Your result: {firstValue} / {secondValue} = {firstValue / secondValue}");
                            break;
                        default:
                            Console.WriteLine("Your choice was invalid. Try again please");
                            break;
                    }
                    //allows user to either continue the program or exit. This is where the while loop in the beginning ties in.
                    Console.WriteLine("Would you like to go again? (yes /no)");
                    string lastChoice = Convert.ToString(Console.ReadLine());
                    continueProgram = lastChoice == "yes";
                }
            }
        }
    }
}
