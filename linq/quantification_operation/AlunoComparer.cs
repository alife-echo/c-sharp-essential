

namespace quantification_operation;
public class AlunoComparer : IEqualityComparer<Aluno>
{
    public bool Equals(Aluno x, Aluno y)
    {
        //se ambas as referencias do objetos forem iguais, retorna true
        if (object.ReferenceEquals(x, y))
            return true;

        // se uma das referencias for null retorna false
        if (x is null || y is null)
            return false;

        // agora comparamos os valores para verificar se são iguais
        return x.Nome == y.Nome && x.Pontos == y.Pontos;
    }

    // se Equals retornar true para o par de objetos
    // GetHashCode tem que retornar os mesmos valores para os objetos
    public int GetHashCode(Aluno obj)
    {
        //se o objeto for null retorna 0
        if (obj is null)
            return 0;

        int NomeHashCode = obj.Nome == null ? 0 : obj.Nome.GetHashCode();
        int PontosHashCode = obj.Pontos.GetHashCode();

        return NomeHashCode ^ PontosHashCode;
    }
}
