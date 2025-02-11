using System;

namespace MyProject{
    public class SquarePatterns{
        public static void Main(string[] args){
            int skipRow, rowColumn;

            Console.Write("Enter n: ");
            if (int.TryParse(Console.ReadLine(), out rowColumn) && rowColumn > 0){
                Console.Write("Enter y: ");
                if(int.TryParse(Console.ReadLine(), out skipRow) && skipRow >= 1 && skipRow <= rowColumn){
                    for(int x = 1; x <= rowColumn; x++){
                        if(!(x == skipRow)){
                            for(int i = 1; i <= rowColumn; i++){
                            Console.Write("*");
                            }
                        }
                        Console.WriteLine();
                    }
                }else{
                    Console.WriteLine("Invalid input. Please enter a valid number between 1 and " + skipRow + ".");
                }
            }else{
                Console.WriteLine("Invalid input. Please enter a valid input.");
            }
        }
    }
}