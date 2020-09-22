using System;
using System.Collections.Generic;
using System.Text;

namespace CSDemo3
{

    static class EventExample
    {

        public static event EventHandler<MyEventArgs> myEvent = (o, x) => { };

        public static void Run()
        {

            myEvent += OnMyEvent;
            myEvent(null, new MyEventArgs());

            myEvent -= OnMyEvent;
            myEvent.Invoke(null, new MyEventArgs());
            myEvent = null;

        }

        public static void OnMyEvent(object o, MyEventArgs msg)
        {
            Console.WriteLine($"I heard {msg.num}");
        }

        public class MyEventArgs : System.EventArgs
        {
            public int num = 1;
            public string name = "name";
            //....
        }

    }
}
