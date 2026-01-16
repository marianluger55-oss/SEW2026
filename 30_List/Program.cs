
List<int> numbers = new List<int>(); //keine Größenangabe

numbers.Add(10);
numbers.Add(20);

int nrofElements = numbers.Count; //readonly Property
Console.WriteLine(nrofElements);

Console.WriteLine(numbers[1]); //indizierter Zugriff 

numbers[1] = 5; //indizierter Zugriff
