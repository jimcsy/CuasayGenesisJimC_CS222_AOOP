﻿using System;

namespace MyProject{
    public class AlternatingChars{
        public static void Main(string[] args){
            Console.Write("First Character: ");
            char firstChar = Console.ReadKey().KeyChar;

            Console.Write("\nSecond Character: ");
            char secondChar = Console.ReadKey().KeyChar;

            Console.Write("\nEnter size: ");
            if(int.TryParse(Console.ReadLine(), out int size) && size > 0){
                for (int x = 1; x <= size; x++){
                    for(int column = 1; column <= (x-1); column++){
                        Console.Write("-");
                    }
                    if(x % 2== 0){
                        Console.Write(secondChar);
                    }else{
                        Console.Write(firstChar);
                    }
                    Console.WriteLine();
                }
            }else{
                Console.WriteLine("Invalid input. Please enter a valid input.");
            }
        }
    }
}