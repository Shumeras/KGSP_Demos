using System;
using System.Collections.Specialized;

namespace CSDemo2
{

    enum WeekDays
    {
        MONDAY,
        TUESDAY,
        WEDNESDAY,
        THURSDAY,
        FRIDAY,
        SATURDAY,
        SUNDAY
    }


    class Program
    {
        static int? i;
        static bool b = true;
        static float f = 2.0f;
        
        static void Main(string[] args)
        {

            #region General_Typecast_Example
            i = 10;

            if(i != null)
                f += (int)i;

            i = (int)f;

            i = (b == true ? 1 : 0);

            #endregion

            #region Polymorphism_Example
            //Animal a = new Animal();
            Cat c = new Cat();
            Dog d = new Dog();
            
            Animal a1 = c;
            Animal a2 = d;

            //c.MakeASound();
            //a1.MakeASound();

            //d.MakeASound();
            //a2.MakeASound();

            #endregion

            #region Interface_Example

            Speaker s = new Speaker();

            ISoundable a = c,
                    e = new Radio();

            //a.MakeASound();
            //e.MakeASound();

            //s.MakeASound();
            //s.MakeASound("Yelling!");
            #endregion

            #region Encapsulation_Example

            //Radio r = new Radio();

            //r.ChangeStation();
            //r.MakeASound();
            //r.ChangeStation();
            //r.MakeASound();
            //r.ChangeStation();
            //r.MakeASound();

            #endregion

            #region Reference_Example

            //int[] integers = { 1, 2, 3, 4, 5};

            //foreach(int i in integers)
            //{
            //    Console.WriteLine(i);
            //}

            //func(integers);

            //Console.WriteLine();

            //foreach (int i in integers)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Enum_Example
            WeekDays w = 0;

            //for(int i = 0; i < 7; i++)
            //{
            //    Console.WriteLine(w++);
            //}

            //Console.WriteLine(w);
            #endregion


            #region Type_Typecast_Example
            //Console.WriteLine(i.GetType());
            //Console.WriteLine(w.GetType());

            //Console.WriteLine(default(int));
            //Console.WriteLine(default(WeekDays));

            Cat c2 = a1 as Cat;
            Console.WriteLine(c2.GetType());

            #endregion
        }

        public static void func(int[] i)
        {
            for(int j = 0; j < i.Length; j++)
            {
                i[j]++;
            }
        }
    }

    abstract class Animal: ISoundable
    {
        public abstract void MakeASound();
    }

    class Cat : Animal
    {
        public override void MakeASound()
        {
            Console.WriteLine("Meow!");
        }
    }

    class Dog : Animal
    {
        public override void MakeASound()
        {
            Console.WriteLine("Woof!");
        }
    }

    class Electronics {}

    class Radio : Electronics, ISoundable
    {

        protected string sound = "*Plays Music*";

        public void ChangeStation()
        {
            Random rng = new Random();
            switch (rng.Next(3))
            {
                case 0:
                    sound = "*Plays Music*";
                break;
                case 1:
                    sound = "Chit chat!";
                break;
                case 2:
                    sound = "Comercial!";
                break;
                default:
                    sound = "*Static*";
                break;
            }

        }

        public void MakeASound()
        {
            Console.WriteLine(sound);
        }
    }

    class Speaker : Radio
    {

        public string Sound
        {
            get => sound;
            private set => sound = value;
        }

        public void MakeASound(string s)
        {
            sound = s;
            Console.WriteLine(s);
        }
    }

    interface ISoundable
    {
        void MakeASound();
    }


}
