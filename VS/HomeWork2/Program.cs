// See https://aka.ms/new-console-template for more information


// _____________________ 1.uzd ____________________________
Console.WriteLine("\n" + "____________________________ 1.uzd ____________________________" + "\n");

Console.WriteLine("Ievadiet savu vārdu!!" + "\n");
string UsersName = Console.ReadLine();
Console.WriteLine($"{"\n"}Sveiks {UsersName}!");




// _____________________ 2.uzd ____________________________
Console.WriteLine("\n" + "____________________________ 2.uzd ____________________________" + "\n");

Console.WriteLine("Ievadiet cik jums gadi");
int age = int.Parse(Console.ReadLine());
age++;

Console.WriteLine($"{"\n"}Jums nākamgad paliks {age} gadu{"\n"}");




// _____________________ 3.uzd ____________________________
Console.WriteLine("\n" + "____________________________ 3.uzd ____________________________" + "\n");

Console.WriteLine("Ievadiet pirmo skaitli");
int FirstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("\n" + "Ievadiet otru skaitli");
int SecoindNumber = int.Parse(Console.ReadLine());

Console.WriteLine("\n" + "Lielākais no jūsu ievadītajiem skaitliem ir " + Math.Max(FirstNumber, SecoindNumber));




// _____________________ 4.uzd ____________________________
Console.WriteLine("\n" + "____________________________ 4.uzd ____________________________" + "\n");


Console.WriteLine("Ievadiet pirmo skaitli");
int FirstNumber1 = int.Parse(Console.ReadLine());

Console.WriteLine("\n" + "Ievadiet otru skaitli");
int SecoindNumber1 = int.Parse(Console.ReadLine());

Console.WriteLine("\n" + "mazākais no jūsu ievadītajiem skaitliem ir " + Math.Min(FirstNumber1, SecoindNumber1));





// _____________________ 5.uzd ____________________________
Console.WriteLine("\n" + "____________________________ 5.uzd ____________________________" + "\n");

Console.WriteLine("Ievadiet pirmo skaitli dalijumam");
int FirstNumber3 = int.Parse(Console.ReadLine());

Console.WriteLine("\n" + "Ievadiet otru skaitli dalijumam");
int SecoindNumber3 = int.Parse(Console.ReadLine());
int result = FirstNumber % SecoindNumber3; 

Console.WriteLine($"{"\n"} Abu sakitlu dalijuma atlikums ir {result}");





// _____________________ 6.uzd ____________________________
Console.WriteLine("\n" + "____________________________ 6.uzd ____________________________" + "\n");

