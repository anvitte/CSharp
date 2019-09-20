using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    class InheritanceDemo
    {
        //public static void Main(string[] args)
        //{
        //    Horse objH = new Horse("Horse1", "Mammals");
        //    Whale objM = new Whale("Whale1", "Mammals");
        //    objM.Show();
        //    objH.Show();

        //    //
        //    Horse objH1 = new Horse("Horse2", "Mammals");
        //    Mammals objMammals = objH1;
        //    objMammals.Breath();
        //    //It wll show the output

        //    //if we are assiging mammals object to horse object then we have to explicitly cast the Mammals objects to derived class
        //    Mammals objMammals2 = new Mammals("Horse3");
        //    Horse objH2 = objMammals as Horse;
        //    objH2.Breath();

        //    // Case 2 where first we define the whale class to mammals object and then we assign to horse object
        //    Whale objM2 = new Whale("Whale2", "Mammals");
        //    Mammals objMammals3 = objM2;
        //    if (objMammals3 is Horse)
        //    {
        //        Horse objH3 = objMammals3 as Horse;
        //        objH3.Show();
        //    }
        //    else
        //    {
        //        // Horse objH3 = objMammals3 as Horse; // Here compiler will throw the exception - Mammals is type of whale
        //        Console.WriteLine("Mammals Not type of horse");
        //    }

        //    // Suppose you have to two methods one method in parent class and one method in derived class with the same name 
        //    // To avoid the warning coming on the method name use 'new' before method Talk() in derived class
        //    Horse objH4 = new Horse("Horse4", "Mammals");
        //    objH4.Talk();


        //    // How to use overridding the method
        //    Horse objH5 = new Horse("Horse5", "Mammals");
        //    Console.WriteLine(objH5.OverrideMethod());

        //    // Extemsion Method

        //    int x = 100;
        //    x.Negate();
        //    //Or
        //    Util.Negate(x);
        //    //It will obviates the purpose of using the extension Method2


        //    // Interface
        //    //Case 1
        //    Horse objH6 = new Horse("Horse6", "Mammals");
        //    ILandBound objLandBound1 = objH6;
        //    Console.WriteLine(objLandBound1.NumberOfLegs());

        //    //Case 2 - when two interface having the same method - So explicitly we have to assign the object of horse to both the ineterface object to display the same method name
        //    Horse objH7 = new Horse("Horse6", "Mammals");
        //    ILandBound objLandBound2 = objH6;
        //    IJourney objJourney = objH6;
        //    Console.WriteLine(objLandBound1.NumberOfLegs());

        //    Console.WriteLine(objJourney.NumberOfLegs());

        //    //Abstract class
        //    Horse objH8 = new Horse("Horse7","Mammals");
        //    objH8.ChewGrass();


        //    Console.ReadKey();



        //}
    }
    abstract class GrazzingMammals : Mammals
    {
        public GrazzingMammals(string type) : base(type)
        {
        }
        public void ChewGrass()
        {
            Console.WriteLine("Chewing Grass");
        }
        //We can define abstract method also but note if we are defining abstract only then the class should be abstract
       // public abstract void ShowClassInfo();
    }


    internal interface IGrazable
    {
        void ChewGrass();
    }

    interface ILandBound
    {
        int NumberOfLegs();
    }
    interface IJourney
    {
        int NumberOfLegs();
    }
    static class Util
    {
        public static int Negate(this int i)
        {
            return -i;
        }
    }

    class Mammals
    {
        public string _name { get; set; }
        public string _type { get; set; }


        public Mammals(string type)
        {
            ;
            _type = type;
        }
        public void Show()
        {
            Console.WriteLine($"{ _name } is a type of {_type}");
        }
        public void Breath()
        {
            Console.WriteLine($"{_name} mammal can breath");
        }
        public void Talk()
        {
            Console.WriteLine("Mammals can talk");
        }

        public virtual string OverrideMethod()
        {
            return _name;
        }
    }
    class Horse : GrazzingMammals, ILandBound, IJourney
    {
        public Horse(string name, string type) : base(type)
        {
            _name = name;

        }
        //Added 'new' keyword before the method to avoid warning 
        new public void Talk()
        {
            Console.WriteLine("Horse can talk");
        }

        public override string OverrideMethod()
        {
            return _type;
        }

        int ILandBound.NumberOfLegs()
        {
            return 4;
        }
        int IJourney.NumberOfLegs()
        {
            return 3;
        }
    }
    class Whale : GrazzingMammals
    {
        public Whale(string name, string type) : base(type)
        {
            _name = name;

        }
    }

}
