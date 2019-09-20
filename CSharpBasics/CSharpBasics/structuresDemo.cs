using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    class structuresDemo
    {
        //static void Main(string[] args)
        //{
        //    Test now = new Test(10,20,30);
        //    Test now1 = now;
        //    Console.WriteLine(now);
        //    Console.WriteLine(now1);
        //    Console.ReadKey();
            
            
        //}


    }
    struct Test
    {
        //Can not declare default contstructor with zero paramter
        //Test()
        //{

        //}

        private int hours, mins, secs;
        public Test(int h,int m,int s)
        {
            hours = h;
            mins = m;
            secs = s;

        }

        public override string ToString()
        {
            var time = $"{this.hours}:{this.mins}:{this.secs}";
            return time;
        }
    }
}
