namespace ControleEstoqueEscolar.View
{
   partial class UC_Hora
   {
      /// <summary> 
      /// Variável de designer necessária.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary> 
      /// Limpar os recursos que estão sendo usados.
      /// </summary>
      /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Código gerado pelo Designer de Componentes

      /// <summary> 
      /// Método necessário para suporte ao Designer - não modifique 
      /// o conteúdo deste método com o editor de código.
      /// </summary>
      private void InitializeComponent()
      {
         components = new System.ComponentModel.Container();
         LblHora = new Label();
         timer1 = new System.Windows.Forms.Timer(components);
         SuspendLayout();
         // 
         // LblHora
         // 
         LblHora.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
         LblHora.Location = new Point(3, 11);
         LblHora.Name = "LblHora";
         LblHora.Size = new Size(165, 37);
         LblHora.TabIndex = 0;
         LblHora.Text = "---";
         LblHora.TextAlign = ContentAlignment.MiddleCenter;
         // 
         // timer1
         // 
         timer1.Enabled = true;
         timer1.Tick += timer1_Tick;
         // 
         // UC_Hora
         // 
         AutoScaleDimensions = new SizeF(7F, 15F);
         AutoScaleMode = AutoScaleMode.Font;
         Controls.Add(LblHora);
         Name = "UC_Hora";
         Size = new Size(171, 58);
         ResumeLayout(false);
      }

      #endregion

      private Label LblHora;
      private System.Windows.Forms.Timer timer1;
   }
}
