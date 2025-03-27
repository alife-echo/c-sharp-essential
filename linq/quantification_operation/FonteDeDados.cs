

namespace quantification_operation;
class FonteDeDados
{
  public static List<Pessoa> GetPessoas()
  {
        List<Pessoa> pessoas = new List<Pessoa>
     {
         new Pessoa
         {
             Nome = "Maria",
             Cachorro = new Cachorro[]
             {
                 new Cachorro {Nome="Bilu",Idade=10},
                 new Cachorro {Nome="Pipoca",Idade=14},
                 new Cachorro {Nome="Negão",Idade=6}
             }
         },
         new Pessoa
         {
             Nome = "Fernando",
             Cachorro = new Cachorro[]
             {
                 new Cachorro {Nome="Canelinha",Idade=1},
             }
         },
         new Pessoa
         {
             Nome = "Amanda",
             Cachorro = new Cachorro[]
             {
                 new Cachorro {Nome="Bisteca",Idade=8},
             }
         },
          new Pessoa
         {
             Nome = "Amanda",
             Cachorro = new Cachorro[]
             {
                 new Cachorro {Nome="Acerola",Idade=2},
                 new Cachorro {Nome="Mel",Idade=13},
             }
         },
     };
        return pessoas;
  }
}

