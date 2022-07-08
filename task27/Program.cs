/* пробовал через получение кол-ва цифр в числе и создания массива. НЕУДАЧНО
System.Console.WriteLine("Введите число- ");
int number = Convert.ToInt32(Console.ReadLine());

int digit = 0;
if (number > 0)
{
    digit = (int)Math.Log10(number) + 1;

}
else if (number == 0)
{
    digit = 1;

}
else if (number < 0)
{
    digit = (int)Math.Log10(-number) + 1;

}
System.Console.WriteLine(digit);

int size = Convert.ToInt32(Console.ReadLine())
int[] array = new int[size];
for (int i = array.Length; i >= 0; i--)
{
    array[i] = number % 10;
    number/= 10;

}
foreach (int i in array)
    Console.WriteLine(i); */

System.Console.WriteLine("Введите число- ");
int number = Convert.ToInt32(Console.ReadLine());

void sum(int value)
{
    int result = 0;
    for (; value > 0; value /= 10)
    {
        result += value % 10;
    }
    System.Console.WriteLine(result);
}
sum(number);