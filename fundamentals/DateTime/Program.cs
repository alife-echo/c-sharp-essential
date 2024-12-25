// See https://aka.ms/new-console-template for more information
Console.WriteLine("Struct DateTime ");

DateTime data = DateTime.Now;

// criar uma data especifica usa formato : aaaa,mm,dd

DateTime dataHoje = new DateTime(2023, 10, 24);
Console.WriteLine(dataHoje); 

Console.WriteLine(data);


DateTime dataHoraHoje = new DateTime(2023 , 10 , 24, 00, 23,01);
Console.WriteLine(dataHoraHoje);    