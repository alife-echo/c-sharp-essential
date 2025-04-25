using System.Globalization;

Console.WriteLine("\n Antes do C# 10 ##\n");

// trabalhando com datas de maneira com DateTime

DateTime date = new DateTime();

Console.WriteLine($"DateTime Valor Padrão:{date}");

DateTime now = DateTime.Now;

Console.WriteLine($"A Data de Hoje :{now}");

Console.WriteLine($"\n Somente a data de hoje {now.ToShortDateString()}");
Console.WriteLine($"\n Somente a hora de hoje {now.ToShortTimeString()}");



// Trabalhando com dateonly

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Trabalhando com DateOnly");
DateOnly dateOnly = new DateOnly();

Console.WriteLine($"Valor padrão DateOnly {dateOnly}");
Console.ReadKey();

Console.WriteLine("Criando datas especificas com DataOnly\n");
Console.WriteLine("1 - Usando construtor\n");
var anonovo_ocidente = new DateOnly(2025,10,26); // criando uma data especifca com dateonly

var persianCalendar = new PersianCalendar(); // cria um calendario persa
var JapaneseCalendar = new JapaneseCalendar(); // cria um calendaria japones
var anoNovoPersian = new DateOnly(2025,10,26,persianCalendar); // crio um data especifica e formato para o calendario persa
var anoNovoOriente = new DateOnly(2025,10,26,JapaneseCalendar); // crio uma data especifica e formato para o calendario japones


Console.WriteLine($"Usando a cultura padrão:{anonovo_ocidente}");
Console.WriteLine($"Calendario Persa:{anoNovoPersian}");
Console.WriteLine($"Calendario Japones:{anoNovoOriente}");

Console.WriteLine("\n Usando : FromDateTime,FromDayNumber e ParseExact\n");

DateOnly hoje = DateOnly.FromDateTime(DateTime.Now); // cria um dateonly apartir de um datetime
DateOnly data3 = DateOnly.FromDayNumber(738885); // calcula a diferença entre numero de dias fornecidos e 01/01/0001 e converte para dateonly
var anoNovo = DateOnly.Parse("01/01/2022"); //cria e converte um data fornecida em string para dateonly
string[] format = {"dd/MM/yyyy"};
var natal = DateOnly.ParseExact("25/12/2021",format); // cria uma data do tipo dateonly especifca com base me um formato fornecido

Console.WriteLine($"FromDateTime ==> hoje = {hoje}");
Console.WriteLine($"FromDayNumber ==> 738885 dias = {data3}");
Console.WriteLine($"Parse ==> Ano novo = {anoNovo} ");
Console.WriteLine($"ParseExact ==> natal = {natal} ");





// Propriedades DateOnly

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("DateOnly - Propriedades");
Console.WriteLine();


Console.WriteLine("Criando instancia de duas datas");

DateOnly data1 = new DateOnly(2021,11,26);
DateOnly data2 = new DateOnly(1945,9,2);

Console.WriteLine($"Data 1 = {data1}");
Console.WriteLine($"Data 2 = {data2}");

Console.WriteLine("### Usando as propriedades DateOnly ###\n");


Console.WriteLine($"Year     = {data1.Year}"); // retorna o ano = 2021
Console.WriteLine($"Month     = {data1.Month}"); // retorna o mes = 11
Console.WriteLine($"Day    = {data1.Day}"); // retorna o dia  = 26
Console.WriteLine($"DayOfWeek    = {data1.DayOfWeek}"); // pega o numero do dia daquele mes e retorna o dia da semana = Friday
Console.WriteLine($"DayOfYear    = {data1.DayOfYear}"); // retorna o dia do ano = 330

Console.WriteLine();
Console.WriteLine($"Numero de dias data1 = {data1.DayNumber}"); // retorna o numero de dias desde 01/01/0001 ate a data fornecida = 738119
Console.WriteLine($"Numero de dias data2 = {data2.DayNumber}"); // retorna o numero de dias desde 01/01/0001 ate a data fornecida = 710275


// numero de dias entre duas datas

var diferenca = data1.DayNumber - data2.DayNumber;
Console.WriteLine($"Diferença em dias entre {data1} e {data2} = {diferenca} dias");

//numero de dias entre duas convertido em anos
var resultado = diferenca / 365;
Console.WriteLine($"Diferença em anos entre {data1} e {data2} = {resultado} anos");






//Métodos DateOnly

var natalM = new DateOnly(2021, 12, 25);

Console.WriteLine($"\n Natal de 2021 : {natalM}");
Console.WriteLine($"\n Incluindo 1 dia, 1 mes e 1 ano a {natalM}");
Console.ReadKey();

var novaData = natalM.AddDays(1).AddMonths(1).AddYears(1);
Console.WriteLine($"Nova data obtida : {novaData}");

Console.WriteLine($"\nCriando duas datas e comparando\n");
Console.ReadKey();
var data1M = new DateOnly(2021,11,25);
var data2M = DateOnly.FromDateTime(DateTime.Now); // pega a data de hoje pelo datetime e converte para dateonly

Console.WriteLine($"data1 = {data1M}");
Console.WriteLine($"data2 = {data2M}\n");

//CompareTO = compara dois objetos do mesmo tipo, retornando um valor inteiro que indica a ordem relativa entre eles
// Ordems abaixo
// Menor que 0 : data1M é anterior a data2M
// Igual a 0 : as datas são iguais
// Maior que 0 : a data1M é posterior a data2M
var compara1 = data1M.CompareTo(data2M);

// Equals = verifica se as duas datas são iguais retorna um booleano
var compara2 = data1M.Equals(data2M);

Console.WriteLine($"{data1M} comparada com {data2M} ==> {compara1}");
Console.WriteLine($"{data1M} É Igual a {data2M} ==> {compara2}");



Console.WriteLine();
Console.WriteLine("Usando o formato longo e curto para datas e criando data com horas\n");
Console.ReadKey();

var longo = data1M.ToLongDateString();
var curto = data2M.ToShortDateString();

var dataHora = data1M.ToDateTime(new TimeOnly(10,30)); // converte um dataonly para datetime e adiciona horario atraves do TimeOnly

Console.WriteLine($"ToLongDateString()  ={longo}"); // escreve por extenso  a data ==> Thursday, November 25, 2021
Console.WriteLine($"ToShortDateString()  ={curto}"); // escreve data normal convertido em string ==> 4/24/2025
Console.WriteLine($"ToDateTime()  ={dataHora}"); // exibe a data em formato datetime junto com o horario

var igual = data1M.Equals(data2M); //verifica se as datas são iguais e retorna um bool
Console.WriteLine($"{data1M} Equals {data2M} ? ==> {igual}");

Console.ReadKey();






// DateOnly Operadores


Console.WriteLine("## DateOnly - Operadores");
Console.ReadKey();

Console.WriteLine("Criando instancia de duas datas");
DateOnly data1O = new DateOnly(1939,9,1);
DateOnly data2O = new DateOnly(1945,9,2);

Console.WriteLine($"data1 = {data1O}");
Console.WriteLine($"data2 = {data2O}");

Console.WriteLine("Usando os operadores dateonly\n");
Console.ReadKey();

var igualdade = data1O == data2O;
Console.WriteLine($"{data1O} == {data2O} ? ==> {igualdade}\n");

var maiorQUe = data1O > data2O;
Console.WriteLine($"{data1O} > {data2O} ? ==> {maiorQUe}\n");

var maiorOuIgual = data1O >= data2O;
Console.WriteLine($"{data1O} >= {data2O} ? ==> {maiorOuIgual} ");

var diferente = data1O != data2O;
Console.WriteLine($"{data1O} != {data2O} ? ==> {diferente}");

var menor = data1O < data2O;
Console.WriteLine($"{data1O} < {data2O} ? ==> {menor}");

var menorIgual = data1O <= data2O;
Console.WriteLine($"{data1O} <= {data2O} ? ==> {menorIgual}");




