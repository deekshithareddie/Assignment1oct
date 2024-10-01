using System;
namespace Calculator
{
    public class Calculator
    {
        public static void Main(string[] args)
        {
            decimal Addition(int a, int b)
            {
                return a + b;
            }
            decimal Subtraction(int a, int b)
            {
                return a - b;
            }
            decimal Mutiplication(int a, int b)
            {
                return a * b;
            }
            decimal Division(int a, int b)
            {
                return a / b;
            }
            Console.WriteLine("CALCULATOR OPENING...");
            Console.WriteLine("*************************");

            int flag = 0;
            while (flag==0) 
           {
            Console.WriteLine("please enter your choice :");
            Console.WriteLine("1.Addition \n2.Subtraction \n3.Multiplication\n4.Division\n5.EXIT");

            int choices = Convert.ToInt32(Console.ReadLine());
            if(choices == 5)
                {
                    Console.WriteLine("THANKYOU-visit again🙏");
                    break;
                }
            Console.WriteLine("enter first number");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            int number2 = Convert.ToInt32(Console.ReadLine());

                switch (choices)
                {
                    case 1:
                        {
                            Console.WriteLine("addition is :");
                            Console.WriteLine(Addition(number1, number2));
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Subtraction is:");
                            Console.WriteLine(Subtraction(number1, number2));
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("multiplication is :");
                            Console.WriteLine(Mutiplication(number1, number2));
                            break;
                        }
                    case 4:
                        {
                            try
                            {
                                var result = number1 / number2;
                                Console.WriteLine("Division is :");
                                Console.WriteLine(result);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error : INVALID INPUT");
                            }
                            break;
                        }

                    //case 5:
                    //    {
                    //        Console.WriteLine("Thankyou VISIT AGAIN");
                    //        flag = 1;
                    //        break;
                    //    }
                
                }
            }
        
        }
    }
}



