string firstName = "Iwan";
string greeting = "Hai";
string message = greeting + " " + firstName + "!";
Console.WriteLine(message);

//	selain make string message kaya diatas bisa juga kaya gini

string message2 = $"{greeting} {firstName}!";
Console.WriteLine(message2);

//	atau bisa juga langsung

Console.WriteLine($"{greeting} {firstName}!");

string projectName = "First Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");