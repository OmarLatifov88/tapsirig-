// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Hello, World!");
int P1 = 3;
int R = 11;
int area1 = R * R * P1;
Console.WriteLine(area1);
int a = 20;
int b = 24;
int area2 = a * b;
Console.WriteLine(area2);
int c = 28;
int area3 = (a + b + c) / 2;
Console.WriteLine(area3);

int number10 = 22; //parameters
Console.WriteLine(number10 *= number10);

int sum(int[] numbers)
{
    int result = 0;
    foreach (var number in numbers)
    {
        result = result + number;
    }
    return result;



}
int[] numbers = { 0, 1, 2, 3, 4, };
Console.WriteLine(sum(numbers));