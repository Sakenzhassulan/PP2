﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task2
{
    public delegate void MyDelegate(string message);
    class Calculator
    {
        MyDelegate myDelegate;
        public Calculator(MyDelegate myDelegate)
        {
            this.myDelegate = myDelegate;
        }
        public void Calc()
        {
            Thread.Sleep(2000);
            myDelegate.Invoke("Finished!");
        }
    }
}
