using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    class Indexer
    {
        //public static void Main(string [] args)
        //{
        //    int adapted = 126;
        //    IntBits bits = new IntBits(adapted);
        //    //bool peak = bits[6];
        //    //bits[0] = true;
        //    //bits[3] = false;
        //    //Console.WriteLine(bits[0]);  
        //}
    }
    struct IntBits
    {
        private int bits;
        //Phone number 
        private int _phoneNumber;

        public IntBits(int initialBitValue)
        {
            bits = initialBitValue;
            _phoneNumber = initialBitValue;
        }
        //public bool this [int index]
        //{
        //    get {
        //        return (bits & (1 << index)) != 0;
        //    }
        //    set {
        //        if (value)
        //        {
        //            bits |= (1 << index);

        //        }
        //        else
        //        {
        //            bits &= ~(1 << index);
        //        }
        //    }
        //}

        
    }
}
