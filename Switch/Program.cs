using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 1 number");
            Int16 num1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Please enter / for divide, * for multiple, + for addition, - for minus");
            char opr = Convert.ToChar(Console.ReadLine());
            
            Console.WriteLine("Please enter 1 number");
            Int16 num2 = Convert.ToInt16(Console.ReadLine());
            Double k = cal(num1, opr, num2);
            Console.WriteLine(k);
            //Console.WriteLine(args);
            Console.Read();
        }
        static Double cal(Int16 int16num1, char opr, Int16 int16num2){
            Double doubleResult = 0;
            switch (opr)
            {
                case '/':
                    doubleResult = int16num1 / int16num2;
                    break;
                case '*':
                    doubleResult = int16num1 * int16num2;
                    break;
                case '+':
                    doubleResult = int16num1 + int16num2;
                    break;
                case '-':
                    doubleResult = int16num1 - int16num2;
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
            return doubleResult;
        }
    }
}
