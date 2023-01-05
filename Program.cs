
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