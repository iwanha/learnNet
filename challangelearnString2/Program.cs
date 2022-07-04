string projectName = "ACME";

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine("View English output:");
Console.Write("\t\t");
Console.Write($@"c:\Exercise\{projectName}\Data.txt");
Console.WriteLine(" ");
Console.WriteLine(russianMessage);
Console.Write("\t\t");
Console.Write($@"c:\Exercise\{projectName}\ru-RU\Data.txt");
