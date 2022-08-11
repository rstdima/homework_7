// Задача 41: Пользователь вводит с клавиатуры M чисел в одну линию (не используем Enter). Числа разделены пробелами. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0 7 8 -2 -2 -> 2

// 1, -7, 567, 89, 223-> 4

Console.Write("Ведите число :" );
int[] numbers = Console.ReadLine().Split().Select(x => Convert.ToInt32(x)).ToArray();

int count =0;

for(int i = 0; i < numbers.Length; i++) 
{
   if(numbers[i] > 0)
   {
      count++;
      
   }
}
Console.Write('[' + string.Join(", ", numbers) + ']');
Console.Write($"Введено чисел больше нуля: {count}");
