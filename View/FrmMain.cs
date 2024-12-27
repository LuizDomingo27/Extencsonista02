using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ControleEstoqueEscolar.Report;

namespace ControleEstoqueEscolar.View
{
   public partial class FrmMain : Form
   {
      public FrmMain()
      {
         InitializeComponent();
      }

      private void TsUsuario_Click(object sender, EventArgs e)
      {
         using FrmUser frmUser = new();
         frmUser.ShowDialog();
      }

      private void TsProduto_Click(object sender, EventArgs e)
      {
         using FrmProdutos frm = new();
         frm.ShowDialog();
      }

      private void TsRelatorio_Click(object sender, EventArgs e)
      {
         using FrmReport frm = new();
         frm.ShowDialog(this);
      }
   }
}
