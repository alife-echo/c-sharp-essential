using Agregacao;

Professor prof1 = new Professor("Richard","Estrutura de dados 2");
Professor prof2 = new Professor("Nelso", "Estrutura de dados 3");
Professor prof3 = new Professor("Gleison", "Redes");
Professor prof4 = new Professor("Marcela", "Analise e Projeto de Sistemas");


Departamento dep1 = new Departamento("Exatas");
dep1.IncluirProfessor(prof1);
dep1.IncluirProfessor(prof2);
dep1.IncluirProfessor(prof3);
dep1.IncluirProfessor(prof4);
dep1.ListaProfessores();