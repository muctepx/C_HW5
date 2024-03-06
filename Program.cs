using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sem5
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 ,9, 10, 11, 12, 13, 14};
        var result = nums.MyWhere(x=>x%2 ==0);
            foreach(var x in result) 
            {
                Console.WriteLine(x);
            }
            */


            /*
             * Задача 2
             * Спроектируем интерфейс калькулятора, поддерживающего простые арифметические действия, хранящего результат и также способного выводить информацию о результате  при помощи события
             
            */
            ICalc calculator = new Calculator();
            calculator.GetResult += Calculator_GetResult;
            Console.Write("Введите число: ");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите операцию: ");
            string operation = Convert.ToString(Console.ReadLine());
            

            switch (operation)
            {
                case "+":
                    calculator.Sum(number);
                    break;
                case "-":
                    calculator.Subtract(number);
                    break;
                case "*":
                    calculator.Multiply(number);
                    break;
                case "/":
                    calculator.Divide(number);
                    break;
            }
            /*
            calculator.Sum(5);
            calculator.Divide(5);
            calculator.Multiply(5);
            calculator.Subtract(5);
            calculator.CancelLast();
            calculator.CancelLast();
            calculator.CancelLast();
            */

        }
           
            private static void Calculator_GetResult(object? sender, OperandChangedEventArgs e)
       {
           Console.WriteLine(e.Operand);
        }
            /*
            Модифицируйте код калькулятора следующим образом реализовав представленный ниже интерфейс:
interface ICalc
        {
            event EventHandler<EventArgs> GotResult;
            void Add(int i);
            void Sub(int i);
            void Div(int i);
            void Mul(int i);
            void CancelLast();
        }


        Арифметические методы должны выполняться как обычно а метод CancelLast должен отменять последнее действие.При этом метод может отменить последовательно все действия вплоть до самого последнего.Спросите как студенты планируют реализовать отмену действия и если будут трудности с ответами то подскажите им про стек
            */

        }
    }
