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
            string senha = Funcoes.EncriptPassword(TxtRecuSenha_Senha.Text);
            string email = TxtRecuSenha_Email.Text;
            string nome = TxtRecu_nome.Text;

            if (Funcoes.RecuperarSenha(nome, email,senha))
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
