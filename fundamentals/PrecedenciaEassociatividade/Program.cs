// See https://aka.ms/new-console-template for more information
Console.WriteLine("Precedencia e Associatividade");

/*
 
 
 Operadores                Ordem Decrescente de Precedência                 Associatividade
 [] e (),++,-- (sufixo)  a++ ou a--                                    Da esquerda para a direita
 !,++,-- (prefixo) ++a , --a,                                          Da direita para a esquerda
 Aritimeticos               *,/,%,+,-                                  Da esquerda para a direita
 Relacionais               <,>, <=,>=, == , !=                         Da esquerda para a direita
 Lógicos                    &&,||                                      Da esquerda para a direita
 Atribuição                 =, *=, /=. %=, += , -=                     Da direita para a esquerda

 
                                                                      
 */
//exemplo 1
//int x = 10 - 2 * 3;
//bool b = !(9 != 8) && 5 > 7 || 8 > 6;

//Console.WriteLine(b);
//Console.WriteLine(x);

//exemplo 2
int a = 5, b = 6, c = 4;
int r = --a * b - ++c; // 19
Console.WriteLine(r);
Console.ReadKey();