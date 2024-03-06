using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Sem5
{
    internal class Calculator : ICalc
    {


          public event EventHandler<OperandChangedEventArgs> GetResult;
           private Stack <double> stack = new Stack<double>();
          private double Result 
           { 
               get 
               {
                   return stack.Count() == 0? 0: stack.Peek();

               } 
               set 
               { 
                   stack.Push(value) ;
                   RaiseEvent();
               } 
           }

           public void CancelLast()
           {
               if (stack.Count > 0)
               {
                   stack.Pop();
                   RaiseEvent();
               }

           }
           public void RaiseEvent()
           {
               GetResult.Invoke(this, new OperandChangedEventArgs(Result));
           }
        

        public void Divide(double number)
        {
            if (number != 0)
            {
                Result /= number;
            }
            else
            {
                Console.WriteLine("Деление на ноль невозможно");
            }
            
        }

        public void Multiply(double number)
        {
             Result *=  number;
        }

        public void Subtract(double number)
        {
            Result -= number ;
        }

        public void Sum(double number)
        {
             Result += number;
        }
       
    }
}
