// Trask 1: получить два числа и опредилить какое из них большее, а какое меньшее.

/*
Console.WriteLine("Input first integer number: ");
int num1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second integer number: ");
int num2=Convert.ToInt32(Console.ReadLine());

if(num1>num2)
{
    Console.WriteLine("число "+num1+ " является большим, а число " + num2+" является меньшим");
}
if(num1<num2)
{
    Console.WriteLine("число "+num2+ " является большим, а число " + num1+" является меньшим");
}
*/



// Trask 2: получить три числа и опредилить какое из них максимальное.

/*int num1, num2, num3;

Console.WriteLine("Input first integer number: ");
 num1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second integer number: ");
 num2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input third integer number: ");
 num3=Convert.ToInt32(Console.ReadLine());

if(num1>num2&num1>num3)
 {
    Console.WriteLine("число "+num1+ " является максимальным");
 }
if(num2>num1&num2>num3)
 {
    Console.WriteLine("число "+num2+ " является максимальным");
 }
if(num3>num2&num3>num1)
 {
    Console.WriteLine("число "+num3+ " является максимальным");
 }*/


 //Trask 3: получить число и опредилить является ли оно четным.
/*
 Console.WriteLine("Input integer number: ");
 int num=Convert.ToInt32(Console.ReadLine());

 if(num % 2 ==0)
 {
    Console.WriteLine("число "+num+ " является четным");
 }
 else
 {
    Console.WriteLine("число "+num+ " является не четным");
 }*/


//Trask 3: получить число N и выявить все четные числа от 1 до N.

Console.WriteLine("Input integer positive number: ");
 int num=Convert.ToInt32(Console.ReadLine());

int current=0;

while(current<=num)
{
    Console.Write(current+" ");
    current++; current++;
}
