// Write C# program to calculate area and perimeter of rectangle using input from console.ReadLine().
using System;
public class Calculate{
public static void Main(String [] args){
Console.WriteLine("Enter any Number");
int l = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int a=(l*b);
int p= 2*(l+b);
Console.WriteLine("The are is" +a);
Console.WriteLine("The Perimeter is"+p);
}}


