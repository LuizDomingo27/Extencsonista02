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
         Rb_Maior100Relatorio = new RadioButton();
         Rb_menos100Relatorio = new RadioButton();
         Rb_Menos50Relatorio = new RadioButton();
         label1 = new Label();
         Rb_TodosRelatorio = new RadioButton();
         Cbo_Relatorio = new ComboBox();
         label2 = new Label();
         Rb_CategoriaRalatorio = new RadioButton();
         SuspendLayout();
         // 
         // Btn_Print
         // 
         Btn_Print.Location = new Point(82, 278);
         Btn_Print.Name = "Btn_Print";
         Btn_Print.Size = new Size(96, 36);
         Btn_Print.TabIndex = 0;
         Btn_Print.Text = "Print";
         Btn_Print.UseVisualStyleBackColor = true;
         Btn_Print.Click += Btn_Print_Click;
         // 
         // Rb_Maior100Relatorio
         // 
         Rb_Maior100Relatorio.AutoSize = true;
         Rb_Maior100Relatorio.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
         Rb_Maior100Relatorio.Location = new Point(12, 44);
         Rb_Maior100Relatorio.Name = "Rb_Maior100Relatorio";
         Rb_Maior100Relatorio.Size = new Size(230, 20);
         Rb_Maior100Relatorio.TabIndex = 1;
         Rb_Maior100Relatorio.TabStop = true;
         Rb_Maior100Relatorio.Text = "Produtos com quantidade > 100";
         Rb_Maior100Relatorio.UseVisualStyleBackColor = true;
         // 
         // Rb_menos100Relatorio
         // 
         Rb_menos100Relatorio.AutoSize = true;
         Rb_menos100Relatorio.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
         Rb_menos100Relatorio.Location = new Point(12, 75);
         Rb_menos100Relatorio.Name = "Rb_menos100Relatorio";
         Rb_menos100Relatorio.Size = new Size(230, 20);
         Rb_menos100Relatorio.TabIndex = 1;
         Rb_menos100Relatorio.TabStop = true;
         Rb_menos100Relatorio.Text = "Produtos com quantidade < 100";
         Rb_menos100Relatorio.UseVisualStyleBackColor = true;
         // 
         // Rb_Menos50Relatorio
         // 
         Rb_Menos50Relatorio.AutoSize = true;
         Rb_Menos50Relatorio.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
         Rb_Menos50Relatorio.Location = new Point(12, 106);
         Rb_Menos50Relatorio.Name = "Rb_Menos50Relatorio";
         Rb_Menos50Relatorio.Size = new Size(223, 20);
         Rb_Menos50Relatorio.TabIndex = 1;
         Rb_Menos50Relatorio.TabStop = true;
         Rb_Menos50Relatorio.Text = "Produtos com quantidade < 50";
         Rb_Menos50Relatorio.UseVisualStyleBackColor = true;
         // 
         // label1
         // 
         label1.AutoSize = true;
         label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
         label1.Location = new Point(12, 9);
         label1.Name = "label1";
         label1.Size = new Size(166, 21);
         label1.TabIndex = 2;
         label1.Text = "Selecione uma opção";
         // 
         // Rb_TodosRelatorio
         // 
         Rb_TodosRelatorio.AutoSize = true;
         Rb_TodosRelatorio.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
         Rb_TodosRelatorio.Location = new Point(12, 137);
         Rb_TodosRelatorio.Name = "Rb_TodosRelatorio";
         Rb_TodosRelatorio.Size = new Size(143, 20);
         Rb_TodosRelatorio.TabIndex = 1;
         Rb_TodosRelatorio.TabStop = true;
         Rb_TodosRelatorio.Text = "Todos os Produtos ";
         Rb_TodosRelatorio.UseVisualStyleBackColor = true;
         // 
         // Cbo_Relatorio
         // 
         Cbo_Relatorio.FormattingEnabled = true;
         Cbo_Relatorio.Location = new Point(12, 229);
         Cbo_Relatorio.Name = "Cbo_Relatorio";
         Cbo_Relatorio.Size = new Size(213, 28);
         Cbo_Relatorio.TabIndex = 3;
         // 
         // label2
         // 
         label2.AutoSize = true;
         label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
         label2.Location = new Point(12, 210);
         label2.Name = "label2";
         label2.Size = new Size(171, 16);
         label2.TabIndex = 2;
         label2.Text = "Selecione uma categoria";
         // 
         // Rb_CategoriaRalatorio
         // 
         Rb_CategoriaRalatorio.AutoSize = true;
         Rb_CategoriaRalatorio.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
         Rb_CategoriaRalatorio.Location = new Point(12, 168);
         Rb_CategoriaRalatorio.Name = "Rb_CategoriaRalatorio";
         Rb_CategoriaRalatorio.Size = new Size(115, 20);
         Rb_CategoriaRalatorio.TabIndex = 1;
         Rb_CategoriaRalatorio.TabStop = true;
         Rb_CategoriaRalatorio.Text = "Por Categoria";
         Rb_CategoriaRalatorio.UseVisualStyleBackColor = true;
         // 
         // FrmReport
         // 
         AutoScaleDimensions = new SizeF(8F, 20F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(253, 316);
         Controls.Add(Cbo_Relatorio);
         Controls.Add(label2);
         Controls.Add(label1);
         Controls.Add(Rb_CategoriaRalatorio);
         Controls.Add(Rb_TodosRelatorio);
         Controls.Add(Rb_Menos50Relatorio);
         Controls.Add(Rb_menos100Relatorio);
         Controls.Add(Rb_Maior100Relatorio);
         Controls.Add(Btn_Print);
         Cursor = Cursors.Hand;
         Font = new Font("Segoe UI", 11F);
         FormBorderStyle = FormBorderStyle.FixedSingle;
         Margin = new Padding(3, 4, 3, 4);
         MaximizeBox = false;
         MinimizeBox = false;
         Name = "FrmReport";
         ShowIcon = false;
         StartPosition = FormStartPosition.CenterScreen;
         Text = "Relatório";
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private Button Btn_Print;
      private RadioButton Rb_Maior100Relatorio;
      private RadioButton Rb_menos100Relatorio;
      private RadioButton Rb_Menos50Relatorio;
      private Label label1;
      private RadioButton Rb_TodosRelatorio;
      private ComboBox Cbo_Relatorio;
      private Label label2;
      private RadioButton Rb_CategoriaRalatorio;
   }
}