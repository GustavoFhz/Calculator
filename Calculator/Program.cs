List<string> numbers = new List<string>();

int manyTimes = 0;
void Main()
{
    Menu();
}
void Menu()
{
    var endGame = false;
    do
    {
        Console.WriteLine("Welcome to the Calculator Program");
        Console.WriteLine("------------------");
        Console.WriteLine("Enter an option:");
        Console.WriteLine("\t+ : Add");
        Console.WriteLine("\t- : Subtract");
        Console.WriteLine("\t* : Multiply");
        Console.WriteLine("\t/ : Divide");
        Console.WriteLine("\tt : Show the times that you used the calculator");
        Console.WriteLine("\tsr : SquareRoot");
        Console.WriteLine("\tp : Taking the power");
        Console.WriteLine("\ts : Show the list of calculations");
        Console.WriteLine("\td : Delete the list of calculations");
        Console.WriteLine("\tq : Quit the game");

        string? opc = Console.ReadLine();

        switch (opc)
        {
            case "+": Add(); break;
            case "-": Subtract(); break;
            case "*": Multiply(); break;
            case "/": Divide(); break;
            case "t": Times(); break;
            case "sr": SquareRoot(); break;
            case "p": TakingThePower(); break;
            case "s": ShowHistory(); break;
            case "d": DeleteHistory(); break;
            case "q": endGame = true; break;
            default: Console.WriteLine("Invalid Option"); break;

        }

    }
    while (!endGame);



}
double GetValidNumber(string prompt)
{
    double num;
    Console.WriteLine(prompt);

    while (!double.TryParse(Console.ReadLine(), out num))
    {
        Console.WriteLine("Invalid input, please enter a valid number");
    }
    return num;
}
void Add()
{
    double num1 = GetValidNumber("Type the first number");
    double num2 = GetValidNumber("Type the second number");

    double result = num1 + num2;

    string msg = $"{num1} + {num2} = {result} \n";
    numbers.Add(msg);
    Console.WriteLine(msg);
    manyTimes++;
}
void Subtract()
{
    double num1 = GetValidNumber("Type the first number");
    double num2 = GetValidNumber("Type the second number");

    double result = num1 - num2;

    string msg = $"{num1} - {num2} = {result} \n";
    numbers.Add(msg);
    Console.WriteLine(msg);
    manyTimes++;
}
void Multiply()
{
    double num1 = GetValidNumber("Type the first number");
    double num2 = GetValidNumber("Type the second number");

    double result = num1 * num2;

    string msg = $"{num1} * {num2} = {result} \n";
    numbers.Add(msg);
    Console.WriteLine(msg);
    manyTimes++;
}
void Divide()
{
    double num1 = GetValidNumber("Type the first number");

    double num2;

    do
    {
        num2 = GetValidNumber("Type the second number (non-zero):");
    }
    while (num2 == 0);

    double result = num1 / num2;

    string msg = $"{num1} / {num2} = {result} \n";
    numbers.Add(msg);
    Console.WriteLine(msg);
    manyTimes++;
}
void SquareRoot()
{
    double num1 = GetValidNumber("Type the first number");


    double result = Math.Sqrt(num1);

    string msg = $" The square root of {num1} is {result} \n";
    numbers.Add(msg);
    Console.WriteLine(msg);
    manyTimes++;
}
void TakingThePower()
{
    double num1 = GetValidNumber("Type the first number");
    double num2 = GetValidNumber("Type the second number");

    double result = Math.Pow(num1, num2);

    string msg = $"{num1} raised to the power of {num2} is {result} \n";
    numbers.Add(msg);
    Console.WriteLine(msg);
    manyTimes++;
}
void Times()
{

    Console.WriteLine($"The calculator was used {manyTimes} times(s)");

}
void ShowHistory()
{
    if (numbers.Count == 0)
    {
        Console.WriteLine("No calculations yet");
    }
    else
    {
        Console.WriteLine("Calculation history:");
        foreach (string entry in numbers)
        {
            Console.WriteLine(entry);
        }
    }
}
void DeleteHistory()
{
    Console.WriteLine("Calculation history has been cleared.\n");
    numbers.Clear();
}
