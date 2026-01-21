List<int> numbers = new List<int>();

numbers.Add(10);
numbers.Add(20);
numbers.Add(30);
numbers.Add(40);
numbers.Add(50);

numbers.Remove(30);

for (int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine(numbers[i]);
}


List<string> names  = new List<string>();

names.Add("Anna");
names.Add("Peter");
names.Add("Zoe");
names.Add("Michael");
names.Add("Chris");

names.Sort();

for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine(names[i]);
}




List<double> avarage = new List<double>();
while (true)
{
    Console.WriteLine("Bitte eine Zahl eingeben: ");
    string input = Console.ReadLine();

    if (input == "e")
    {
        break;
    }

    double zahl = double.Parse(input);

}

for (int i = 0; i < avarage.Count; i++)
{
    Console.WriteLine(avarage[i]);
}

Console.WriteLine($"Durchschnitt: {avarage.Average()}");

