

namespace exerciseLINQ;
    public  class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Categoria { get; set; } = string.Empty;
        public decimal Preco { get; set; }

        public static List<Produto> GetProdutos()
        {

            var produtos = new List<Produto>() 
            {
                new Produto { Id = 1, Nome = "Caderno", Categoria = "Papelaria", Preco = 12.50m },
                new Produto { Id = 2, Nome = "Caneta", Categoria = "Papelaria", Preco = 2.30m },
                new Produto { Id = 3, Nome = "Lápis", Categoria = "Papelaria", Preco = 1.20m },
                new Produto { Id = 4, Nome = "Mouse", Categoria = "Informática", Preco = 59.90m },
                new Produto { Id = 5, Nome = "Teclado", Categoria = "Informática", Preco = 89.00m },
                new Produto { Id = 6, Nome = "Monitor", Categoria = "Informática", Preco = 399.99m },
                new Produto { Id = 7, Nome = "Mesa", Categoria = "Móveis", Preco = 299.90m },
                new Produto { Id = 8, Nome = "Cadeira", Categoria = "Móveis", Preco = 199.50m },
                new Produto { Id = 9, Nome = "Estante", Categoria = "Móveis", Preco = 150.00m },
                new Produto { Id = 10, Nome = "Impressora", Categoria = "Informática", Preco = 499.99m },
                new Produto { Id = 11, Nome = "Régua", Categoria = "Papelaria", Preco = 3.75m },
                new Produto { Id = 12, Nome = "Gaveteiro", Categoria = "Móveis", Preco = 220.00m },
            };

            return produtos;
        }


    }

