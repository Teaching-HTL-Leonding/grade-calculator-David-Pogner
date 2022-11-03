Console.Clear();

int firstexampoints = 0;
int secondexampoint = 0;
int homeworkpoints = 0;
int oralpoints = 0;
double pointdivider = 80;

Console.WriteLine("Did you take the first exam? 1 (Yes) 2 (No)");
string firstexam = Console.ReadLine()!;

if (firstexam == "1")

{
    Console.WriteLine("How many point do you get?");
    firstexampoints += int.Parse(Console.ReadLine()!);
}
else
{
    pointdivider -= 20;
}

Console.WriteLine("Did you take the second exam? 1 (Yes) 2 (No)");
int secondexam = int.Parse(Console.ReadLine()!);

if (secondexam == 1)
{
    Console.WriteLine("How many point do you get?");
    secondexampoint = int.Parse(Console.ReadLine()!);
}
else
{
    pointdivider -= 20;
}

Console.WriteLine("Have you done your homework? 1(Yes) 2 (No)");
int homework = int.Parse(Console.ReadLine()!);

if (homework == 1)
{
    Console.WriteLine("How many point do you get?");
    homeworkpoints += int.Parse(Console.ReadLine()!);
}
else
{
    pointdivider -= 20;
}

Console.WriteLine("Did you take an oral exam? 1(Yes) 2 (No)");
int oral = int.Parse(Console.ReadLine()!);

if (oral == 1)
{
    Console.WriteLine("How many point do you get?");
    oralpoints += int.Parse(Console.ReadLine()!);
}
else
{
    pointdivider -= 20;
}

double percentage = (firstexampoints + secondexampoint + homeworkpoints + oralpoints) / pointdivider * 100;

if (percentage >= 89)
{
    Console.WriteLine("Congratulation, you have the mark 1.");
}

else if (percentage >= 76)
{
    Console.WriteLine("Very good job, you have the mark 2.");
}

else if (percentage >= 63)
{
    Console.WriteLine("Good, you have the mark 3.");
}

else if (percentage >= 50)
{
    Console.WriteLine("Sorry, you only get the mark 4.");
}

else if (percentage <= 50)
{
    Console.WriteLine("You did not pass, you got the mark 5.");
}

Console.WriteLine();
Console.WriteLine("Press any key to continue.");

Console.ReadKey();
Console.Clear();