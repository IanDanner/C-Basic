using System;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            // Loop(1, 255);
            DivLoop(1,100);
        }
        static void Loop(int start,int end){
            for(int i=start; i<=end; i++){
                Console.WriteLine(i);
            }
        }
        static void DivLoop(int start,int end){
            for(int i=start; i<=end; i++){
                if(i%5==0 && i%3==0){
                    Console.WriteLine("FizzBuzz " + i);
                }
                if(i%5==0){
                    Console.WriteLine("Buzz " + i);
                }
                if(i%3==0){
                    Console.WriteLine("Fizz " + i);
                }
            }
        }
    }
}
