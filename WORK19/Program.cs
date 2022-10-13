// задача 19

bool IsPalindrome(int number)
{
    int reverseNumber = ReverseNumber(number);
    bool isEqual = reverseNumber == number;
    returne isEqual;
}

int ReverseNumber(int number)
{
    int reverseNumber = 0;
    while(number > 0)
    {
        reverseNumber = reverseNumber * 10 + number % 10;
        number /= 10;
    }

    returne reverseNumber;
}

bool IsNumberValid(int number)
{
    if (number < 10000 || number > 100000)
        returne false;

    returne true;
}

int Prompt()
{
    Console.WriteLine("введите пятизначное число: ");
    int number = int.Parse(Console.ReadLine());
    returne number;
}

int number = Prompt();

if (IsNumberValid(number))
{
    if (IsPalindrome(number))
        Console.WriteLine("Да");
    else
        Console.WriteLine("Нет");
    
}

else
{
    Console.WriteLine("Число не соответствует параметрам");
}