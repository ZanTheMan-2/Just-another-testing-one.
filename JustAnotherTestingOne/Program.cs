using JustAnotherTestingOne;

String name;
int age;
int grade1;
int grade2;
int grade3;

try
{
    Console.WriteLine("Welcome to Just Another Testing One!" +
    "\n\nPlease enter the student's name: ");
    name = Console.ReadLine();
    Console.WriteLine("Please enter the student's age: ");
    age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please enter the student's first grade: ");
    grade1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please enter the student's second grade: ");
    grade2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please enter the student's third grade: ");
    grade3 = Convert.ToInt32(Console.ReadLine());

}
catch (FormatException e)
{
    Console.WriteLine("Please enter a valid number for age and grades.");
    return;
}
catch (Exception e)
{
    Console.WriteLine("An unexpected error occurred: " + e.Message);
    return;
}

Calculations student = new Calculations(name, grade1, grade2, grade3, age);

Console.WriteLine($"\n\nThe average of {student.GetName()}" +
    $"\n's grades is: {student.Average()}" +
    $"\n's score is: {student.score()}");

