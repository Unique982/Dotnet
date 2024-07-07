// Write C# program to add, subtract, multiply and division of two number using input from command Line.
using System;
public class Add{
    public static void Main(String[] args) {
        Console.WriteLine("Enter any Number");
           float a = float.Parse(Console.ReadLine());
             float b =float.Parse(Console.ReadLine());
            float c =  a +  b;
float d = a*b;
float e = a/b;
float f = a -b;
            Console.WriteLine("addition:"+c); 
   Console.WriteLine("Multiply:"+d); 
   Console.WriteLine("Division:"+e); 
   Console.WriteLine("Substract:"+f); 

} }