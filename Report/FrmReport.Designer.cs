namespace ControleEstoqueEscolar.Report
{
   partial class FrmReport
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         Btn_Print = new Button();
         SuspendLayout();
         // 
         // Btn_Print
         // 
         Btn_Print.Location = new Point(651, 651);
         Btn_Print.Name = "Btn_Print";
         Btn_Print.Size = new Size(101, 48);
         Btn_Print.TabIndex = 0;
         Btn_Print.Text = "Print";
         Btn_Print.UseVisualStyleBackColor = true;
         Btn_Print.Click += Btn_Print_Click;
         // 
         // FrmReport
         // 
         AutoScaleDimensions = new SizeF(8F, 20F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(784, 711);
         Controls.Add(Btn_Print);
         Cursor = Cursors.Hand;
         Font = new Font("Segoe UI", 11F);
         Margin = new Padding(3, 4, 3, 4);
         MaximizeBox = false;
         MinimizeBox = false;
         Name = "FrmReport";
         ShowIcon = false;
         StartPosition = FormStartPosition.CenterScreen;
         Text = "Relatório";
         ResumeLayout(false);
      }

      #endregion

      private Button Btn_Print;
   }
}