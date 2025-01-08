using ControleEstoqueEscolar.Controler;

namespace ControleEstoqueEscolar.View
{
   public partial class Frm_SaidaProduto : Form
   {
      public Frm_SaidaProduto()
      {
         InitializeComponent();
         List_Saida.GridLines = true;
         List_Saida.View = System.Windows.Forms.View.Details;
         List_Saida.LabelEdit = false;
         List_Saida.FullRowSelect = true;

         //Criando as Colunas
         List_Saida.Columns.Clear();
         List_Saida.Columns.Add("ID", 60, HorizontalAlignment.Center);
         List_Saida.Columns.Add("Nome", 200, HorizontalAlignment.Left);
         List_Saida.Columns.Add("Categoria", 105, HorizontalAlignment.Left);
         List_Saida.Columns.Add("Quantidade", 105, HorizontalAlignment.Center);
         List_Saida.Columns.Add("Tipo_MV", 105, HorizontalAlignment.Center);
         List_Saida.Items.Clear();
         Funcoes.AdicionarDadosListviewSaida(List_Saida);
         Funcoes.AdicionarDadosNaComboBox_Saida(Cbo_Nome_Saida);
      }

      private void Cbo_Nome_Saida_SelectedValueChanged(object sender, EventArgs e)
      {
         try
         {
            if (Cbo_Nome_Saida.SelectedItem.ToString() != null)
            {
               string nome = Cbo_Nome_Saida.SelectedItem.ToString();
               Funcoes.BuscarProdutosSaida(nome, Txt_Categoria_Saida, Txt_Qtd_saida, Txt_qtd_min_saida, Lbl_Id_saida);
            }
         }
         catch (Exception x)
         {
            MessageBox.Show("Erro ao buscar os dados\n" + x.Message);
         }
      }

      private void Txt_MovimentacaoEstoque_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (e.KeyChar <= 47 || e.KeyChar >= 58)
         {
            e.Handled = true;
            OnGotFocus(e);
         }
      }

      private void MovimentacaoEstoque()
      {
         if (Rb_Entrada.Checked || Rb_Saida.Checked)
         {
            if (Funcoes.VerificaCamposVazios(this))
            {
               int id = int.Parse(Lbl_Id_saida.Text);
               int qtdmovimentacao = int.Parse(Txt_MovimentacaoEstoque.Text);
               int qtdestoque = int.Parse(Txt_Qtd_saida.Text);
               string nome = Cbo_Nome_Saida.SelectedItem.ToString();
               string categoria = Txt_Categoria_Saida.Text;
               Funcoes.MovimentacaoEstoque(id, nome, categoria, qtdestoque, Rb_Saida, Rb_Entrada, qtdmovimentacao);
               Funcoes.AdicionarDadosListviewSaida(List_Saida);
               Funcoes.LimparCampos(this);
            }
         }
         else MessageBox.Show("Selecione uma opção, Abastecer Estoque ou Baixa Estoque");
      }

      private void button1_Click(object sender, EventArgs e)
      {
         MovimentacaoEstoque();
      }
   }
}
