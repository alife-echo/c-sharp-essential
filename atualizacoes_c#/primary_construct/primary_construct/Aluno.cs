namespace primary_construct;

public class Aluno(string nome, string sobrenome, int nota)
{
    // caso queira criar um construtor sem parametros eu preciso usar o this para passar valores em modo default
    public Aluno():this("Álife","Moraes",3){}
    
    // caso queira apenas ter um parametro de inicialização do construtor, porem, preciso chamar o construtor primario de novo
    public Aluno(string nome) : this (nome, "baba",4){}
    public string? Nome { get; set; } = nome;
    public string? Sobrenome { get; set; } = sobrenome;
    
    public int Nota { get; set; } = nota;
    
    public string NomeCompleto => $"{Nome} {Sobrenome}";
    
}