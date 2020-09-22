using System;
using System.Collections.Generic;
using System.Text;

namespace CSDemo3
{
    static class TemplateExample
    {
        public static void Run()
        {
            #region FirstExample
            //int i1 = 1, i2 = 2;
            //float f1 = 1.1f, f2 = 1.2f;
            //string s1 = "First", s2 = "Second";

            //Swap(ref s1, ref s2);

            //Console.WriteLine(i1);
            //Console.WriteLine(i2);

            //Console.WriteLine(f1);
            //Console.WriteLine(f2);

            //Console.WriteLine(s1);
            //Console.WriteLine(s2);
            #endregion

            #region SecondExample
            //Printer<int> stringPrinter = new Printer<int>(1);

            //IList<int> intList = new List<int>();

            //for(int i = 0; i < 10; i++)
            //{
            //    intList.Add(i);
            //}

            //foreach(int i in intList)
            //    Console.WriteLine(i);
            #endregion

            #region VarExample
            var customColor = new
            {
                name = "ColorName",
                r = 240,
                g = 200,
                b = 100
            };

            #endregion


        }

        public static T1 Swap<T1>(ref T1 first, ref  T1 second)
        {
            T1 temp = first;
            first = second;
            second = temp;

            return temp;
        }

        class Printer<T>
        {
            public T value;

            public Printer(T value)
            {
                this.value = value;
            }

            public void Print()
            {
                Console.WriteLine(value);
            }

        }


    }
}
