using ExemploHerancaComposicao;

Pe pe = new Pe();
Nadadeira nadar = new Nadadeira();  

Homem homem = new Homem(pe);
homem.Locomocao();

Macaco macaco = new Macaco(pe);
macaco.Locomocao();

Sardinha sardinha = new Sardinha(nadar);
sardinha.Locomocao();   

Console.ReadKey();