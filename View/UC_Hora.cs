using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEstoqueEscolar.View
{
   public partial class UC_Hora : UserControl
   {
      public UC_Hora()
      {
         InitializeComponent();
      }

      private void timer1_Tick(object sender, EventArgs e)
      {
         LblHora.Text = $"{DateTime.Now:G}";
      }
   }
}
