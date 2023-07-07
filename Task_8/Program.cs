Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;

if (number < 0) 
{
    Console.WriteLine ("Введите положительное число");
}

while (i <= number)
{
    if (i%2 == 0)
    {
        Console.Write(i);
        Console.Write(" ");
    }
    i++;
}
