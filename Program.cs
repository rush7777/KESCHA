string password = "";
/* do
{
  System.Console.WriteLine("Enter password: ");
  password = Console.ReadLine();
}while(password != "qwerty"); */

System.Console.WriteLine("Assalomu alaykum xush kelibsiz, Ismingizni kiring: ");
string name = System.Console.ReadLine();

System.Console.WriteLine($"Endi {name} yoshingizni yozing: ");
int age = Convert.ToInt32(Console.ReadLine());

int keschasAge = 3;
int ageDiff = age - keschasAge;

if(ageDiff > 0){
  System.Console.WriteLine($"Sizning va mening yoshimiz orasidagi tafovut bor ekan va men sizdan {ageDiff} yoshga kichik ekan man");
}
else if(ageDiff == 0){
  System.Console.WriteLine($"Biz tengqurlar ekanmiz :)");
}
else {
  System.Console.WriteLine($"Sening va mening yoshimiz orasidagi tafovut bor ekan va men sendan {Math.Abs(ageDiff)} yoshga kattaman");
}

string[] friendsName = {"Anvar" , "Bahodir", "Kamola"};
int[] friendsAge = {5 , 8 , 4};

System.Console.WriteLine($"{friendsName[0]} is {friendsAge[0] } years old.");
System.Console.WriteLine($"{friendsName[1]} is {friendsAge[1] } years old.");
System.Console.WriteLine($"{friendsName[2]} is {friendsAge[2] } years old.");
System.Console.WriteLine($"Enter {friendsName[2]}`s age:");
friendsAge[2] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"{friendsName[2]} is {friendsAge[2]} years old");