namespace ControleEstoqueEscolar.View
{
   partial class Frm_SaidaProduto
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
         components = new System.ComponentModel.Container();
         Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
         Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
         guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
         guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
         Lbl_Id_saida = new Label();
         List_Saida = new ListView();
         Txt_Qtd_saida = new TextBox();
         label2 = new Label();
         Cbo_Nome_Saida = new ComboBox();
         label3 = new Label();
         label5 = new Label();
         label6 = new Label();
         label4 = new Label();
         Txt_qtd_min_saida = new TextBox();
         Txt_Categoria_Saida = new TextBox();
         button1 = new Button();
         Rb_Entrada = new RadioButton();
         Rb_Saida = new RadioButton();
         label1 = new Label();
         Txt_MovimentacaoEstoque = new TextBox();
         SuspendLayout();
         // 
         // guna2Elipse1
         // 
         guna2Elipse1.TargetControl = this;
         // 
         // guna2ControlBox1
         // 
         guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
         guna2ControlBox1.CustomizableEdges = customizableEdges1;
         guna2ControlBox1.FillColor = SystemColors.ButtonHighlight;
         guna2ControlBox1.IconColor = Color.Black;
         guna2ControlBox1.Location = new Point(555, 0);
         guna2ControlBox1.Name = "guna2ControlBox1";
         guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
         guna2ControlBox1.Size = new Size(45, 29);
         guna2ControlBox1.TabIndex = 0;
         // 
         // Lbl_Id_saida
         // 
         Lbl_Id_saida.AutoSize = true;
         Lbl_Id_saida.Location = new Point(7, 383);
         Lbl_Id_saida.Name = "Lbl_Id_saida";
         Lbl_Id_saida.Size = new Size(15, 20);
         Lbl_Id_saida.TabIndex = 1;
         Lbl_Id_saida.Text = "-";
         // 
         // List_Saida
         // 
         List_Saida.Location = new Point(7, 111);
         List_Saida.Name = "List_Saida";
         List_Saida.Size = new Size(586, 298);
         List_Saida.TabIndex = 2;
         List_Saida.UseCompatibleStateImageBehavior = false;
         // 
         // Txt_Qtd_saida
         // 
         Txt_Qtd_saida.Enabled = false;
         Txt_Qtd_saida.Location = new Point(434, 75);
         Txt_Qtd_saida.Name = "Txt_Qtd_saida";
         Txt_Qtd_saida.Size = new Size(71, 27);
         Txt_Qtd_saida.TabIndex = 3;
         Txt_Qtd_saida.TextAlign = HorizontalAlignment.Center;
         // 
         // label2
         // 
         label2.AutoSize = true;
         label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
         label2.Location = new Point(14, 54);
         label2.Name = "label2";
         label2.Size = new Size(45, 17);
         label2.TabIndex = 1;
         label2.Text = "Nome";
         // 
         // Cbo_Nome_Saida
         // 
         Cbo_Nome_Saida.FormattingEnabled = true;
         Cbo_Nome_Saida.Location = new Point(7, 74);
         Cbo_Nome_Saida.Name = "Cbo_Nome_Saida";
         Cbo_Nome_Saida.Size = new Size(249, 28);
         Cbo_Nome_Saida.TabIndex = 5;
         Cbo_Nome_Saida.SelectedValueChanged += Cbo_Nome_Saida_SelectedValueChanged;
         // 
         // label3
         // 
         label3.AutoSize = true;
         label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
         label3.Location = new Point(430, 54);
         label3.Name = "label3";
         label3.Size = new Size(79, 17);
         label3.TabIndex = 1;
         label3.Text = "Quantidade";
         // 
         // label5
         // 
         label5.AutoSize = true;
         label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
         label5.Location = new Point(271, 54);
         label5.Name = "label5";
         label5.Size = new Size(66, 17);
         label5.TabIndex = 1;
         label5.Text = "Categoria";
         // 
         // label6
         // 
         label6.AutoSize = true;
         label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
         label6.Location = new Point(12, 9);
         label6.Name = "label6";
         label6.Size = new Size(296, 32);
         label6.TabIndex = 1;
         label6.Text = "Movimentação Produtos";
         // 
         // label4
         // 
         label4.AutoSize = true;
         label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
         label4.Location = new Point(521, 54);
         label4.Name = "label4";
         label4.Size = new Size(59, 17);
         label4.TabIndex = 1;
         label4.Text = "Qtd_min";
         // 
         // Txt_qtd_min_saida
         // 
         Txt_qtd_min_saida.Enabled = false;
         Txt_qtd_min_saida.Location = new Point(521, 75);
         Txt_qtd_min_saida.Name = "Txt_qtd_min_saida";
         Txt_qtd_min_saida.Size = new Size(71, 27);
         Txt_qtd_min_saida.TabIndex = 4;
         Txt_qtd_min_saida.TextAlign = HorizontalAlignment.Center;
         // 
         // Txt_Categoria_Saida
         // 
         Txt_Categoria_Saida.Location = new Point(271, 75);
         Txt_Categoria_Saida.Name = "Txt_Categoria_Saida";
         Txt_Categoria_Saida.Size = new Size(151, 27);
         Txt_Categoria_Saida.TabIndex = 3;
         // 
         // button1
         // 
         button1.Location = new Point(518, 428);
         button1.Name = "button1";
         button1.Size = new Size(75, 36);
         button1.TabIndex = 6;
         button1.Text = "OK";
         button1.UseVisualStyleBackColor = true;
         button1.Click += button1_Click;
         // 
         // Rb_Entrada
         // 
         Rb_Entrada.AutoSize = true;
         Rb_Entrada.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
         Rb_Entrada.Location = new Point(7, 415);
         Rb_Entrada.Name = "Rb_Entrada";
         Rb_Entrada.Size = new Size(139, 21);
         Rb_Entrada.TabIndex = 7;
         Rb_Entrada.TabStop = true;
         Rb_Entrada.Text = "Abastecer Estoque";
         Rb_Entrada.UseVisualStyleBackColor = true;
         // 
         // Rb_Saida
         // 
         Rb_Saida.AutoSize = true;
         Rb_Saida.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
         Rb_Saida.Location = new Point(7, 443);
         Rb_Saida.Name = "Rb_Saida";
         Rb_Saida.Size = new Size(111, 21);
         Rb_Saida.TabIndex = 7;
         Rb_Saida.TabStop = true;
         Rb_Saida.Text = "Baixa Estoque";
         Rb_Saida.UseVisualStyleBackColor = true;
         // 
         // label1
         // 
         label1.AutoSize = true;
         label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
         label1.Location = new Point(162, 416);
         label1.Name = "label1";
         label1.Size = new Size(118, 17);
         label1.TabIndex = 1;
         label1.Text = "Digite Quantidade";
         // 
         // Txt_MovimentacaoEstoque
         // 
         Txt_MovimentacaoEstoque.Location = new Point(162, 438);
         Txt_MovimentacaoEstoque.Name = "Txt_MovimentacaoEstoque";
         Txt_MovimentacaoEstoque.Size = new Size(118, 27);
         Txt_MovimentacaoEstoque.TabIndex = 4;
         Txt_MovimentacaoEstoque.TextAlign = HorizontalAlignment.Center;
         Txt_MovimentacaoEstoque.KeyPress += Txt_MovimentacaoEstoque_KeyPress;
         // 
         // Frm_SaidaProduto
         // 
         AutoScaleDimensions = new SizeF(8F, 20F);
         AutoScaleMode = AutoScaleMode.Font;
         BackColor = SystemColors.ButtonHighlight;
         ClientSize = new Size(601, 469);
         Controls.Add(Rb_Saida);
         Controls.Add(Rb_Entrada);
         Controls.Add(button1);
         Controls.Add(Cbo_Nome_Saida);
         Controls.Add(Txt_MovimentacaoEstoque);
         Controls.Add(Txt_qtd_min_saida);
         Controls.Add(Txt_Categoria_Saida);
         Controls.Add(Txt_Qtd_saida);
         Controls.Add(label6);
         Controls.Add(label5);
         Controls.Add(label1);
         Controls.Add(label4);
         Controls.Add(label3);
         Controls.Add(label2);
         Controls.Add(List_Saida);
         Controls.Add(Lbl_Id_saida);
         Controls.Add(guna2ControlBox1);
         Font = new Font("Segoe UI", 11F);
         FormBorderStyle = FormBorderStyle.None;
         Margin = new Padding(3, 4, 3, 4);
         MaximizeBox = false;
         MinimizeBox = false;
         Name = "Frm_SaidaProduto";
         ShowIcon = false;
         StartPosition = FormStartPosition.CenterScreen;
         Text = "Frm_SaidaProduto";
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
      private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
      private ComboBox Cbo_Nome_Saida;
      private TextBox Txt_Qtd_saida;
      private Label label5;
      private Label label3;
      private Label label2;
      private ListView List_Saida;
      private Label Lbl_Id_saida;
      private Label label6;
      private TextBox Txt_qtd_min_saida;
      private Label label4;
      private TextBox Txt_Categoria_Saida;
      private RadioButton Rb_Saida;
      private RadioButton Rb_Entrada;
      private Button button1;
      private TextBox Txt_MovimentacaoEstoque;
      private Label label1;
   }
}