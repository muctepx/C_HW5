using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem5
{
    internal interface ICalc
    {
       public event EventHandler<OperandChangedEventArgs> GetResult;
        void  Sum(int x);
        void Subtract(int x);
        void Multiply(int x);
        void Divide(int x);
        void CancelLast();


    }
}
