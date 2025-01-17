namespace ControleEstoqueEscolar.View
{
   partial class FrmMain
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
         toolStrip1 = new ToolStrip();
         TsProduto = new ToolStripButton();
         toolStripSeparator1 = new ToolStripSeparator();
         TsSaidaProduto = new ToolStripButton();
         TsUsuario = new ToolStripButton();
         toolStripSeparator2 = new ToolStripSeparator();
         TsRelatorio = new ToolStripButton();
         LblUsuarioLogado = new Label();
         uC_Hora2 = new UC_Hora();
         toolStrip1.SuspendLayout();
         SuspendLayout();
         // 
         // toolStrip1
         // 
         toolStrip1.Items.AddRange(new ToolStripItem[] { TsProduto, toolStripSeparator1, TsSaidaProduto, TsUsuario, toolStripSeparator2, TsRelatorio });
         toolStrip1.Location = new Point(0, 0);
         toolStrip1.Name = "toolStrip1";
         toolStrip1.Size = new Size(914, 25);
         toolStrip1.TabIndex = 0;
         toolStrip1.Text = "toolStrip1";
         // 
         // TsProduto
         // 
         TsProduto.DisplayStyle = ToolStripItemDisplayStyle.Text;
         TsProduto.Image = (Image)resources.GetObject("TsProduto.Image");
         TsProduto.ImageTransparentColor = Color.Magenta;
         TsProduto.Name = "TsProduto";
         TsProduto.Size = new Size(112, 22);
         TsProduto.Text = "Cadastrar Produtos";
         TsProduto.Click += TsProduto_Click;
         // 
         // toolStripSeparator1
         // 
         toolStripSeparator1.Name = "toolStripSeparator1";
         toolStripSeparator1.Size = new Size(6, 25);
         // 
         // TsSaidaProduto
         // 
         TsSaidaProduto.DisplayStyle = ToolStripItemDisplayStyle.Text;
         TsSaidaProduto.ImageTransparentColor = Color.Magenta;
         TsSaidaProduto.Name = "TsSaidaProduto";
         TsSaidaProduto.Size = new Size(136, 22);
         TsSaidaProduto.Text = "Movimentação Estoque";
         TsSaidaProduto.Click += TsSaidaProduto_Click;
         // 
         // TsUsuario
         // 
         TsUsuario.DisplayStyle = ToolStripItemDisplayStyle.Text;
         TsUsuario.Image = (Image)resources.GetObject("TsUsuario.Image");
         TsUsuario.ImageTransparentColor = Color.Magenta;
         TsUsuario.Name = "TsUsuario";
         TsUsuario.Size = new Size(104, 22);
         TsUsuario.Text = "Cadastrar Usúario";
         TsUsuario.Click += TsUsuario_Click;
         // 
         // toolStripSeparator2
         // 
         toolStripSeparator2.Name = "toolStripSeparator2";
         toolStripSeparator2.Size = new Size(6, 25);
         // 
         // TsRelatorio
         // 
         TsRelatorio.DisplayStyle = ToolStripItemDisplayStyle.Text;
         TsRelatorio.Image = (Image)resources.GetObject("TsRelatorio.Image");
         TsRelatorio.ImageTransparentColor = Color.Magenta;
         TsRelatorio.Name = "TsRelatorio";
         TsRelatorio.Size = new Size(58, 22);
         TsRelatorio.Text = "Relatório";
         TsRelatorio.Click += TsRelatorio_Click;
         // 
         // LblUsuarioLogado
         // 
         LblUsuarioLogado.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
         LblUsuarioLogado.AutoSize = true;
         LblUsuarioLogado.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
         LblUsuarioLogado.Location = new Point(6, 574);
         LblUsuarioLogado.Name = "LblUsuarioLogado";
         LblUsuarioLogado.Size = new Size(13, 17);
         LblUsuarioLogado.TabIndex = 1;
         LblUsuarioLogado.Text = "-";
         // 
         // uC_Hora2
         // 
         uC_Hora2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
         uC_Hora2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
         uC_Hora2.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
         uC_Hora2.Location = new Point(573, 534);
         uC_Hora2.Margin = new Padding(5);
         uC_Hora2.Name = "uC_Hora2";
         uC_Hora2.Size = new Size(338, 62);
         uC_Hora2.TabIndex = 2;
         // 
         // FrmMain
         // 
         AutoScaleDimensions = new SizeF(8F, 20F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(914, 600);
         Controls.Add(uC_Hora2);
         Controls.Add(LblUsuarioLogado);
         Controls.Add(toolStrip1);
         Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
         Icon = (Icon)resources.GetObject("$this.Icon");
         Margin = new Padding(3, 4, 3, 4);
         MaximizeBox = false;
         Name = "FrmMain";
         ShowIcon = false;
         StartPosition = FormStartPosition.CenterScreen;
         WindowState = FormWindowState.Maximized;
         toolStrip1.ResumeLayout(false);
         toolStrip1.PerformLayout();
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private ToolStrip toolStrip1;
      private ToolStripButton TsProduto;
      private ToolStripButton TsUsuario;
      private ToolStripSeparator toolStripSeparator1;
      private ToolStripSeparator toolStripSeparator2;
      private ToolStripButton TsRelatorio;
      private UC_Hora uC_Hora1;
      private ToolStripButton TsSaidaProduto;
      public Label LblUsuarioLogado;
      private UC_Hora uC_Hora2;
   }
}