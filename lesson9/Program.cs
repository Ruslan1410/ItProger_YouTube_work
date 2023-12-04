using System;

namespace project {
    
    class Program {

        static void Main(){
            short [,] nums ={
                {5, 6, 7},
                {8, 5, 4},
                {2, 8, 3},
            }   

            foreach(short el in nums) {
                System.Console.WriteLine ("El: "+ el);
            }
        }
    }
}