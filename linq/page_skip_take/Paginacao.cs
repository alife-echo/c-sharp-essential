namespace page_skip_take;

public static class Paginacao
{
    // Recebemos uma fonte de dados que será do tipo IQueryable<T>, onde T é uma classe.
    // Depois fornecemos a página atual e o número de registros por página (tamanho da página).
    public static PagedResult<T> GetPaged<T>(this IQueryable<T> query, int page, int pageSize) where T : class
    {
        // Aqui instanciamos o PagedResult e passamos os valores básicos para ele.
        var result = new PagedResult<T>();
        result.CurrentPage = page;
        result.PageSize = pageSize;
        result.RowCount = query.Count();

        // O número de páginas é definido pelo total de linhas dividido pelo número de registros por página.
        // Exemplo: se o banco tiver 30 linhas e 10 registros por página, então 30 / 10 = 3 páginas.
        var pageCount = (double)result.RowCount / pageSize;
        result.PageCount = (int)Math.Ceiling(pageCount); // Arredondamos para cima para garantir páginas completas

        // Usamos a fórmula de paginação: ignoramos um número X de registros e pegamos os próximos.
        // Exemplo: página 2 com pageSize 10 → ignorar (2 - 1) * 10 = 10 registros e pegar os próximos 10.
        var skip = (page - 1) * pageSize;
        result.Results = query.Skip(skip).Take(pageSize).ToList();

        return result;
    }
}
