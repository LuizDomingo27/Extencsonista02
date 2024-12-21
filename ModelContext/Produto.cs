using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoqueEscolar.ModelContext
{
   public class Produto
   {
      [Key]
      [StringLength(5)]
      public int Id { get; set; }

      [StringLength(50)]
      public string Nome { get; set; }

      [StringLength(50)]
      public string Categoria { get; set; }

      [StringLength(5)]
      public  int Quantidade { get; set; }

      [StringLength(5)]
      public int QuantidadeMinima { get; set; }

      //Contrutor
      public Produto() { }

      public Produto(int id, string nome, string categoria, int quantidade, int quantidademinima)
      {
         Id = id;
         Nome = nome;
         Categoria = categoria;
         Quantidade = quantidade;
         QuantidadeMinima = quantidademinima;
      }
      public override string ToString() => $"{Id}{Nome}{Categoria}{Quantidade}{QuantidadeMinima}";
   }
}
