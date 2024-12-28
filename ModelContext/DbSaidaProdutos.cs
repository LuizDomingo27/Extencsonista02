using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoqueEscolar.ModelContext
{
   public class DbSaidaProdutos : Produto
   {
      //Construtor Padrão
      public DbSaidaProdutos() { }

      public DbSaidaProdutos(int id, string nome, string categoria, int quantidade, int qtdmin)
      {
         this.Id = id;
         this.Nome = nome;
         this.Categoria = categoria;
         this.Quantidade = quantidade;
         this.QuantidadeMinima = qtdmin;
      }
   }
}
