using System;
using System.Collections.Generic;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] stuff = {7,28,-1,true,"chair"};
            Box(stuff);
        }
        static void Box(object[] stuff){
            List<object> things = new List<object>();
            int sum = 0;
            for(int i=0;i<stuff.Length;i++){
                things.Add(stuff[i]);
            }
            for(var idx=0;idx<things.Count;idx++){
                Console.WriteLine(things[idx]);
                if(things[idx] is int){
                    sum += (int)things[idx];
                }
            }
            Console.WriteLine(sum);   
        }
    }
}
