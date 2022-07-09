// V1.0 // Random

/* int[] array = new int[8];

void fillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 1000);
        System.Console.Write($"{array[i]}  / ");

    }
}

fillArray(array); */


//V2// input from keyboard

int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
System.Console.WriteLine("введите 8 элементов массива");  
array[i]= Convert.ToInt32(Console.ReadLine());
}

foreach (var item in array)
{
    System.Console.Write($"{item} ,");
}
System.Console.WriteLine($"\b \b");