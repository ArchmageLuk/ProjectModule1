using System;
using System.Text;

// Актуальные проблемы:
// 1) Значение, заданное в консоли, не считывается
// 2) Правильно превращает цифры в соотв. буквы, но почему-то заменяет повторы букв на пустые значения
// т.е. вместо повтора буквы - пустая строка
// 3) Для более аккуратного отображения нужно удалить пустые строки из массивов, которые превращаем в строки

// Задаём цифру, введённую в консоль (Работает)
int consolewrite = new Random().Next(5, 20);
Console.WriteLine("В консоль ввели цифру:");
Console.WriteLine(consolewrite);

// Считываем цифру из консоли как строку (Не работает)
// string? arraylenght;
// arraylenght = Console.ReadLine();
// Console.WriteLine(arraylenght);
// int arrlenght = Convert.ToInt32(arraylenght); // Превращаем строку в цифру (Не работает)
int[] randomnumbersarray = new int[consolewrite];

// Создаём два новых пустых массива для чётных и нечётных цифр
int[] oddnumbersarray = new int[randomnumbersarray.Length];
int[] evennumbersarray = new int[randomnumbersarray.Length];
Console.WriteLine(" ");

// Задаём алфавит и массив для него
string alphabet = "-AbcDEfgHIJklmnopqrstuvwxyz";
char[] alphabetarray = alphabet.ToCharArray();

// Перебираем числа в первом массиве, присваиваем случайные цифры
Console.WriteLine("Получили массив:");
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

Console.WriteLine(" ");

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

// Объявляем новые массивы, в которые будем записывать буквы
char[] evencharsarray = new char[evennumbersarray.Length];
char[] oddcharsarray = new char[oddnumbersarray.Length];

// для каждого числа в чётном массиве
foreach (int i in evennumbersarray)
{
    var val = Array.IndexOf(evennumbersarray, i); // получаем индекс взятого числа из чётного массива
    if (i == 0)
    {
        continue;
    }
    else
    {
        char evenchar = alphabetarray[i];
        evencharsarray[val] = evenchar;
        Console.WriteLine($"{i} = {evencharsarray[val]}");
    }
}

Console.WriteLine(" ");
foreach (int i in oddnumbersarray)
{
    var val = Array.IndexOf(oddnumbersarray, i); // получаем индекс взятого числа из нечётного массива
    if (i == 0)
    {
        continue;
    }
    else
    {
        char oddchar = alphabetarray[i];
        oddcharsarray[val] = oddchar;
        Console.WriteLine($"{i} = {oddcharsarray[val]}"); // записываем в ту же ячейку нового массива нечётных букв
    }
}

// Не работает. Не выводит повторы букв
Console.WriteLine(" ");
Console.WriteLine("Чётные буквы алфавита");
for (int i = 0; i < evennumbersarray.Length; i++)
{
    if (evennumbersarray[i] == 0)
    {
        continue;
    }

    Console.Write(evencharsarray[i]);
}

Console.WriteLine(" ");
Console.WriteLine("Нечётные буквы алфавита");
for (int i = 0; i < oddnumbersarray.Length; i++)
{
    if (oddnumbersarray[i] == 0)
    {
        continue;
    }

    Console.Write(oddcharsarray[i]);
}

Console.WriteLine(" ");

// Считаем буквы в верхнем регистре

// Перебираем циклом каждую букву в массиве чётных букв
var evencount = 0;
var oddcount = 0;
foreach (char c in evencharsarray)
{
    if (c == alphabetarray[1] ^ c == alphabetarray[4] ^ c == alphabetarray[5] ^ c == alphabetarray[8] ^ c == alphabetarray[9] ^ c == alphabetarray[10])
    {
        evencount = evencount + 1;
    }
    else
    {
        continue;
    }
}

Console.WriteLine(" ");
Console.WriteLine($"В чётной строке {evencount} букв в верхнем регистре");

foreach (char c in oddcharsarray)
{
    if (c == alphabetarray[1] ^ c == alphabetarray[4] ^ c == alphabetarray[5] ^ c == alphabetarray[8] ^ c == alphabetarray[9] ^ c == alphabetarray[10])
        {
        oddcount = oddcount + 1;
    }
    else
    {
        continue;
    }
}

Console.WriteLine($"В нечётной строке {oddcount} букв в верхнем регистре");

string evencharres = new string(evencharsarray);
string oddcharres = new string(oddcharsarray);
Console.WriteLine(evencharres);
Console.WriteLine(oddcharres);

char[] evencharforstring = evencharres.ToCharArray();
char[] oddcharforstring = oddcharres.ToCharArray();

evencharres = string.Join(" ", evencharforstring);
oddcharres = string.Join(" ", oddcharforstring);

Console.WriteLine(" ");

// Выводим на консоль сообщение "Массив 1 больше Массива 2" или наоборот.
if (evencount > oddcount)
{
    Console.Write($"В строке «{evencharres}» больше букв в верхнем регистре, чем в строке «{oddcharres}»");
}

if (oddcount > evencount)
{
    Console.Write($"В строке «{oddcharres}» больше букв в верхнем регистре, чем в строке «{evencharres}»");
}

if (oddcount == evencount)
{
    Console.Write($"В строке «{evencharres}» и «{oddcharres}» одинаковое количество букв в верхнем регистре");
}

Console.WriteLine(" ");