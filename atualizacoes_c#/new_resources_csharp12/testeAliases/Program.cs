// See https://aka.ms/new-console-template for more information

using meuProjetoA = new_resources_csharp12.Aluno;
using meuProjetoB = teste3.Aluno;

// usando a mesma classe em namespaces diferentes
meuProjetoA.Nome = "Álife";
meuProjetoA.Idade = 18;

meuProjetoB.Nome = "Bob";
meuProjetoB.Idade = 22;

meuProjetoA.Mostrar();
meuProjetoB.Mostrar();