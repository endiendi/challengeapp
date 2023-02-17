int number = 4566;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();
int[] repeatedNumbers = new int[10];


foreach (char letter in letters)
{
    if (letter == '0')
    {
        repeatedNumbers[0] = repeatedNumbers[0] + 1;
    }
    else if (letter == '1')
    {
        repeatedNumbers[1] = repeatedNumbers[1] + 1;
    }
    else if (letter == '2')
    {
        repeatedNumbers[2] = repeatedNumbers[2] + 1;
    }
    else if (letter == '3')
    {
        repeatedNumbers[3] = repeatedNumbers[3] + 1;
    }
    else if (letter == '4')
    {
        repeatedNumbers[4] = repeatedNumbers[4] + 1;
    }
    else if (letter == '5')
    {
        repeatedNumbers[5] = repeatedNumbers[5] + 1;
    }
    else if (letter == '6')
    {
        repeatedNumbers[6] = repeatedNumbers[6] + 1;
    }
    else if (letter == '7')
    {
        repeatedNumbers[7] = repeatedNumbers[7] + 1;
    }
    else if (letter == '8')
    {
        repeatedNumbers[8] = repeatedNumbers[8] + 1;
    }
    else if (letter == '9')
    {
        repeatedNumbers[9] = repeatedNumbers[9] + 1;
    }
}
Console.WriteLine("Liczba testowana: " + number);

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i + " ==> " + repeatedNumbers[i]);
}