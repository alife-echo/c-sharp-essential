

Console.WriteLine("Digite a temperatura do reator");
var temperature = float.Parse(Console.ReadLine());



TemperatureAlertDelegate tem1 = LogToConsole;
tem1 += SaveToFile;
tem1 += SendEmailAlert;


if(temperature > 32)
    tem1(temperature);





Console.ReadKey();

static void LogToConsole(float message)
{
    Console.WriteLine($"A temperatura ultrapassou: {message}C");
}

static void SaveToFile(float temperature)
{
    Console.WriteLine($"A temperatura salva em {temperature}.txt");
}

static void SendEmailAlert(float temperature)
{
    Console.WriteLine($"Enviando Alerta para de temperatura: {temperature}C para sinobras@gmail.com");
}

public delegate void TemperatureAlertDelegate(float temperature);