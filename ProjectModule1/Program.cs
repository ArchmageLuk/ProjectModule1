using System;

// Задаём цифру, введённую в консоль (Работает)
int consolewrite = new Random().Next(1, 20);
Console.WriteLine("В консоль ввели цифру:");
Console.WriteLine(consolewrite);
Console.WriteLine(" ");

// Console.WriteLine(" ");

// string? arraylenght = Console.ReadLine(); // Считываем цифру из консоли как строку (Не работает)
// int arrlenght = Convert.ToInt32(arraylenght); // Превращаем строку в цифру (Не работает)

// Создаём массив с размером, указанным в консоли
// string? consoleread = Console.ReadLine(); // Не считывает
int[] randomnumbersarray = new int[10];

// Создаём два новых пустых массива для чётных и нечётных цифр
int[] oddnumbersarray = new int[randomnumbersarray.Length];
int[] evennumbersarray = new int[randomnumbersarray.Length];

// Задаём алфавит
string alphabet = "-AbcDEfgHIJklmnopqrstuvwxyz";
char[] alphabetarray = alphabet.ToCharArray();

// И задаём массив для него
// char[] alphabetarray = alphabet.ToCharArray();

// Перебираем числа в первом массиве, присваиваем случайные цифры
for (int i = 0; i < randomnumbersarray.Length; i++)
{
    int randomnumber = new Random().Next(1, 26);
    randomnumbersarray[i] = randomnumber;
    Console.WriteLine(randomnumbersarray[i]);
}

Console.WriteLine(" ");
Console.WriteLine("Разбиваем числа на чётные и нечётные");

// Присваиваем елементам в соотв. массивах чётные и нечётные числа (Работает)
for (int i = 0; i < randomnumbersarray.Length; i++)
{
    if (randomnumbersarray[i] % 2 == 0)
    {
        evennumbersarray[i] = randomnumbersarray[i];
    }
    else
    {
        oddnumbersarray[i] = randomnumbersarray[i];
    }
}

// Получаем по итогу
Console.WriteLine("Чётные");
foreach (int i in evennumbersarray)
{
    Console.WriteLine(i);
}

Console.WriteLine("Нечётные");
foreach (int i in oddnumbersarray)
{
    Console.WriteLine(i);
}

Console.WriteLine(" ");
Console.WriteLine("Заменяем цифры в массивах на буквы");

// Объявляем новые массивы, в которые будем записывать буквы\
char[] evencharsarray = new char[evennumbersarray.Length];
char[] oddcharsarray = new char[oddnumbersarray.Length];

// для каждого числа в чётном массиве
foreach (int i in evennumbersarray)
{
    // Исключаем индекс 0, т.к. мы задавали от 1 до 26 (иначе код сбивается)
    var val = Array.IndexOf(evennumbersarray, i); // получаем индекс взятого числа из чётного массива
    if (val == 0)
    {
        continue;
    }
    else
    {
        // Сравниваем число в общем массиве с индексом буквы алфавита.
        if (i == Array.IndexOf(alphabetarray, alphabetarray[i]))
        {
            evencharsarray[val] = alphabetarray[i]; // записываем в ту же ячейку нового массива чётных букв
        }
    }
}

foreach (int i in oddnumbersarray)
{
    var val = Array.IndexOf(oddnumbersarray, i); // получаем индекс взятого числа из нечётного массива
    if (val == 0)
    {
        continue;
    }
    else
    {
        oddcharsarray[val] = alphabetarray[i]; // записываем в ту же ячейку нового массива нечётных букв
    }
}


// Не работает. Почему-то выводит символ с индексом 0, хотя должно выводить только индексы 1-26.
Console.WriteLine("Чётные буквы алфавита");
foreach (char i in evencharsarray)
{
    Console.WriteLine(i);
}

Console.WriteLine(" ");
Console.WriteLine("Нечётные буквы алфавита");
foreach (char i in oddcharsarray)
{
    Console.WriteLine(i);
}