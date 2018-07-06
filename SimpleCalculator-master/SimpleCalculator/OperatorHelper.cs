using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class OperatorHelper
    {
        public static string GetOperator(string opration)
        {
            string op;
            switch(opration)
            {
                case "add" :
                    op = "+";
                    break;
                case "subtract":
                    op = "-";
                    break;
                case "multiply":
                    op = "*";
                    break;
                case "divide":
                    op = "/";
                    break;
                default:
                    throw new NotSupportedException("Specified operation is not supported");
            }
            return op;
        }
    }
}
