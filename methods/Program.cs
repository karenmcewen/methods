using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class Program
    {
        static void Main(string[] args) //Main is always void, because it is just doing, not returning something
        {
            //int number1 = 25;
            //int number2 = 50;
            //int total = Add(number1,number2);//note that these are not the same numbers as we defined the method
            //Console.WriteLine(total);

            //int multTotal = Multiply(number1, number2);//do not need to create this variable
            //Console.WriteLine(multTotal);

            ////another way to do the same thing
            //Console.WriteLine(Multiply(number1, number2));

            //Greeting();

            //string name = "Will Robinson";        
            //RobotWarning(name);

            //    Console.WriteLine("What is your favorite type of food? (e.g. cheese, cereal, etc.):");
            //    string foodType = Console.ReadLine().ToLower();
            //    Console.WriteLine("What is your favorite food of type " + foodType);
            //    string food = Console.ReadLine().ToLower();
            //    FavoriteFood(food, foodType);


            //    //Retirement age
            //    Console.WriteLine("How old are you now?");
            //    int age = int.Parse(Console.ReadLine());
            //    if (age>=65)
            //    {
            //        Console.WriteLine("You have already retired. Congratulations!");

            //    }
            //    RetirementCalculator(age);

            Console.WriteLine("How many hours do you work per day?");
            double hoursPerDay = double.Parse(Console.ReadLine());
            Console.WriteLine("What is your hourly wage?");
            double hourlyWage = double.Parse(Console.ReadLine());

            double monthlyWage = WageCalculator(hoursPerDay, hourlyWage);

            Console.WriteLine("This month you will make $" + monthlyWage);

            Console.WriteLine("Please enter the integer to be cubed:");
            int number = int.Parse(Console.ReadLine());
            int cubeNum = NumberCubed(number);
            Console.WriteLine("The cube of " + number + "= " + cubeNum);

            Console.WriteLine("What is your first name?");
                string firstName = Console.ReadLine();
            string newAlienName = YourAlienName(firstName);
            Console.WriteLine("Your new alien name is " +newAlienName);


        }   //}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}End of MAIN - don't erase this curly bracket!!!!

        //we will define our new methods outside of the MAIN
        //when we run a program, it only runs what is within the MAIN 
        //and accesses the programs we define outside of MAIN as needed

        //CREATING A NEW METHOD CALLED "Add"
        //"public" is an access modifier - who has access to the program
        //"int" is the return type of the data
        //"Add" is the name of the method - begin with uppercase/pascal case
        //each method should do only one thing
        //elements in the () are the parameters
        //elements in the {} is the body
        //firstNumber and secondNumber are part of the scope - not variables

        public static int Add(int firstNumber, int secondNumber)
        {
            int sum = firstNumber + secondNumber; //variable name is "sum"
            return sum; //returns the value "sum" back to whatever called the method
        }

        //CREATING A NEW METHOD CALLED "Multiply"
        public static int Multiply(int firstNumber, int secondNumber)
        {
            int product = firstNumber * secondNumber;
            return product;
        }

        //CREATING A NEW METHOD CALLED "Greeting"
        public static void Greeting() //void does not return anything
        {
            Console.WriteLine("Hello world");
            //because it is void we do not return anything - it is just running a method
        }

        //CREATING A NEW METHOD CALLED "Danger!"
        public static void RobotWarning(string name)
        {
            Console.WriteLine("Danger, " + name);

        }
        //CREATING a NEW METHOD CALLED "FavoriteFood"
        //it should take two string parameters
        //Name of the food and the other being the food type
        //it should be void return type
        //the method should concatenate the two values
        public static void FavoriteFood(string food, string foodType)
        {

            Console.WriteLine("Your favorite food is " + food + " " + foodType);
        }

        //CREATING a NEW METHOD CALLED "RetirementCalculator"
        //It should take an int as a parameter representing the users age.
        //The method should calciulate how many more years until the user retires at 65
        //the return type should be void.
        //once it falculates the user retirment ate it should print
        //'the user will retire in X years' where X is the calculated value

        public static void RetirementCalculator(int age)
        {
            int yrsToRetire = 65 - age;
            Console.WriteLine("The user will retire in " + yrsToRetire + " years.");
        }

        //Create a method called WageCalculator.
        //It should take two double parameters.
        //One should represent the hours worked per day and the other represent the hourly wage. 
        //The return type should be of type of double.
        //The method should calculate the monthly wage.
        //Once it calculates the monthly wage it should return that value

        public static double WageCalculator(double hoursPerDay, double hourlyWage)
        {
            double monthlyWage = hourlyWage * hoursPerDay * 25;//assumes 25 days/month worked
            return monthlyWage;
        }


        //Create two methods of your choosing.At least one of the methods should have a non-void return type.
        //Both of the methods should take at least one parameter
        //Remember when naming your method that it should represent what your method should do.
        //Your method should only aim to accomplish one thing.
        //Be creative.

        //1)Creating a new method called NumberCubed
        public static int NumberCubed(int number)
        {
            int cubeNum = number * number * number;
            return cubeNum;
        }

        //2)Creating a new method called YourAlienName
        public static string YourAlienName(string firstName)
        {
            string alienAlias = firstName[0] + "ooky" +" " + firstName[firstName.Length-1] + "oolawaga";
            return alienAlias;
        }

        ////////////////////////////////////Thar be dragons here!/////////////////////////////////
    }
}
