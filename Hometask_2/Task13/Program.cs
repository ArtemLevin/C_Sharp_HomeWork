// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int a;
Console.Write("Пользователь выбрал число: ");
Console.WriteLine(" ");
int N = int.Parse(Console.ReadLine()!);

a = N/10;

int length = 1;

while (a != 0)
{
    a = a/10;
    length ++;
}

if (length < 3)
{
    Console.WriteLine($"{N} ---> Третьей цифры нет");
}

int[] array = new int[length];
int index = 0;
a = N/10;
int b = N%10;
array[index] = b;

while (a != 0)
 {
    index ++;
    b = a%10;
    
    a = a/10;
    
    array[index] = b; 
}

if (array[length-3] < 0)
{
    Console.WriteLine($"{N} ---> " + (-1)*array[length-3]); 
}
else
{
Console.WriteLine($"{N} ---> " + array[length-3]); 
}