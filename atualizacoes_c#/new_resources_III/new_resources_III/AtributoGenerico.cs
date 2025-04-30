namespace new_resources_III;

public class AtributoGenerico<T> : Attribute
{
    
}

public class MeuAtributo2 : Attribute
{
    
    public Type paramType { get; }
    public MeuAtributo2(Type t) => paramType = t;
    
}