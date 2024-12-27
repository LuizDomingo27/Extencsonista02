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

namespace ControleEstoqueEscolar.Report
{
   public partial class FrmReport : Form
   {
      public FrmReport()
      {
         InitializeComponent();
      }

      private void Btn_Print_Click(object sender, EventArgs e)
      {
         Funcoes.Exportar("teste","Relatorio");
      }
   }
}
