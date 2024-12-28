using ControleEstoqueEscolar.Controler;

namespace ControleEstoqueEscolar.View
{
   public partial class Frm_SaidaProduto : Form
   {
      public Frm_SaidaProduto()
      {
         InitializeComponent();
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
   }
}
