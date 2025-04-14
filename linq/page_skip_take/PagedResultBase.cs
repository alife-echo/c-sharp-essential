namespace page_skip_take;
public abstract class PagedResultBase
{
    public int CurrentPage { get; set; }
    public int PageCount { get; set; }
    public int PageSize { get; set; }
    public int RowCount { get; set; }

    public int FirstRowPage
    {
        get { return (CurrentPage - 1) * PageSize + 1; }
    }
    /*
     currentPage = 1
     pageSize = 10 
     fórmula = (1 - 1) * 10 + 1 => 1

     Para a página 1, a linha inicial é a 1.

     currentPage = 2 
     pageSize = 10
     fórmula = (2 - 1) * 10 + 1 => 11

     Para a página 2, a linha inicial é a 11.

     currentPage = 3
     pageSize = 10
     fórmula = (3 - 1) * 10 + 1 => 21

     Para a página 3, a linha inicial é a 21.
     */
    public int LastRowOnPage
    {
        get { return Math.Min(CurrentPage * PageSize, RowCount); }
    }

    // RowCount representa a quantidade total de linhas em uma fonte de dados

    /*
     Supondo que RowCount seja 30:

     currentPage = 1
     pageSize = 10 
      
     1 * 10 = 10 => o menor entre (10, 30) é 10 → essa é a última linha da página 1
     
     currentPage = 2
     pageSize = 10

     2 * 10 = 20 => o menor entre (20, 30) é 20 → essa é a última linha da página 2

     currentPage = 3
     pageSize = 10

     3 * 10 = 30 => o menor entre (30, 30) é 30 → essa é a última linha da página 3
     */
}
