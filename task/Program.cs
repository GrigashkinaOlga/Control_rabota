int Prompt1(string message)
{
    System.Console.Write(message); // Вывести сообщение
    string value = Console.ReadLine(); // Считываем с консоли строку
    int result = Convert.ToInt32(value); // Приводим к числу
    return result; // Возвращаем результат
}

string Prompt2(string message)
{
    System.Console.Write(message); // Вывести сообщение
    string value = Console.ReadLine(); // Считываем с консоли строку
    return value; // Возвращаем результат
}

string[] InputArray(int length) // ввести массив
{
    string[] array = new string[length]; // объявляем массив
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt2($"Введите {i + 1}-й элемент "); 
    }
    return array;
}

void PrintArray(string[] array) // метод вывода массива на экран
{
    Console.Write("[ ");
    Console.Write(string.Join(" , ", array));
    Console.WriteLine(" ]");
}


