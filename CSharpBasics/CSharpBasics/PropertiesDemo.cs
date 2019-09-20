using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    class PropertiesDemo
    {

        //public static void Main(string[] args)
        //{
        //    Console.WriteLine("Old Approach Case 1");
        //    ScreenPostion objS1 = new ScreenPostion(500, 200);
        //    objS1._x1 = 100;
        //    Console.WriteLine(objS1.rangeCheckX(objS1._x1));
        //    //Output = 100 // Violation of field becuase we can modified after assigning 500 to thw _x

        //    //Case 2 - we can make the fields provate but then we have to implement Get & Set method inside the function to over come this problem
        //    Console.WriteLine("Old Approach Case 2");
        //    ScreenPostion objS2 = new ScreenPostion();
        //    objS2.SetX(100);
        //    objS2.Sety(400);

        //    Console.WriteLine(objS2.rangeCheckX(objS2.GetX()));
        //    Console.WriteLine(objS2.rangeCheckX(objS2.GetX()));

        //    //Output 100 400 - this approach is good but by using properties you can write fields and methods to retain the enacapsulation

        //    // New Way - 
        //    Console.WriteLine("New way of Implementing Properities");
        //    ScreenPostion objS3 = new ScreenPostion();
        //    objS3.x3 = 100;
        //    objS3.y3 = 5000;
        //    Console.WriteLine(objS3.x3);
        //    Console.WriteLine(objS3.y3);

        //    //Read Only
        //    Console.WriteLine("Read only Properties");
        //    ScreenPostion objS4 = new ScreenPostion();
        //    Console.WriteLine(objS4.X4);
        //    Console.WriteLine(objS4.Y4);

        //    //Write Only
        //    Console.WriteLine("Write Only Properties");
        //    ScreenPostion objS5 = new ScreenPostion()
        //    {
        //        X5 = 105,
        //        Y5 = 345
        //    };

        //    // Interface Properties
        //    Console.WriteLine("Interface Properties");
        //    ScreenPostion objS6 = new ScreenPostion();
        //    objS6.X6 = 151;
        //    objS6.Y6 = 182;
        //    Console.WriteLine(objS6.X6);
        //    Console.WriteLine(objS6.Y6);

        //    Console.ReadKey();

        //}

    }
    interface IPropertyDemo
    {
         int X6 { get; set; }
         int Y6 { get; set; }
    }
    public class ScreenPostion :IPropertyDemo
    {
        //Old way
        // Case 1;
        public int _x1;
        public int _y1;
        //case 2
        private int _x2;
        private int _y2;







        //New way

        private int _x3;
        private int _y3;
        public int x3
        {
            get
            {
                return _x3;
            }
            set
            {
                this._x3 = rangeCheckX(value);
            }
        }
        public int y3
        {
            get
            {
                return _y3;
            }
            set
            {
                this._y3 = rangeCheckY(value);
            }
        }



        //Read only 
        private int _x4 = 10;
        private int _y4=30;
        public int X4
        {
            get
            {
                return this._x4;
            }
        }
        public int Y4
        {
            get
            {
                return this._y4;
            }
        }

        //Write only Properties
        private int _x5;
        private int _y5;

        public int X5 {  set
            {
                this._x5 = rangeCheckX(value);
            }
        }
        public int Y5
        {
            set
            {
                this._x5 = rangeCheckY(value);
            }
        }


        //Properties Declaration with access modifiers


        //Interface properties
        private int _x6;
        private int _y6;

        public int X6 { get => _x6; set { this._x6 = rangeCheckX(value); } }
        public int Y6 { get => _y6; set { this._y6 = rangeCheckY(value); } }

        public ScreenPostion()
        { }
        public ScreenPostion(int x, int y)
        {
            this._x1 = x;
            this._y1 = y;
        }
        public int rangeCheckX(int x)
        {
            if (x > 0 && x < 1000)
                return x;
            else
            {
                // throw new ArgumentOutOfRangeException("Invalid x");
                return 0; 
            }
        }

        public int rangeCheckY(int y)
        {
            if (y > 0 && y < 1450)
                return y;
            else
            {
                // throw new ArgumentOutOfRangeException("Invalid y");
                return 0;
            }
        }

        // Case 2 .

        //Get
        public int GetX()
        {
            return this._x2;
        }
        public int GetY()
        {
            return this._y2;
        }
        //Set 
        public void SetX(int x2)
        {
            this._x2 = x2;
        }
        public void Sety(int y2)
        {
            this._y2 = y2;
        }

    }
}
