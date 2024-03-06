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
        void  Sum(double x);
        void Subtract(double x);
        void Multiply(double x);
        void Divide(double x);
        void CancelLast();


    }
}
