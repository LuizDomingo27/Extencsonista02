using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ControleEstoqueEscolar.Controler;

namespace ControleEstoqueEscolar.View
{
   public partial class FrmProdutos : Form
   {
      public FrmProdutos()
      {
         InitializeComponent();
         ListProdu.GridLines = true;
         ListProdu.View = System.Windows.Forms.View.Details;
         ListProdu.LabelEdit = false;
         ListProdu.FullRowSelect = true;
         CboCategoria.DisplayMember = "";
         //Criando as Colunas
         ListProdu.Columns.Clear();
         ListProdu.Columns.Add("ID", 60, HorizontalAlignment.Center);
         ListProdu.Columns.Add("Nome", 200, HorizontalAlignment.Left);
         ListProdu.Columns.Add("Categoria", 105, HorizontalAlignment.Left);
         ListProdu.Columns.Add("Quantidade", 105, HorizontalAlignment.Center);
         ListProdu.Columns.Add("Qtd_Minima", 105, HorizontalAlignment.Center);
         ListProdu.Items.Clear();
         //Chamando o metodo de adicionar os dados
         Funcoes.AdcionarDadosNaListViewProduto(ListProdu);
      }

      private void BtnSalvar_Click(object sender, EventArgs e)
      {
         if (CboCategoria.SelectedItem == null)
            return;

         if (Funcoes.VerificaCamposVazios(this))
         {
            int qtdmin = int.Parse(TxtQuantidadeMinima.Text);
            int qtd = int.Parse(TxtQuantidade.Text);
            Funcoes.SalvarProduto(TxtNomeProduto.Text, CboCategoria.SelectedItem.ToString(), qtd, qtdmin, ListProdu);
            Funcoes.LimparCampos(this);
         }
      }

      private void TxtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (e.KeyChar <= 47 || e.KeyChar >= 58)
         {
            MessageBox.Show("Digite a quantidade...");
            e.Handled = true;
            OnGotFocus(e);
         }
      }

      private void TxtQuantidadeMinima_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (e.KeyChar <= 47 || e.KeyChar >= 58)
         {
            MessageBox.Show("Digite a quantidade minima...");
            e.Handled = true;
            OnGotFocus(e);
         }
      }

      private void BtnAtualizar_Click(object sender, EventArgs e)
      {
         try
         {
            if (Funcoes.VerificaCamposVazios(this))
               if (ListProdu.FullRowSelect)
               {
                  int id = Convert.ToInt16(ListProdu.SelectedItems[0].SubItems[0].Text);
                  string nome = TxtNomeProduto.Text;
                  string categoria = CboCategoria.SelectedItem.ToString();
                  int quantidade = Convert.ToInt16(TxtQuantidade.Text);
                  int qtdmin = Convert.ToInt16(TxtQuantidadeMinima.Text);
                  Funcoes.AtualizarProduto(id, nome, categoria, quantidade, qtdmin);
                  MessageBox.Show("Produto Atualizado ...");
                  Funcoes.AdcionarDadosNaListViewProduto(ListProdu);
               }
         }
         catch (Exception x)
         {
            MessageBox.Show("Erro ao atualizar registro...\n" + x.Message);
         }
      }

      private void ListProdu_Click(object sender, EventArgs e)
      {
         Lbl_ID.Text = ListProdu.SelectedItems[0].SubItems[0].Text;
         TxtNomeProduto.Text = ListProdu.SelectedItems[0].SubItems[1].Text;
         CboCategoria.SelectedItem = ListProdu.SelectedItems[0].SubItems[2].Text;
         TxtQuantidade.Text = ListProdu.SelectedItems[0].SubItems[3].Text;
         TxtQuantidadeMinima.Text = ListProdu.SelectedItems[0].SubItems[4].Text;
      }

      private void BtnDeletar_Click(object sender, EventArgs e)
      {
         if (Lbl_ID.Text == string.Empty)
         {
            MessageBox.Show("Selecione um produto para deletar...");
            return;
         }

         if (MessageBox.Show("Deseja Deletar?", "Atenção",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
         {
            Funcoes.DeleteProduto(int.Parse(Lbl_ID.Text));
            Funcoes.AdcionarDadosNaListViewProduto(ListProdu);
            Funcoes.LimparCampos(this);
            MessageBox.Show($"Produto {TxtNomeProduto.Text}  foi deletado...");
         }
      }
   }
}
