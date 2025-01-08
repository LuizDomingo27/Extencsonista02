using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoqueEscolar.ModelContext
{
   public class DbSaidaProdutos
   {
      public int Id { get; set; }
      public string Nome { get; set; }
      public string Categoria { get; set; }
      public int Quantidade { get; set; }
      public string Tipo { get; set; }
      //Construtor Padrão
      public DbSaidaProdutos() { }

      public DbSaidaProdutos(int id, string nome, string categoria, int quantidade, string tipo)
      {
         this.Id = id;
         this.Nome = nome;
         this.Categoria = categoria;
         this.Quantidade = quantidade;
         this.Tipo = tipo;
      }
   }
}
