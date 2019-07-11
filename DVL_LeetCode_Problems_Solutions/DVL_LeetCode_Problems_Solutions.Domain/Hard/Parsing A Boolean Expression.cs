using System;
using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Parsing A Boolean Expression (Mine)
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public static bool ParseBoolExpr(string expression) =>
        //{
            expression switch
        {
            "t" => true,
            "f" => false,
            var s when string.IsNullOrEmpty(s) => throw new NotImplementedException("Expression was Null"),
            var s when s.StartsWith("!") => !ParseBoolExpr(expression.Substring(2, expression.Length - 3)),
            var s when s.StartsWith("&") => expression.Substring(2, expression.Length - 3).ParseBoolExprHelperSplitter().All(exp => ParseBoolExpr(exp)),
            var s when s.StartsWith("|") => expression.Substring(2, expression.Length - 3).ParseBoolExprHelperSplitter().Any(exp => ParseBoolExpr(exp)),
                _ => throw new NotImplementedException("First Character was Invalid")
        };
        //if (expression == "t")
        //    return true;
        //if (expression == "f")
        //    return false;

        //if (expression[0] == '!')
        //    return !ParseBoolExpr(expression.Substring(2, expression.Length - 3));
        //if (expression[0] == '&')
        //    return ParseBoolExprHelperSplitter(expression.Substring(2, expression.Length - 3)).All(exp => ParseBoolExpr(exp));
        //if (expression[0] == '|')
        //    return ParseBoolExprHelperSplitter(expression.Substring(2, expression.Length - 3)).Any(exp => ParseBoolExpr(exp));

        //throw new NotImplementedException("First Character was Invalid");
        //}

        private static List<string> ParseBoolExprHelperSplitter(this string expression)
        {
            var list = new List<string>();

            int counter = 0, stIndex = 0;
            for (int i = 0; i < expression.Length; i++)
                if (expression[i] == '(')
                    counter++;
                else if (expression[i] == ')')
                    counter--;
                else if (expression[i] == ',' && counter == 0)
                {
                    list.Add(expression.Substring(stIndex, i - stIndex));
                    stIndex = i + 1;
                }

            list.Add(expression.Substring(stIndex));

            return list;
        }

        //private static List<string> ParseBoolExprHelperSplitter(string expression)
        //{
        //    var list = new List<string>();

        //    int counter = 0, stIndex = 0;
        //    for (int i = 0; i < expression.Length; i++)
        //        if (expression[i] == '(')
        //            counter++;
        //        else if (expression[i] == ')')
        //            counter--;
        //        else if (expression[i] == ',' && counter == 0)
        //        {
        //            list.Add(expression.Substring(stIndex, i - stIndex));
        //            stIndex = i + 1;
        //        }

        //    list.Add(expression.Substring(stIndex));

        //    return list;
        //}
    }
}
