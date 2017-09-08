using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPE200Lab1
{
    class RPNCalculatorEngine : CalculatorEngine

    {
        public string Process(string str)
        {
            string[] parts = str.Split(' ');
            Stack rpnstack = new Stack ();
            for(int i=0;i<parts.Length;i++)
            {
                if(parts[i] =="+" || parts[i] == "-" || parts[i] == "X" || parts[i] == "÷")
                {
                    string second = Convert.ToString(rpnstack.Pop());
                    string first = Convert.ToString(rpnstack.Pop());
                    rpnstack.Push(calculate(parts[i],first,second));


                }
                else
                {
                    rpnstack.Push(parts[i]);
                }
            }
            return Convert.ToString(rpnstack.Pop());

        }
    }
}
