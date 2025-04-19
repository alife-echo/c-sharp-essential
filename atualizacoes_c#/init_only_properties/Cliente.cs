

namespace init_only_properties;
class Cliente
{
    private readonly string? _nome;
    private readonly string? _email;
    public string Nome
    {
        get => _nome ;
        init => _nome = string.IsNullOrWhiteSpace(value) ?
            throw new ArgumentException("Não pode ser null nem vazio", nameof(Nome))
            : value;
    }
    public string Email 
    {
        get => _email;
        init => _email = string.IsNullOrWhiteSpace(value) ?
            throw new ArgumentException("Não pode ser null nem vazio", nameof(Email))
            : value;
    }

}

