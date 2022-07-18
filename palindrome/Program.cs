bool program = true;
var funcMan = new Func();

while (program)
{
    Console.WriteLine("Введите любую фразу");

    string? str = Console.ReadLine()!
        .Trim()
        .ToLower()
        .Replace(" ", string.Empty);

    Console.WriteLine(str is null or "" ?
        "введи хотя бы ЧТО-НИБУДЬ!!!" :

        funcMan.ReverseEngineering(str) == str ?
        "УРА, палиндром!" :
        "Слово не является палиндромом");

    bool checker = true;
    while (checker)
    {
        Console.WriteLine("Продолжить хочешь? y - да, n - нет");
        string? strExit = Console.ReadLine();

        if (strExit != null
            && funcMan.ContinueProgramChecker(strExit))
        {
            program = funcMan.ContinueProgram(strExit);
            checker = false;
        }
        else
        {
            Console.WriteLine("не тупи, либо y, либо n");
        }
    }
}

class Func
{
    public bool ContinueProgram(string str)
    {
        return str == "n" ? false : true;
    }

    public bool ContinueProgramChecker(string str)
    {
        return str
            is "n" or "y" ? true : false;
    }

    public string ReverseEngineering(string str)
    {
        string helper =
            str.Trim()
            .ToLower()
            .Replace(" ", string.Empty);

        string reversed = "";
        for (int i = 0; i < helper.Length; i++)
        {
            reversed += helper[helper.Length - (i + 1)];
        }
        return reversed;
    }
}