/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

string[] GetNumbers(string message)
{
    Console.WriteLine(message);
    string[] array = (Console.ReadLine() ?? "").Split(new char[] { ',', ' ' });
    return array;
}
int numbersGreaterThanZero(string[] array)
{
    int[] arr = new int[array.Length];
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = int.Parse(array[i]);
        if (arr[i] > 0) count += 1;
    }
    return count;
}
string[] arr = GetNumbers("Введите числа через пробел или запятую: ");
int result = numbersGreaterThanZero(arr);
Console.WriteLine($"{result} - количество чисел больше нуля");
