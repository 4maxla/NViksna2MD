// See https://aka.ms/new-console-template for more information


Console.WriteLine();
Console.WriteLine("// 1. uzdevums // Sasveicināšanās konsoles aplikācija //");
Console.WriteLine();

Console.Write("Type your name: ");
string userName = Console.ReadLine();

Console.WriteLine($"Hello {userName}.");



Console.WriteLine();
Console.WriteLine("// 2. uzdevums // int.Parse //");
Console.WriteLine();


Console.Write("Type your age: ");
int userAge = int.Parse(Console.ReadLine());

int userAgeNextYear = userAge + 1;
bool adult = userAge >= 18;

Console.WriteLine($"Next year your age will be {userAgeNextYear} and you are {adult} adult.");



Console.WriteLine();
Console.WriteLine("// 3. uzdevums // Math.Max //");
Console.WriteLine();


Console.Write("Type first number: ");
int maxNumber1 = int.Parse(Console.ReadLine());

Console.Write("Type second number: ");
int maxNumber2 = int.Parse(Console.ReadLine());

int highestNumber = Math.Max(maxNumber1, maxNumber2);
Console.WriteLine($"Your highest number is {highestNumber}.");



Console.WriteLine();
Console.WriteLine("// 4. uzdevums // Math.Min //");
Console.WriteLine();


Console.Write("Type first number: ");
int minNumber1 = int.Parse(Console.ReadLine());

Console.Write("Type second number: ");
int minNumber2 = int.Parse(Console.ReadLine());

int lowestNumber = Math.Min(minNumber1, minNumber2);
Console.WriteLine($"Your lowest number is {lowestNumber}.");



Console.WriteLine();
Console.WriteLine("// 5. uzdevums // % //");
Console.WriteLine();


Console.Write("Type first number: ");
int divisionNumber1 = int.Parse(Console.ReadLine());

Console.Write("Type second number: ");
int divisionNumber2 = int.Parse(Console.ReadLine());

int divisionLeft = divisionNumber1 % divisionNumber2;
Console.WriteLine($"Your two number division is {divisionLeft}.");



Console.WriteLine();
Console.WriteLine("// 6. uzdevums // Odd or Even //");
Console.WriteLine();


Console.Write("Type your number: ");
int oddEvenNumber = int.Parse(Console.ReadLine());
bool isEven = oddEvenNumber % 2 == 0;

Console.WriteLine($"Your numbers is {isEven} even .");



Console.WriteLine();
Console.WriteLine("// 7. uzdevums // Taisnstūra laukuma aprēķināšana //");
Console.WriteLine();


Console.Write("Length of first rectangular edge: ");
int rectangularEdge1 = int.Parse(Console.ReadLine());

Console.Write("Length of second rectangular edge: ");
double rectangularEdge2 = int.Parse(Console.ReadLine());

double rectangularArea = Math.Round(rectangularEdge1 * rectangularEdge2);
Console.WriteLine($"Rectangular area is {rectangularArea}.");



Console.WriteLine();
Console.WriteLine("// 8. uzdevums // Taisnleņķa trijstūra laukuma aprēķināšana //");
Console.WriteLine();


Console.Write("Length of first triangle edge: ");
int triangleEdge1 = int.Parse(Console.ReadLine());

Console.Write("Length of second triangle edge: ");
double triangleEdge2 = int.Parse(Console.ReadLine());

double triangleArea = (triangleEdge1 * triangleEdge2) / 2;
Console.WriteLine($"Triangle area is {triangleArea}.");



Console.WriteLine();
Console.WriteLine("// 9. uzdevums // Interpolācija //");
Console.WriteLine();


Console.Write("Type your name: ");
string userNameAgain = Console.ReadLine();

Console.Write("Type your age: ");
int userAgeAgain = int.Parse(Console.ReadLine());

Console.WriteLine($"Hello {userNameAgain}, your age is {userAgeAgain}.");