using ControleEstoqueEscolar.ModelContext;

using Microsoft.EntityFrameworkCore;

namespace ControleEstoqueEscolar.DBContext
{
   public class ConexaoContexto : DbContext
   {
      //Criando o nosso conjuto de DbSet
      public DbSet<Usuario> Usuarios { get; set; }
      public DbSet<Produto> Produtos { get; set; }
      public DbSet<DbSaidaProdutos> ProdutoSaidas { get; set; }

      //Criando a configuração para conexão com o Banco de dados
      protected override void OnConfiguring(DbContextOptionsBuilder optionBuider)
      {
         string dataBase = "Data Source=dbdados.db";
         optionBuider.UseSqlite(dataBase);
      }

   }
}
