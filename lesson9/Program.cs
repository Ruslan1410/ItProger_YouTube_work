using System;
using System.Collections.Generic;
namespace project {
    
    class Program {

        static void Main(){

            List<int> numbers = new List<int> (){
                4, 6, 7
            };
            numbers.Add(40);
            numbers.Add(100);
            numbers.Add(5);

            foreach(int el in numbers){
                System.Console.WriteLine ("El: "+ el);
            } 
            // short [,] nums = {
            //     {5, 6, 7},
            //     {8, 5, 4},
            //     {2, 8, 3},
            // };   

            // foreach(short el in nums) 
            //     System.Console.WriteLine ("El: "+ el);
            
        }
    }
}