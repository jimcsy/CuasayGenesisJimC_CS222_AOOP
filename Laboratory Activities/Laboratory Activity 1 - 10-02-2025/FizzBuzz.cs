using System;

namespace MyProject{
    public class FizzBuzz{
        public static void Main(string[] args){
            int upperbound = 15;

            for (int x = 1; x <= upperbound; x++){
                
                if(x % 3 == 0 && x % 5 == 0){
                    Console.WriteLine("FizzBuzz");
                }else if(x % 3 == 0){
                    Console.WriteLine("Fizz");
                }else if (x % 5 == 0){
                    Console.WriteLine("Buzz");
                }else{
                    Console.WriteLine(x);
                }
            }
        }
    }
}