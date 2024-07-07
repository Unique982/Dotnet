//  Write a C# program to calculate simple interest. Input data from user
 using System;
public class Si{
public static void Main(String [] args){
float p = float.Parse(Console.ReadLine());
float t = float.Parse(Console.ReadLine());
float r = float.Parse(Console.ReadLine());
float simpleinterest = (p*t*r)/100;
Console.WriteLine("Simple Interest" +simpleinterest);
}}
