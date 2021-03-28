using System;
using System.Collections.Generic;

namespace Elements_of_Programming_Interviews.StacksAndQueues.RpnExpression
{
    public class Solution
    {
        public static int Eval(string rpnExpression)
        {
            var IntermediateResults = new Stack<int>();
            string delimiter = ",";
            string[] symbols = rpnExpression.Split(delimiter);

            foreach (var token in symbols)
            {
                if (token.Length == 1 && "+-*/".Contains(token))
                {
                    int y = IntermediateResults.Pop();
                    int x = IntermediateResults.Pop();

                    switch (token[0])
                    {
                        case '+':
                            IntermediateResults.Push(x + y);
                            break;
                        case '-':
                            IntermediateResults.Push(x - y);
                            break;
                        case '*':
                            IntermediateResults.Push(x * y);
                            break;
                        case '/':
                            IntermediateResults.Push(x / y);
                            break;
                        default:
                            throw new InvalidOperationException($"Malformed RPN at : {token}");
                    }
                }
                else
                {
                    IntermediateResults.Push(Int16.Parse(token));
                }
            }

            return IntermediateResults.Pop();
        }
    }
}