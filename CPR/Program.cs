// See https://aka.ms/new-console-template for more information

using CPR;
start:
Console.Clear();
Personoplysning person1 = new();
Console.WriteLine("Indtast dit CPR-nr. ddmmyy-xxxx");
person1.CPRnr = Console.ReadLine();
Console.WriteLine("");
Console.WriteLine($"Dit fødselsår er {person1.Udskriv_fødselsår_met()}");
Console.WriteLine("");
Console.WriteLine("Tryk på ENTER for at prøve igen");
Console.ReadLine();
goto start;