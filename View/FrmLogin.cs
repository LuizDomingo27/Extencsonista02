using ControleEstoqueEscolar.Controler;
using ControleEstoqueEscolar.View;

namespace ControleEstoqueEscolar
{
   public partial class FrmLogin : Form
   {
      public FrmLogin()
      {
         InitializeComponent();
      }

      private void BtnLogin_Click(object sender, EventArgs e)
      {
         if (Txt_Email_Login.Text != string.Empty && Txt_Senha_Login.Text != string.Empty)
         {
            string senha = Funcoes.EncriptPassword(Txt_Senha_Login.Text); ;
            string email = Txt_Email_Login.Text;
            bool result = Funcoes.Login(senha, email);
            string nome = Funcoes.nome;
            if (result)
            {
               Hide();
               using FrmMain frm = new();
               frm.LblUsuarioLogado.Text = $"Usu�rio logado - {nome}";
               frm.ShowDialog();
               Dispose();
            }
         }
         else
         {
            MessageBox.Show("Existe campos vazios....");
         }
      }

      private void Lbl_Redefinir_Click(object sender, EventArgs e)
      {
         using FrmRedefinirSenha frm = new FrmRedefinirSenha();
         frm.ShowDialog();
      }

      private void Lbl_NovoUser_Click(object sender, EventArgs e)
      {
         using FrmUser frm = new FrmUser();
         frm.ShowDialog();
      }
   }
}
