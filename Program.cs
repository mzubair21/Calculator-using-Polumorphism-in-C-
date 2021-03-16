using System;

namespace Calculator_using_Polymorphism //Procject Name
{

    public class PerformCalculation //Encapsulation
    {
        private double[] num;
        public virtual double[] InputNumbers() // Virtual for Polumorphism
        {
            Console.WriteLine("Enter how many numbers you want to Evaluate? ");
            num = new double[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("Enter " + (i + 1) + " Number : ");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            return num;
        }
        public virtual double[] InputNumbers(int a, int b)   // Overloaded Function
        {
            num = new double[2];
            num[0] = a;
            num[1] = b;
            return num;
        }
        public virtual double Sum()
        {
            return 0;
        }
        public virtual double Products()
        {
            return 0;
        }
        public virtual double Subtraction()
        {
            return 0;
        }
        public virtual double DivideNow(int a, int b)
        {
            return 0;
        }
    }

    //Functions Overriding in below classes!
    public class Add : PerformCalculation // : used for inheritance
    {
        public override double[] InputNumbers()
        {
            return base.InputNumbers(); // base for running super constructor;
        }
        public override double Sum()
        {
            double sum = 0;
            double[] numbers = InputNumbers();
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

    }
    public class Product : PerformCalculation
    {
        public override double[] InputNumbers()
        {
            return base.InputNumbers();
        }
        public override double Products()
        {
            double prod = 1;
            double[] numbers = InputNumbers();
            for (int i = 0; i < numbers.Length; i++)
            {
                prod *= numbers[i];
            }
            return prod;
        }
    }
    public class Difference : PerformCalculation
    {
        public override double[] InputNumbers()
        {
            return base.InputNumbers();
        }
        public override double Subtraction()
        {
            double[] numbers = InputNumbers();
            double diff = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                diff -= numbers[i];
            }
            return diff;
        }
    }
    public class Division : PerformCalculation
    {
        public override double[] InputNumbers(int a, int b)
        {
            return base.InputNumbers(a, b);
        }
        public override double DivideNow(int a, int b)
        {
            double[] numbers = InputNumbers(a, b);
            return numbers[0] / numbers[1];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PerformCalculation p;
            int choice;
            string continueprogram = "Y";
            do
            {
                Console.WriteLine("\n--------Calculator--------\nPress 1: Sum \nPress 2: Subtract \nPress 3: Multiplication \nPress 4: Division \n5:Exit\nEnter Your Choice : ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            p = new Add();
                            Console.WriteLine("The Sum is = " + p.Sum());
                            break;
                        }
                    case 2:
                        {
                            p = new Difference();
                            Console.WriteLine("The Subtraction is = " + p.Subtraction());
                            break;
                        }
                    case 3:
                        {
                            p = new Product();
                            Console.WriteLine("The Product is = " + p.Products());
                            break;
                        }
                    case 4:
                        {
                            p = new Division();
                            int a, b;
                            Console.WriteLine("Enter 1 Number : ");
                            a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter 2 Number : ");
                            b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("The division is = " + p.DivideNow(a, b));
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\nThank You for using our Calculator\n");
                            break;
                        }
                }
                if (choice != 5)
                {
                    Console.WriteLine("\n --- Enter Y Key to Run Again ---");
                    continueprogram = Console.ReadLine();
                    if (continueprogram != "Y" || continueprogram != "y")
                    {
                        Console.WriteLine("\nThank You for using our Calculator\n");
                    }
                }
            } while (continueprogram == "Y" || continueprogram == "y");
        }
    }
}
