using System.ComponentModel.Design;

List<string> numbers = new List<string>();
int manyTimes = 0;

Menu();
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
        Console.Clear();

        switch (opc)
        {
            case "+": Add("Addition selected"); break;
            case "-": Subtract("Subctract selected"); break;
            case "*": Multiply("Multiply selected"); break;
            case "/": Divide("Divide  selected"); break;
            case "t": Times(); break;
            case "sr": SquareRoot("SquareRoot selected"); break;
            case "p": TakingThePower("Taking The Power selected"); break;
            case "s": ShowHistory("History"); break;
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
void Add(string message)
{
    ShowMessage(message);
    double num1 = GetValidNumber("Type the first number");
    double num2 = GetValidNumber("Type the second number");

    double result = num1 + num2;

    string msg = $"{num1} + {num2} = {result} \n";
    numbers.Add(msg);
    Console.WriteLine(msg);
    manyTimes++;
}
void Subtract(string message)
{
    ShowMessage(message);
    double num1 = GetValidNumber("Type the first number");
    double num2 = GetValidNumber("Type the second number");

    double result = num1 - num2;

    string msg = $"{num1} - {num2} = {result} \n";
    numbers.Add(msg);
    Console.WriteLine(msg);
    manyTimes++;
}
void Multiply(string message)
{
    ShowMessage(message);
    double num1 = GetValidNumber("Type the first number");
    double num2 = GetValidNumber("Type the second number");

    double result = num1 * num2;

    string msg = $"{num1} * {num2} = {result} \n";
    numbers.Add(msg);
    Console.WriteLine(msg);
    manyTimes++;
}
void Divide(string message)
{
    ShowMessage(message);
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
void SquareRoot(string message)
{
    ShowMessage(message);
    double num1 = GetValidNumber("Type the first number");


    double result = Math.Sqrt(num1);

    string msg = $" The square root of {num1} is {result} \n";
    numbers.Add(msg);
    Console.WriteLine(msg);
    manyTimes++;
}
void TakingThePower(string message)
{
    ShowMessage(message);
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
void ShowHistory(string message)
{
    ShowMessage(message);
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
void ShowMessage(string message)
{
    Console.WriteLine(message + "\n");
}