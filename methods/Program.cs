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
            int number1 = 25;
            int number2 = 50;
            int total = Add(number1,number2);//note that these are not the same numbers as we defined the method
            Console.WriteLine(total);
            int multTotal = Multiply(number1, number2);//do not need to create this variable
            Console.WriteLine(multTotal);
            //another way to do the same thing
            Console.WriteLine(Multiply(number1, number2));
            Greeting();
            string name = "Will Robinson";
            RobotWarning(name);


        }
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

        //CREATING A NEW METHOD CALLED "
        public static void RobotWarning(string name)
        {
            Console.WriteLine("Danger, " + name);

        }
    }
}
