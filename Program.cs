/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2

int[] array = randomArray(5);
Console.WriteLine($"[{string.Join(", ",array)}] Количество чётных чисел в массиве равно {countOfEven(array)}");
int[] randomArray(int size) {
    Random random = new Random();
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++)
        array[i] = random.Next(100,1000);

    return array;
}
int countOfEven(int[] array) {
    int count = 0;
    for(int i = 0; i < array.Length; i++) {
        if(array[i] % 2 == 0) {
            count++;
        }
    }
    return count;
}

Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 

int[] array = randomArray(4);
Console.WriteLine($"[{string.Join(", ",array)}] Сумма нечетных элементов массива равна {sumOfOdd(array)}");
int[] randomArray(int size) {
    Random random = new Random();
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++) 
        array[i] = random.Next(-10,100);
    return array;
}
int sumOfOdd(int[] array) {
    int sum = 0;
    for(int i = 0; i < array.Length; i++) {
        if(i % 2 != 0) {
            sum += array[i];
        }
    }
    return sum;
}
*/
Console.WriteLine("Введите размер массива ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Массив:");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;
for (int x = 0; x < numbers.Length; x++)
{
    if (numbers[x] > max)
        max = numbers[x];
    if (numbers[x] < min)
        min = numbers[x];
}
void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        numbers[i] = Convert.ToDouble(new Random().Next(1,100));
}
void PrintArray(double[] numbers)
{
    Console.Write("[");
    for(int i = 0; i < numbers.Length; i++)
    Console.Write(numbers[i] + " ");
    Console.Write("]");
    Console.WriteLine();
}
Console.WriteLine($"Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между ними равна = {max - min}");
