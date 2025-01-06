

NotificationDelegate notifyUsers = EmailNotification;
notifyUsers += SmsNotification;
notifyUsers += PushNotification;

Console.WriteLine("Enviando notificações");
notifyUsers("Novo evento disponivel");

notifyUsers -= SmsNotification;
Console.WriteLine("Enviando apenas para dispositivos e Emails");
notifyUsers("Atualização do evento!");

Console.ReadKey();

static void SmsNotification(string message)
{
    Console.WriteLine($"[SMS] {message}");
}

static void EmailNotification(string message)
{
    Console.WriteLine($"[EMAIL] {message}");
}

static void PushNotification(string message)
{
    Console.WriteLine($"[PUSH] {message}");
}

public delegate void NotificationDelegate( string message );


