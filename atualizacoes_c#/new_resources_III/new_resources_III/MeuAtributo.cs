namespace new_resources_III;

public class MeuAtributo : Attribute
{
    public string Parametro { get; set; }

    public MeuAtributo(string parametro)
    {
        Parametro = parametro;
    }
}