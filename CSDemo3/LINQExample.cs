using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSDemo3
{
    static class LINQExample
    {
        public static void Run()
        {
            List<int> intList = new List<int>();

            var rng = new Random();

            for(int i = 0; i < 100; i++)
            {
                intList.Add(rng.Next(0,100));
            }
            
            for(int i = 1; i <= intList.Count; i++)
            {
                Console.Write(intList[i-1]);
                Console.Write("\t");
                if (i % 10 == 0) Console.WriteLine();
            }

            Console.WriteLine();

            IEnumerable<int> enumList = intList;

            //int counter = 0;
            //foreach (int i in enumList)
            //    if (i % 2 == 0) counter++;

            //Console.WriteLine(counter);
            //Console.WriteLine();
            //counter = 0;

            //var enm = enumList.GetEnumerator();
            //for ( ; enm.MoveNext(); )
            //    if (enm.Current % 2 == 0) counter++;

            //Console.WriteLine(counter);

            //Console.WriteLine();

            var nList =
                //from i in enumList
                //where i < 50 && i % 3 == 0
                //select i;
                enumList
                .Where((num, index) => index % 2 == 0)
                .Select((i) => (float)i / 2);



            foreach (var i in nList)
                Console.WriteLine(i);

        }
    }
}
