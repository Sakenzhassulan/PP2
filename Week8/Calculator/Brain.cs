using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    enum Calcstate
    {
        Zero,
        AccumulateDigit,
        Operation,
        Result
    }
    public delegate void ChangeTextDelegate(string msg);
    class Brain
    {
        ChangeTextDelegate changeTextDelegate;
        Calcstate calcstate = Calcstate.Zero;
        string tempNumber = "";
        string resultNumber = "";
        string operation = "";
        public Brain(ChangeTextDelegate changeTextDelegate)
        {
            this.changeTextDelegate = changeTextDelegate;
        }
        public void Process(string msg)
        {
            switch (calcstate)
            {
                case Calcstate.Zero:
                    Zero(msg, false);
                    break;
                case Calcstate.AccumulateDigit:
                    AccumulateDigit(msg, false);
                    break;
                case Calcstate.Operation:
                    Operation(msg, false);
                    break;
                case Calcstate.Result:
                    Result(msg, false);
                    break;
                default:
                    break;
            }
        }
        void Zero(string msg, bool IsInput)
        {
            if (IsInput)
            {
                calcstate = Calcstate.Zero;
            }
            else
            {
                if (Rules.IsNonZeroDigit(msg))
                {
                    AccumulateDigit(msg, true);
                }
            }
        }
        void AccumulateDigit(string msg, bool IsInput)
        {
            if (IsInput)
            {
                calcstate = Calcstate.AccumulateDigit;
                tempNumber += msg;
                changeTextDelegate.Invoke(tempNumber);
            }
            else
            {
                if (Rules.IsDigit(msg))
                {
                    AccumulateDigit(msg, true);
                }
                else if (Rules.IsOperation(msg))
                {
                    Operation(msg, true);
                }
                else if (Rules.IsResult(msg))
                {
                    Result(msg, true);
                }
            }
        }
        void Operation(string msg, bool IsInput)
        {
            if (IsInput)
            {
                calcstate = Calcstate.Operation;
                if(operation.Length != 0)
                {
                    PerformCalculation(); 
                    changeTextDelegate(resultNumber);
                    //tempNumber = "";
                }
                if (resultNumber == "")
                {
                    resultNumber = tempNumber;
                }
                operation = msg;
                tempNumber = "";
            }
            else
            {
                if (Rules.IsDigit(msg))
                {
                    AccumulateDigit(msg, true);
                }
            }
        }
        void Result(string msg, bool IsInput)
        {
            if (IsInput)
            {
                calcstate = Calcstate.Result;
                PerformCalculation();
                operation = "";
                changeTextDelegate.Invoke(resultNumber);
            }
            else
            {
                if (Rules.IsOperation(msg))
                {
                    Operation(msg, true);
                }
            }
        }
        void PerformCalculation()
        {
            if (operation == "+")
            {
                resultNumber = (int.Parse(tempNumber) + int.Parse(resultNumber)).ToString();
            }
            else if (operation == "-")
            {
                resultNumber = (int.Parse(resultNumber) - int.Parse(tempNumber)).ToString();
            }
            else if (operation == "*")
            {
                resultNumber = (int.Parse(resultNumber) * int.Parse(tempNumber)).ToString();
            }
            else if (operation == "/")
            {
                resultNumber = (int.Parse(resultNumber) / int.Parse(tempNumber)).ToString();

                changeTextDelegate.Invoke(resultNumber);
            }
        }
    }
}
