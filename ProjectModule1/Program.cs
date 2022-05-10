using System;
using System.Text;


// Entering a number into the console
Console.WriteLine("Enter any number from 1 to 20:");
string? arraylenght = Console.ReadLine();
Console.WriteLine($"You entered {arraylenght}");
int arrlenght = Convert.ToInt32(arraylenght);

if (arrlenght < 1 ^ arrlenght > 20)
{
    Console.WriteLine("Entered value does not match the conditions");
}
else
{
    int[] randomnumbersarray = new int[arrlenght];

    // Creating 2 new empty arrays for even and odd numbers
    int[] oddnumbersarray = new int[randomnumbersarray.Length];
    int[] evennumbersarray = new int[randomnumbersarray.Length];
    Console.WriteLine(" ");

    // Creating alphabet and array for it
    string alphabet = "-AbcDEfgHIJklmnopqrstuvwxyz";
    char[] alphabetarray = alphabet.ToCharArray();

    // Looking through numbers in the first array and setting random digits
    Console.WriteLine("Got a random numbers array:");
    for (int i = 0; i < randomnumbersarray.Length; i++)
    {
        int randomnumber = new Random().Next(1, 26);
        randomnumbersarray[i] = randomnumber;
        Console.WriteLine(randomnumbersarray[i]);
    }

    Console.WriteLine(" ");
    Console.WriteLine("Splitting the numbers into odds and evens");

    // Setting even and odd numbers to elements in arrays accordingly
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

    // Cheching results of the split
    Console.WriteLine("Evens");
    foreach (int i in evennumbersarray)
    {
        Console.WriteLine(i);
    }

    Console.WriteLine("Odds");
    foreach (int i in oddnumbersarray)
    {
        Console.WriteLine(i);
    }

    Console.WriteLine(" ");
    Console.WriteLine("Changing numbers in the arrays to letters");

    // Creating new arrays for the letters
    char[] evencharsarray = new char[evennumbersarray.Length];
    char[] oddcharsarray = new char[oddnumbersarray.Length];

    void FindLettersForNumsIn(int[] numbersarray, char[] charsarray) // Method to add letter into a second given array using a number from the first given array
    {
        for (int i = 0; i < numbersarray.Length; i++)
        {
            var val = numbersarray[i];
            if (val == 0)
            {
                continue;
            }
            else
            {
                char xchar = alphabetarray[val];
                charsarray[i] = xchar;
                Console.WriteLine($"{val} = {charsarray[i]}");
            }
        }
    }

    // for each number in the evens array
    FindLettersForNumsIn(evennumbersarray, evencharsarray);

    Console.WriteLine(" ");

    // for each number in the odds array
    FindLettersForNumsIn(oddnumbersarray, oddcharsarray);


    Console.WriteLine(" ");
    void ShowLettersIn(char[] charsarray) // Method to display all letters in the given array
    {
        for (int i = 0; i < charsarray.Length; i++)
        {
            if (charsarray[i] == 0)
            {
                continue;
            }

            Console.Write(charsarray[i]);
        }
    }

    Console.WriteLine(" ");
    Console.WriteLine("Even alphabet letters");
    ShowLettersIn(evencharsarray);


    Console.WriteLine(" ");
    Console.WriteLine("Odd alphabet letters");
    ShowLettersIn(oddcharsarray);

    Console.WriteLine(" ");


    // High case letters to search
    string highcasestring = "ADEHIJ";
    char[] highcasearray = highcasestring.ToCharArray();

    int CountHCLetters(char[] lettercount) // Method to count high case letters in the given array
    {
        var count = 0;
        foreach (char c in lettercount)
        {
            foreach (char hchar in highcasearray)
            {
                if (c == hchar)
                {
                    count = count + 1;
                }
                else
                {
                    continue;
                }
            }
        }

        return count;
    }

    var evencount = CountHCLetters(evencharsarray);

    Console.WriteLine(" ");
    Console.WriteLine($"There are {evencount} high case letters in the evens string");

    var oddcount = CountHCLetters(oddcharsarray);

    Console.WriteLine($"There are {oddcount} high case letters in the odds string");

    string evencharres = new string(evencharsarray);
    string oddcharres = new string(oddcharsarray);

    char[] evencharforstring = evencharres.ToCharArray();
    char[] oddcharforstring = oddcharres.ToCharArray();

    evencharres = string.Join(" ", evencharforstring);
    oddcharres = string.Join(" ", oddcharforstring);

    Console.WriteLine(" ");

    // Display message "Array 1 bigger than Array 2" or otherwise
    if (evencount > oddcount)
    {
        Console.Write($"There are more high case letters in the «{evencharres}» string than in «{oddcharres}»");
    }

    if (oddcount > evencount)
    {
        Console.Write($"There are more high case letters in the «{oddcharres}» string than in «{evencharres}»");
    }

    if (oddcount == evencount)
    {
        Console.Write($"Strings «{evencharres}» and «{oddcharres}» have the same number of high case letters");
    }

    Console.WriteLine(" ");
}