using System.Runtime.CompilerServices;

using ControleEstoqueEscolar.Controler;


namespace ControleEstoqueEscolar.View
{
   public partial class FrmUser : Form
   {
      public FrmUser()
      {
         InitializeComponent();
      }

      private void BtnSalvar_Click(object sender, EventArgs e)
      {
         if (TxtSenha_Usuario.Text != string.Empty)
         {
            string senha = Funcoes.EncriptPassword(TxtSenha_Usuario.Text);
            Funcoes.SalvarUsuario(this, Txt_NomeUsuario.Text, Txt_EmailUsuario.Text, senha);
         }
      }
   }
}
