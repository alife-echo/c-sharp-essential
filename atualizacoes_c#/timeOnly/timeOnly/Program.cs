// Usando TimeOnly

Console.WriteLine();
Console.WriteLine("## Usando TimeOnly ## \n");
Console.WriteLine();

TimeOnly tm = new TimeOnly();

Console.WriteLine($"new TimeOnly() ==> {tm}");


Console.ReadLine();
Console.WriteLine("## Criando horas e usando construtores \n");

// criando horarios especificos usando timeonly
var inicio = new TimeOnly(8,0);
var fim = new TimeOnly(18,30);
var horaCompleta = new TimeOnly(20,30,50);

Console.WriteLine($"TimeOnly(8,0)  {inicio}");
Console.WriteLine($"TimeOnly(18,30)  {fim}");
Console.WriteLine($"TimeOnly(20,30,50)  {horaCompleta.ToLongTimeString()}");

Console.WriteLine("### Parse - FromDateTime - FromTimeSpan - ToTimeSpan\n");

Console.ReadLine();

// criando um timeonly apartir de uma string
var almoco = TimeOnly.Parse("11:25");
var jantar = TimeOnly.Parse("19:45");


Console.WriteLine($"TimeOnly.Parse(11:25) almoco = {almoco}");
Console.WriteLine($"TimeOnly.Parse(19:45) jantar = {jantar}\n");

// cria um timeonly apartir do datetime atual
var timeAgora = TimeOnly.FromDateTime(DateTime.Now);
Console.WriteLine($"TimeOnly.FromDateTime(DateTime.Now) agora :  {timeAgora}");

// converte um numero para um quantidade de hora(TimeSpan)
var horas = TimeSpan.FromHours(21); // 21:00:00

// do TimeSpan ele cria um TimeOnly da quantidade de hora, representando um horário no dia
var horasTimeSpan = TimeOnly.FromTimeSpan(horas); // 
Console.WriteLine($"TimeSpan.FromHours(21)  :  {horasTimeSpan}"); // 9:00 PM


// converte o numero 10 para um quantidade de tempo em minutos
var minutos = TimeSpan.FromMinutes(10);

// converte a quantidade de tempo 10 minutos em timeonly, ou seja, 10 minutos em um dia
var minutosTimeSpan = TimeOnly.FromTimeSpan(minutos);
Console.WriteLine($"TimeSpan.FromMinutes(10) : {minutosTimeSpan}");

// converte a o numero 45 em quantidade de tempo em segundos
var segundos = TimeSpan.FromSeconds(45);

//converte 45 segundos em quantidade tempo para 45 segundos de um tempo no dia
var segundosTimeSpan = TimeOnly.FromTimeSpan(segundos);
Console.WriteLine($"TimeSpan.FromSeconds(45) :  {segundosTimeSpan}");



Console.WriteLine("\n -- Convertendo de TimeOnly para TimeSpan -- ");
long ticks = 863_999_999_999;
// cria um timeonly apartir de uma quantidade de nanosegundos especificos
var temp = new TimeOnly(ticks);

// converte o timeonly para timespan, ou seja, de um horario no dia para uma quantidade de tempo
TimeSpan ts = temp.ToTimeSpan();

Console.WriteLine($"De TimeOnly(863_999_999_999) para TimeSpan = {ts}\n");




//Propriedades TimeOnly

Console.WriteLine("### Usando as propriedades  de TimeOnly \n");
Console.ReadLine();

var hora1 = new TimeOnly(2, 30, 50);

// mostra apenas as horas e minutos
Console.WriteLine($"\nnew TimeOnly(2, 30, 50) SemLongTimeString => {hora1}");
// mostra horas,minutos e segundos (data longa)
Console.WriteLine($"\nnew TimeOnly(2, 30, 50) => {hora1.ToLongTimeString()}");


Console.WriteLine($" -- Hour - Minute - Second");
Console.WriteLine($"TimeOnly.Hour         = {hora1.Hour} ");
Console.WriteLine($"TimeOnly.Minute       = {hora1.Minute} ");
Console.WriteLine($"TimeOnly.Second       = {hora1.Second} ");

Console.ReadLine();

// pega o timeonly do datetime atual
var agora2 = TimeOnly.FromDateTime(DateTime.Now);

// obtem o numero de ticks do timeonly atual
long ticksTime = agora2.Ticks;

Console.WriteLine(" -- Obtendo o numero de ticks -- ");
Console.WriteLine($"Hora Atual Possui {ticksTime} ticks\n");


// convertendo de ticks para timeonly
long ticksTime2 = 463_000_000_000;
var horasTicks = new TimeOnly(ticksTime2);

Console.WriteLine("-- Convertendo de ticks para horas");
Console.WriteLine($"463_000_000_000_000 : {horasTicks}");


Console.ReadLine();





// Métodos TimeOnly

Console.WriteLine("\n## Usando os métodos TimeOnly ##");

var agora = TimeOnly.FromDateTime(DateTime.Now);

Console.WriteLine($"\nTimeOnly.FromDateTime(DateTime.Now) => {agora.ToLongTimeString()}");

var futuro = agora.
    AddHours(1).
    AddMinutes(30).
    Add(TimeSpan.FromSeconds(45)); // método alternativo para adicionar segundos

Console.WriteLine($"Incluindo 1 hora, 30 minutos e 45 segundos");
Console.WriteLine($"AddHours(1).AddMinutes(30).Add(TimeSpan.FromSeconds(45)) : {futuro.ToLongTimeString()}");

Console.WriteLine("Subtraindo 10 minutos");

var horaM = new TimeOnly(0,3); // 12 horas da manha e 3 minutos (meia noite e 3 minutos)
Console.WriteLine($"TimeOnly(0,3) => {horaM}");

var novaHoraM = horaM.AddMinutes(-10); // removendo 10 minutos
Console.WriteLine($"AddMinutes(-10) => {novaHoraM}"); // 11:53 da noite


Console.ReadLine();


Console.WriteLine($" --- Criando duas horas e comparando ---\n");
Console.ReadKey();
var hora2M = new TimeOnly(21,12,25);
var hora3M = TimeOnly.FromDateTime(DateTime.Now);

Console.WriteLine($"hora2 = {hora2M}");
Console.WriteLine($"hora3 = {hora3M}");

// -1 = se hora2M for anterior a hora3M, 0 = se hora2M for igual a hora 3M, maior que zero = se hora2M for posterior a hora3M
var compara1 = hora2M.CompareTo(hora3M);
var compara2 = hora2M.Equals(hora3M);


Console.WriteLine($"{hora2M} comparada(CompareTo) com {hora3M} ==> {compara1}");
Console.WriteLine($"{hora2M} é igual(Equals) a {hora3M} ? ==> {compara2}");

Console.ReadLine();


var meiaNoite = new TimeOnly(0,0);
var meioDia = new TimeOnly(12,0);
var seisHoras = new TimeOnly(18,0);
var horarioAtual = TimeOnly.FromDateTime(DateTime.Now);

Console.WriteLine("-- Verificando se uma hora esta em um intervalo --");

Console.WriteLine($"TimeOnly(0,0)   => {meiaNoite}");
Console.WriteLine($"TimeOnly(12,0)  => {meioDia}");
Console.WriteLine($"TimeOnly(18,0)  => {seisHoras}");
Console.WriteLine($"TimeOnly.FromDateTime(DateTime.Now) Hora Atual => {horarioAtual}");

Console.ReadLine();
Console.WriteLine("### Resultado ###");

// isBetween = Determina se uma hora esta dentro de um intervalo fornecido
if(horarioAtual.IsBetween(meiaNoite, meioDia))
    Console.WriteLine("A Hora Atual esta Antes do meio dia => Bom dia");
if(horarioAtual.IsBetween(meioDia, seisHoras))
    Console.WriteLine("A Hora Atual esta Depois do meio dia => Bom tarde");


Console.ReadLine();
Console.WriteLine("Calculando o intervalo entre horas (TimeSpan)");

var inicioM = new TimeOnly(10,30);
var terminoM = new TimeOnly(17,20);

Console.WriteLine($"TimeOnly(10,30) Inicio => {inicioM}");
Console.WriteLine($"TimeOnly(17,20) Fim => {terminoM}");

// posso fazer calculos em timeOnlys porem,apenas se eu converter para timespan depois
TimeSpan diferenca = terminoM - inicioM;
Console.WriteLine("Calculo da diferença");
Console.WriteLine($"{terminoM} - {inicioM} = {diferenca}");
Console.ReadLine();





// TimeOnly Operadores

Console.WriteLine("## TimeOnly - Operadores ##\n");
Console.ReadKey();

Console.WriteLine("Criando duas instâncias TimeOnly\n");
TimeOnly hora1O = TimeOnly.FromDateTime(DateTime.Now);
TimeOnly hora2O = TimeOnly.Parse("15:35");

Console.WriteLine($"hora1O = {hora1O}");
Console.WriteLine($"hora2O = {hora2O}\n");

Console.WriteLine("## Usando os operadores de TimeOnly  ##\n");
Console.ReadKey();

var igualdade = hora1O == hora2O;
Console.WriteLine($"{hora1O} == {hora2O} = {igualdade}");

var maiorQue = hora1O > hora2O;
Console.WriteLine($"{hora1O} > {hora2O} ==> {maiorQue}");

var maiorIgual = hora1O >= hora2O;
Console.WriteLine($"{hora1O} >= {hora2O} = {maiorIgual}");

var diferente = hora1O != hora2O;
Console.WriteLine($"{hora1O} != {hora2O} => {diferente}");

Console.ReadKey();

TimeOnly meioDiaO = new(12, 0);

var agoraO = TimeOnly.FromDateTime(DateTime.Now);

if(agora < meioDiaO)
    Console.WriteLine($"Bom dia");
else
    Console.WriteLine("Boa Tarde");

Console.ReadKey();



