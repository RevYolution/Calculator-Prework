using System;

namespace Calculator_Prework
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber;
            double secondNumber;
            Console.WriteLine("Please input 2 numbers: ");

            //User inputs first number
            Console.WriteLine("Type your first number then hit Enter:");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(firstNumber);

            //User inputs second number
            Console.WriteLine("Type your second number then hit Enter:");
            secondNumber = Convert.ToDouble(Console.ReadLine());

            //User selects what kind of mathmatical operation they want to perform
            Console.WriteLine("Select math to be done:");
            Console.WriteLine("Hit 1 for Addition");
            Console.WriteLine("Hit 2 for Subtraction");
            Console.WriteLine("Hit 3 for Multiplication");
            Console.WriteLine("Hit 4 for Division");
            int selection = Convert.ToInt32(Console.ReadLine());

            //Based off user selection mathmatical operation will be chosen and performed
            switch(selection)
            {
                case 1:
                    {
                        double resultSelection1 = Addition(firstNumber, secondNumber);
                        Console.WriteLine("The result of ({0}) + ({1}) is ({2})", firstNumber, secondNumber, resultSelection1);
                        break;
                    }
                case 2:
                    {
                        double resultSelection2 = Subtraction(firstNumber, secondNumber);
                        Console.WriteLine("The result of ({0}) - ({1}) is ({2})", firstNumber, secondNumber, resultSelection2);
                        break;
                    }
                case 3:
                    {
                        double resultSelection3 = Multiplication(firstNumber, secondNumber);
                        Console.WriteLine("The result of ({0}) * ({1}) is ({2})", firstNumber, secondNumber, resultSelection3);
                        break;
                    }
                case 4:
                    {
                        double resultSelection4 = Divison(firstNumber, secondNumber);
                        Console.WriteLine("The result of ({0}) / ({1}) is ({2})", firstNumber, secondNumber, resultSelection4);
                        break;
                    }
            }

        }

        //Addition of two numbers
        public static double Addition(double firstNumber, double secondNumber)
        {
            double addResult = firstNumber + secondNumber;
            return addResult;
        }

        //Subtraction of two numbers
        public static double Subtraction(double firstNumber, double secondNumber)
        {
            double subResult = firstNumber - secondNumber;
            return subResult;
        }

        //Multiplication of two numbers
        public static double Multiplication(double firstNumber, double secondNumber)
        {
            double multiResult = firstNumber * secondNumber;
            return multiResult;
        }

        //Division of two numbers
        public static double Divison(double firstNumber, double secondNumber)
        {
            double divResult = firstNumber / secondNumber;
            return divResult;
        }


    }
}
