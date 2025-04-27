namespace new_five_resources_I;

public record Pessoa
{
    public string Nome = string.Empty;
    public string Sobrenome = string.Empty;

    public sealed override  string ToString()
    {
        return $"Meu nome é {Nome} {Sobrenome}";
    }
}