using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Comparer<T> where T : class
    {
        
        /*
         * object is not type safe
         * unwanted boxing and unboxing is happening
         * 
         * boxing:- Boxing is conversion of value to reference
         * unboxing :- is conversion of reference to value
         */
        //public bool CheckEquality(object a, object b)
        //{
        //    return a.Equals(b);
        //}

        public bool CheckEquality(T a, T b)
        {
            return a.Equals(b);
        }
    }
}
