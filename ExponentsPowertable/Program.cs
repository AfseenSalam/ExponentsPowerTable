// See https://aka.ms/new-console-template for more information
Console.WriteLine("Learn your squares and cubes!");
bool IsValid = true;
int maxCubeRoot = 1290;
while (IsValid)
{
    Console.WriteLine("Enter an integer:");
    string? input = Console.ReadLine();
    int userInput;
    if (int.TryParse(input, out userInput))// dont break the code if user entered decimal or letters. it will check
    {
        if (userInput > 0 && userInput <= maxCubeRoot)
        {
            Console.WriteLine("Number\t\tSquared\t\tCubed");
            Console.WriteLine("======\t\t=======\t\t======");
            for (int i = 1; i <= userInput; i++)
            {
                int square = GetSquared(i);
                int cube = GetCubed(i);
                Console.WriteLine($"{i}\t\t{square}\t\t{cube}");

            }
            IsValid = GetContinued();
           
        }
    }
    else
    {
        Console.WriteLine($"Please enter an integer (Starting from 1 to {maxCubeRoot})");

    }
}
static int GetSquared(int i)
{
    return i * i;
}
static int GetCubed(int i)
{
    return i * i * i;
}
 static bool GetContinued()

{
    bool IsValid = true;
    while (IsValid)
    {
       
        Console.WriteLine("Do you want to continue:(yes/no)");
        string? userOption = Console.ReadLine();
        if (userOption?.ToLower() == "yes")      // Usually it is case sensitive to check irrespective case add ToLower() func
        {
            Console.WriteLine("Continue");
            IsValid = true;
            break;
        }
        else if(userOption?.ToLower() == "no")
        {
            IsValid = false;
          
            break;

        }
        else
        {
            Console.WriteLine("Invalid input");
        }
        
    }
    return IsValid;
}