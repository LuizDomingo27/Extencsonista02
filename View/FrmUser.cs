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
         string forcaSenha = TxtSenha_Usuario.Text;
         int result = Funcoes.VerificarForcaSenha(forcaSenha);
         if (result >= 5)
         {
            if (TxtSenha_Usuario.Text != string.Empty)
            {
               string senha = Funcoes.EncriptPassword(TxtSenha_Usuario.Text);
               Funcoes.SalvarUsuario(this, Txt_NomeUsuario.Text, Txt_EmailUsuario.Text, senha);
            }
         }
         else
         {
            MessageBox.Show("Digite letras maiuscula, minuscula, números e simbolos\n e no minimo 6 caractere.");
            return;
         }
      }
   }
}
