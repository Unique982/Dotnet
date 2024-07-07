// Write a C# program to convert C and to F using input from  user.
using System;
public class Convert{
public static void Main(String[] args){
int a = int.Parse(Console.ReadLine());
int convert = (a*9/5)+35;
Console.WriteLine("celsius ="+convert);
}}