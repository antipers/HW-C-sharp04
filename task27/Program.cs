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

int[] array = new int[digit];
for (int i = digit; i <= 0; i--)
{
    array[i] = (number %= 10) / 10;
    System.Console.WriteLine($"{array[0]} ,");
}
