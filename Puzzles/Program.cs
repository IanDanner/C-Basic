using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            // RandomArray(10,5,25);
            // TossCoin();
            // TossMultipleCoins(6);
            string[] allnames = {"Todd","Tiffany","Charlie","Geneva","Sydney","Ian"};
            Names(allnames);
        }
        //Random Array
        static int RandomArray(int num, int start, int end){
            Random rand = new Random();
            int[] arr = new int[num];
            int min = start;
            int max = start;
            int sum = 0;
            for(int i=0;i<arr.Length;i++){
                arr[i] = rand.Next(start,end);
                if(arr[i]<min){
                    min=arr[i];
                }
                if(arr[i]>max){
                    max=arr[i];
                }
                sum+=arr[i];
            }
            Console.WriteLine(min +" | "+max+" | "+sum);
            return sum;
        }
        //Coin Flip
        static string TossCoin(){
            Console.WriteLine("Tossing a Coin!");
            Random rand = new Random();
            for(int i=1;i<2;i++){
                int coin = rand.Next(0,2);
                if(coin < 0.5){
                    Console.WriteLine("Heads "+coin);
                }
                else{
                    Console.WriteLine("Tails "+coin);
                }
            }
            return "Done";
        }
        static string TossMultipleCoins(int num){
            Console.WriteLine("Tossing a Coin x"+num);
            Random rand = new Random();
            for(int i=0;i<num;i++){
                int coin = rand.Next(0,2);
                if(coin < 0.5){
                    Console.WriteLine("Heads "+coin);
                }
                else{
                    Console.WriteLine("Tails "+coin);
                }
            }
            return "Done";
        }
        //Names
        static string[] Names(string[] arr){
            int count = 0;
            Random rand = new Random();
            for(int i=0;i<arr.Length;i++){
                if(arr[i].Length>=5){
                    count++;
                }
                int rando = rand.Next(0,arr.Length-1);
                string temp = arr[i];
                arr[i] = arr[rando];
                arr[rando] = temp;
            }
            string[] names = new string[count+1];
            int count2 = 0;
            for(int i=0;i<arr.Length;i++){
                if(arr[i].Length>=5){
                    names[count2]=arr[i];
                    Console.WriteLine(names[count2]);
                    count2++;
                }
                Console.WriteLine(arr[i]);
            }
            return names;
        }
    }
}
