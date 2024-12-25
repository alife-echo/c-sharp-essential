// See https://aka.ms/new-console-template for more information
Console.WriteLine("Constantes");

// Constantes são valores imutaveis que são conhecidos em tempo de comppilação e não mudam durante a vida útil do programa

// usam a palavra reservada const

// constantes são inicilizadas em caixa alta

// obrigatirio chave/valor

const int ANO = 12;

const int MES = 30, SEMANA = 7, QUINZENA = 15;

const int MESES_ANO = 12;
const int DIAS_ANO = 365;

const float DIAS_POR_MES = (float)DIAS_ANO / (float)MESES_ANO;

double raio, perimetro, area;

Console.WriteLine("Informe o raio do circulo : ");
raio = Convert.ToDouble(Console.ReadLine());

perimetro = 2 * Math.PI * raio;
area = Math.PI * Math.Pow(raio,2);


Console.WriteLine($"Perímetro = {perimetro}");
Console.WriteLine($"Área  = {area}");



