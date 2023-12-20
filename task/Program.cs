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
