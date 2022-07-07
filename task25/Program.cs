System.Console.WriteLine("введите два числа");
int numA;

while (!int.TryParse(Console.ReadLine(), out numA))
{
    System.Console.WriteLine("Введен некорректный символ, введите ЧИСЛО");
}

System.Console.WriteLine($"Число {numA} принято");

int numB;
while (!int.TryParse(Console.ReadLine(), out numB))
{
    System.Console.WriteLine("Введен некорректный символ, введите ЧИСЛО");
}

System.Console.WriteLine($"Число {numB} принято");

int count =1 ;
for (int i = 1; i <= numB; i++)
{
    
    count*=numA;
    System.Console.Write($"{count} ,");
}
System.Console.WriteLine("\b \b");

System.Console.Write($"{numA}^{numB} = {count}");

/*Вариант без цикла
 System.Console.WriteLine("введите два числа");
int Num1;

while (!int.TryParse(Console.ReadLine(), out Num1))
{
    System.Console.WriteLine("Введен некорректный символ, введите ЧИСЛО");
}

System.Console.WriteLine($"Число {Num1} принято");

int Num2;
while (!int.TryParse(Console.ReadLine(), out Num2))
{
    System.Console.WriteLine("Введен некорректный символ, введите ЧИСЛО");
}

System.Console.WriteLine($"Число {Num2} принято");

System.Console.WriteLine($"{Num1}^{Num2} = {Math.Pow(Num1, Num2)}");  */
