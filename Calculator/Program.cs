using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

while (true)
{
    Calculator calc = new Calculator();
    string wrongString = "Вы ввели неверное значение!";
    float first;
    float second;
    float result;
    bool isParsing;
    int i;

    Console.WriteLine("Выберите операцию:\nСложение - 1 \nВычитание - 2 \nУмножение - 3");

    isParsing = int.TryParse(Console.ReadLine(), out i);
    if (!isParsing)
    {
        Console.WriteLine(wrongString);
        Console.ReadLine();
        continue;
    }

    Console.WriteLine("Введите 2 числа:");

    isParsing = float.TryParse(Console.ReadLine(), out first);
    if (!isParsing)
    {
        Console.WriteLine(wrongString);
        Console.ReadLine();
        continue;
    }
    isParsing = float.TryParse(Console.ReadLine(), out second);
    if (!isParsing)
    {
        Console.WriteLine(wrongString);
        Console.ReadLine();
        continue;
    }

    switch (i)
    {
        case 1: result = calc.Add(first, second); break;
        case 2: result = calc.Subtract(first, second); break;
        case 3: result = calc.Multiply(first, second); break;
        default: result = 0; break;
    }
    Console.WriteLine("Результат:" + result + "\n Нажмите любую клавишу для продолжения");
    Console.ReadLine();
    Console.Clear();
}



