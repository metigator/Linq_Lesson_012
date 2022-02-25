using Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQTut12.Equality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunMethod3();
            Console.ReadKey();
        }

        static void RunMethod1()
        {
            var q1 = QuestionBank.PickOne();
            var q2 = QuestionBank.PickOne();
            var q3 = QuestionBank.PickOne();

            var quiz1 = new List<Question>(new [] { q1, q2, q3 });
            var quiz2 = new List<Question>(new [] { q1, q2, q3 });

            var equal = quiz1.SequenceEqual(quiz2);
            Console.WriteLine($"quiz#1 and quiz#2 {(equal ? "are" : "are not")} equal");
        }

        static void RunMethod2()
        {
            var ramdomFourQuestion =
                QuestionBank.GetQuestionRange(Enumerable.Range(1, 4));

            var quiz1 = ramdomFourQuestion;
            var quiz2 = ramdomFourQuestion;

            var equal = quiz1.SequenceEqual(quiz2);
            Console.WriteLine($"quiz#1 and quiz#2 {(equal ? "are" : "are not")} equal");
        }
        static void RunMethod3()
        { 
            var quiz1 = QuestionBank.GetQuestionRange(Enumerable.Range(1, 4));
            var quiz2 = QuestionBank.GetQuestionRange(Enumerable.Range(1, 4));

            var equal = quiz1.SequenceEqual(quiz2);
            Console.WriteLine($"quiz#1 and quiz#2 {(equal ? "are" : "are not")} equal");
        }

    }
}
