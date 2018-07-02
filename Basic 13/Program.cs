using System;
using System.Collections.Generic;

namespace Basic_13
{
    class Program
    {
        static void Main(string[] args)
        {
            // PrintNum(1,255);
            // PrintOdd(1,255);
            // PrintSum(0,255);
            int[] arr1 = {1,3,5,-8,-9,7,9,13};
            // IterArr(arr1);
            // FindMax(arr1);
            // FindAvg(arr1);
            // OddArr(1,255);
            // GreaterThan(arr1, 6);
            // SquareVal(arr1);
            // ElimNeg(arr1);
            // MinMaxAvg(arr1);
            // ShiftValArr(arr1);
            NumString(arr1);
        }
        // print num
        static int PrintNum(int start, int end){
            for(int i=start;i<=end;i++){
                Console.WriteLine(i);
            }
            return -1;
        }
        // print odd
        static int PrintOdd(int start, int end){
            for(int i=start;i<=end;i++){
                if(i%2!=0){
                    Console.WriteLine(i);
                }
            }
            return -1;
        }
        // print sum
        static int PrintSum(int start, int end){
            int sum = 0;
            for(int i=start;i<=end;i++){
                sum += i;
                Console.WriteLine("New number: "+i+" Sum: "+sum);
            }
            return -1;
        }
        // iterating arr
        static int IterArr(int[] arr){
            for(int i=0;i<arr.Length;i++){
                Console.WriteLine(arr[i]);
            }
            return -1;
        }
        // find max
        static int FindMax(int[] arr){
            int max = arr[0];
            for(int i=0;i<arr.Length;i++){
                if(arr[i]>max){
                    max=arr[i];
                }
            }
            Console.WriteLine(max);
            return max;
        }
        // find avg
        static int FindAvg(int[] arr){
            int sum = 0;
            for(int i=0;i<arr.Length;i++){
                sum+=arr[i];
            }
            int avg = sum/arr.Length;
            Console.WriteLine(avg);
            return avg;
        }
        // arr w/odd
        static int[] OddArr(int start, int end){
            int[] arr = new int[(end+1)/2];
            for(int i=0;i<arr.Length;i++){
                arr[i] = start+(i*2);
                Console.WriteLine(arr[i]);
            }
            return arr;
        }
        // greater than y
        static int GreaterThan(int[] arr, int num){
            int count = 0;
            for(int i=0;i<arr.Length;i++){
                if(arr[i]>num){
                    count++;
                }
            }
            Console.WriteLine(count);
            return count;
        }
        // square val
        static int[] SquareVal(int[] arr){
            for(int i=0;i<arr.Length;i++){
                arr[i]*=arr[i];
                Console.WriteLine(arr[i]);            
            }
            return arr;
        }
        // eliminate negative num
        static int[] ElimNeg(int[] arr){
            for(int i=0;i<arr.Length;i++){
                if(arr[i]<0){
                    arr[i]=0;
                }
                Console.WriteLine(arr[i]);
            }
            return arr;
        }
        // min max avg
        static int MinMaxAvg(int[] arr){
            int sum = 0;
            int min = arr[0];
            int max = arr[0];
            for(int i=0;i<arr.Length;i++){
                sum+=arr[i];
                if(arr[i]<min){
                    min = arr[i];
                }
                if(arr[i]>max){
                    max = arr[i];
                }
            }
            int avg = sum/arr.Length;
            Console.WriteLine(min +" | "+ max +" | "+ avg);
            return avg;
        }
        // Shift vals in arr
        static int[] ShiftValArr(int[] arr){
            for(int i=0;i<arr.Length-1;i++){
                arr[i] = arr[i+1];
                Console.WriteLine(arr[i]);
            }
            arr[arr.Length-1]=0;
            Console.WriteLine(arr[arr.Length-1]);
            return arr;
        }
        // Num to string
        static object[] NumString(int[] arr){
            object[] newArr = new object[arr.Length];
            for(int i=0;i<arr.Length;i++){
                if(arr[i]%2!=0){
                    newArr[i] = "Dojo";
                }
                else{
                    newArr[i] = arr[i];
                }
                Console.WriteLine(newArr[i]);
            }
            return newArr;
        }
    }
}
