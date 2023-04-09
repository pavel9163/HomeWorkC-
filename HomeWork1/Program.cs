//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
int max;
if (a>b){
    max = a;
}
else{
    max = b;
}

Console.WriteLine("max->" + max);*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int c = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (a>b && a>c){
    max = a;
}
if (b>a && b>c){
    max = b;
}
if (c>a && c>b){
    max = c;
}

Console.WriteLine($"max-> + {max}");*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
if(a%2==0){
    Console.WriteLine("Число четное");
}
else{
    Console.WriteLine("Число не четное");
}*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i <= a; i+=2)
{
    Console.Write(i +" " );
}