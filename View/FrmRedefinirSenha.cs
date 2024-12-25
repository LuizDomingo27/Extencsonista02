using System;
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
   public partial class FrmRedefinirSenha : Form
   {
      public FrmRedefinirSenha()
      {
         InitializeComponent();
      }

      private void Btn_Redefinir_Click(object sender, EventArgs e)
      {
         if (!Funcoes.VerificaCamposVazios(this))
         {
            MessageBox.Show("Preecha todos os campos...");
            return;
         }
         else
         {
            string senha = TxtRecuSenha_Senha.Text;
            string email = TxtRecuSenha_Email.Text;
            string nome = TxtRecu_nome.Text;
            int forcasenha = Funcoes.VerificarForcaSenha(senha);

            if (forcasenha >= 5)
            {
               Funcoes.EncriptPassword(senha);
            }
            else
            {
               MessageBox.Show("Digite letras maiuscula, minuscula, números e simbolos\n e no minimo 6 caractere.");
               return;
            }

            if (Funcoes.RecuperarSenha(nome, email, senha))
            {
               MessageBox.Show("Atualização concluida...");
               Dispose();
               Close();
               Thread t = new(() => Application.Run(new FrmLogin()));
               t.Start();
            }
         }
      }
   }
}
