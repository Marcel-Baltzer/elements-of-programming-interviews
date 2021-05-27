using System;
using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._05._StacksAndQueues._02._RpnExpression
{
    public class Solution
    {
        public static int Eval(string rpnExpression)
        {
            var intermediateResults = new Stack<int>();
            const string delimiter = ",";
            var symbols = rpnExpression.Split(delimiter);

            foreach (var token in symbols)
            {
                if (token.Length == 1 && "+-*/".Contains(token))
                {
                    var y = intermediateResults.Pop();
                    var x = intermediateResults.Pop();

                    switch (token[0])
                    {
                        case '+':
                            intermediateResults.Push(x + y);
                            break;
                        case '-':
                            intermediateResults.Push(x - y);
                            break;
                        case '*':
                            intermediateResults.Push(x * y);
                            break;
                        case '/':
                            intermediateResults.Push(x / y);
                            break;
                        default:
                            throw new InvalidOperationException($"Malformed RPN at : {token}");
                    }
                }
                else
                {
                    intermediateResults.Push(short.Parse(token));
                }
            }

            return intermediateResults.Pop();
        }
    }
}