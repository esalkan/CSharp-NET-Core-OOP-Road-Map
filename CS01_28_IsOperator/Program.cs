﻿namespace CS01_28_IsOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Is Operator
             * bool varName = variable is varType
             *
             * Eldeki nesnenin tipini tanımlamamızı sağlar. Yani hangi tipten(classtan) bir nesne olduğunu is operatörü ile sorgulayabilmekteyiz.
             * It allows us to define the type of object at hand. In other words, we can query which type (class) an object is with the is operator.
             */

            int s1 = 50;
            
            object o1 = s1;
            Console.WriteLine(s1);
            s1 = (int)o1;
            //s1 = (byte)o1;

            bool control1 = o1 is int;
            bool control2 = o1 is byte;
            bool control3 = o1 is short;
            bool control4 = o1 is decimal;
            Console.WriteLine(control1);
            Console.WriteLine(control2);
            Console.WriteLine(control3);
            Console.WriteLine(control4);
        }
    }
}