﻿using System.Data;

using ControleEstoqueEscolar.DBContext;
using ControleEstoqueEscolar.ModelContext;

namespace ControleEstoqueEscolar.Report
{
   public static class Report
   {
      public static void SelecionarOpcaoRelatorio(List<Produto> produto, ComboBox cat, RadioButton rbMaior100, RadioButton rbMenor100, RadioButton rbMenor50, RadioButton rbTodos, RadioButton rbCat)
      {
         using ConexaoContexto conexao = new();

         if (rbTodos.Checked)
         {
            var dados = conexao.Produtos;
            foreach (var p in dados)
            {
               produto.Add(new Produto(p.Id, p.Nome, p.Categoria, p.Quantidade, p.QuantidadeMinima));
            }
         }
         else if (rbMenor100.Checked)
         {
            var dados = conexao.Produtos.Where(p => p.Quantidade < 100)
               .Select(p => new { p.Id, p.Nome, p.Categoria, p.Quantidade, p.QuantidadeMinima })
               .ToList();

            dados.ForEach(p => produto.Add(
                          new Produto(p.Id, p.Nome, p.Categoria, p.Quantidade, p.QuantidadeMinima)));
         }
         else if (rbMaior100.Checked)
         {
            var dados = conexao.Produtos.Where(p => p.Quantidade > 100)
               .Select(p => new { p.Id, p.Nome, p.Categoria, p.Quantidade, p.QuantidadeMinima })
               .ToList();

            dados.ForEach(p => produto.Add(
                          new Produto(p.Id, p.Nome, p.Categoria, p.Quantidade, p.QuantidadeMinima)));
         }
         else if (rbMenor50.Checked)
         {
            var dados = conexao.Produtos.Where(p => p.Quantidade < 50)
               .Select(p => new { p.Id, p.Nome, p.Categoria, p.Quantidade, p.QuantidadeMinima })
               .ToList();

            dados.ForEach(p => produto.Add(
                          new Produto(p.Id, p.Nome, p.Categoria, p.Quantidade, p.QuantidadeMinima)));
         }
         else if (cat.SelectedItem.ToString() != null && rbCat.Checked)
         {
            string categoria = cat.SelectedItem.ToString();
            var dados = conexao.Produtos.Where(p => p.Categoria == categoria)
               .Select(p => new { p.Id, p.Nome, p.Categoria, p.Quantidade, p.QuantidadeMinima })
               .ToList();

            dados.ForEach(p => produto.Add(
                          new Produto(p.Id, p.Nome, p.Categoria, p.Quantidade, p.QuantidadeMinima)));
         }
         conexao.Dispose();
      }

      public static void MesclarDataTable(DataTable dtOne, DataTable dtTwo)
      {
         for (int i = 0; i < dtOne.Columns.Count; i++)
         {
            for (int x = 0; x < dtTwo.Columns.Count; x++)
            {
               if (dtTwo.Columns[x].ColumnName == dtOne.Columns[i].ColumnName)
               {
                  dtOne.Columns[x].DataType = dtTwo.Columns[i].DataType;
               }
            }
         }
         dtTwo.Merge(dtOne);
      }
   }
}
