using System;
using System.Collections.Generic;

namespace Collections_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = {0,1,2,3,4,5,6,7,8,9};
            string[] names = {"Tim","Martin","Nikki","Sara"};
            bool[] arr3 = {true,false,true,false,true,false,true,false,true,false};

            // MultiTable(1,10);
            string[] iceCream = {"vanilla","chocolate","mint","cookie doe","sherbert"};
            // Flavors(iceCream);
            Info(names,iceCream);
        }
        static void MultiTable(int start, int end){
            // int[] arr = new int [end];
            // for(int i=start; i<=end; i++){
            //     arr[i-1] = i;
            //     Console.WriteLine(arr[i-1]);
            // }
            // for(int i=start; i<=end; i++){
            //     for(int iii=0; iii<arr.Length; iii++){
            //         arr[iii] = arr[iii] * i;
            //     }
            //     Console.WriteLine(string.Join("\n", arr));
            //     for(int ii=0; ii<arr.Length; ii++){
            //         arr[ii] = ii+1;
            //     }
            // }
            int[,] arrM = new int[end,end];
            for(int i=start; i<=end; i++){
                for(int ii=start; ii<=end; ii++){
                    arrM[i-1,ii-1] = ii*(i);
                    Console.WriteLine(arrM[i-1,ii-1]);
                }
            }
        }
        static void Flavors(string[] flav){
            List<string> flavors = new List<string>();
            for(int i=0; i<flav.Length; i++){
                flavors.Add(flav[i]);
            }
            Console.WriteLine(flavors.Count);
            Console.WriteLine(flavors[2]);
            flavors.RemoveAt(2);
            Console.WriteLine(flavors.Count);
        }
        static void Info(string[] name, string[] flav){
            Dictionary<string,string> info = new Dictionary<string, string>();
            Random rand = new Random();
            for(int i=0; i<name.Length;i++){
                info.Add(name[i],flav[rand.Next(0,flav.Length-1)]);
            }
            foreach (KeyValuePair<string,string> entry in info){
                Console.WriteLine(entry.Key + "-" + entry.Value);
            }
        }
    }
}
