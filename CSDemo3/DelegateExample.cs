using System;
using System.Collections.Generic;
using System.Text;

namespace CSDemo3
{
    static class DelegateExample
    {

        //public delegate int MyMathOperation(int x, int y);

        public static void Run()
        {
            int i1 = 1, i2 = 2;

            #region Explicit delegate
            //MyMathOperation op =
            //    delegate (int x, int y)
            //    {
            //        return x * y;
            //    };

            #endregion

            #region Func delegate
            //Func<int,int,int> op =
            //    delegate (int x, int y)
            //    {
            //        return x * y;
            //    };

            //Console.WriteLine(op(i1, i2));

            //op = Add;

            //Console.WriteLine(op(i1, i2));

            #endregion

            Func<int> op = () =>  i1 * i2;


            Console.WriteLine(op());

            op = () =>
            {
                int j = Add(i1, i2);
                return ++j;
            };

            Console.WriteLine(op());


        }

        public static int Add(int i, int j)
        {
            return i + j;
        }

        public static int Substract(int i, int j)
        {
            return i - j;
        }

    }
}
