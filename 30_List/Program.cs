
List<int> numbers = new List<int>(); //keine Größenangabe

numbers.Add(10);
numbers.Add(20);

int nrofElements = numbers.Count; //readonly Property
Console.WriteLine(nrofElements);

Console.WriteLine(numbers[1]); //indizierter Zugriff 

numbers[1] = 5; //indizierter Zugriff

if (nrofElements > 100) 
{
    numbers[100] = 7; 
}

for(int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine(numbers[i]);
}

Console.WriteLine("-----------------------");

foreach(int nr in numbers)
{
    Console.WriteLine(nr);
}

int sum = numbers.Sum(); 
double avg = numbers.Average();
int max = numbers.Max();
bool contains = numbers.Contains(5);

if(numbers.Contains(5))
{
    Console.WriteLine("Super...");
}



