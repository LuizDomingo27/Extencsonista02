namespace ControleEstoqueEscolar
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
      ///  Required method for Designer support - do not modify
      ///  the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         components = new System.ComponentModel.Container();
         Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
         Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
         Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
         Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
         Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
         Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
         Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
         Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
         guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
         BtnLogin = new Guna.UI2.WinForms.Guna2Button();
         guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
         guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
         Txt_Email_Login = new Guna.UI2.WinForms.Guna2TextBox();
         Txt_Senha_Login = new Guna.UI2.WinForms.Guna2TextBox();
         Lbl_Redefinir = new Label();
         label2 = new Label();
         Lbl_NovoUser = new Label();
         SuspendLayout();
         // 
         // guna2AnimateWindow1
         // 
         guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
         guna2AnimateWindow1.TargetForm = this;
         // 
         // BtnLogin
         // 
         BtnLogin.BorderRadius = 5;
         BtnLogin.Cursor = Cursors.Hand;
         BtnLogin.CustomizableEdges = customizableEdges15;
         BtnLogin.DisabledState.BorderColor = Color.DarkGray;
         BtnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
         BtnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
         BtnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
         BtnLogin.FillColor = SystemColors.Menu;
         BtnLogin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
         BtnLogin.ForeColor = Color.Black;
         BtnLogin.Location = new Point(48, 233);
         BtnLogin.Name = "BtnLogin";
         BtnLogin.ShadowDecoration.CustomizableEdges = customizableEdges16;
         BtnLogin.Size = new Size(141, 37);
         BtnLogin.TabIndex = 2;
         BtnLogin.Text = "OK";
         BtnLogin.Click += BtnLogin_Click;
         // 
         // guna2ControlBox1
         // 
         guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
         guna2ControlBox1.CustomizableEdges = customizableEdges13;
         guna2ControlBox1.FillColor = Color.White;
         guna2ControlBox1.IconColor = Color.Black;
         guna2ControlBox1.Location = new Point(197, 1);
         guna2ControlBox1.Name = "guna2ControlBox1";
         guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges14;
         guna2ControlBox1.Size = new Size(45, 29);
         guna2ControlBox1.TabIndex = 1;
         // 
         // guna2Elipse1
         // 
         guna2Elipse1.TargetControl = this;
         // 
         // Txt_Email_Login
         // 
         Txt_Email_Login.BorderRadius = 5;
         Txt_Email_Login.CustomizableEdges = customizableEdges11;
         Txt_Email_Login.DefaultText = "";
         Txt_Email_Login.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
         Txt_Email_Login.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
         Txt_Email_Login.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
         Txt_Email_Login.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
         Txt_Email_Login.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
         Txt_Email_Login.Font = new Font("Segoe UI", 14F);
         Txt_Email_Login.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
         Txt_Email_Login.Location = new Point(19, 86);
         Txt_Email_Login.Margin = new Padding(6, 7, 6, 7);
         Txt_Email_Login.Name = "Txt_Email_Login";
         Txt_Email_Login.PasswordChar = '\0';
         Txt_Email_Login.PlaceholderText = "E-mail";
         Txt_Email_Login.SelectedText = "";
         Txt_Email_Login.ShadowDecoration.CustomizableEdges = customizableEdges12;
         Txt_Email_Login.Size = new Size(207, 38);
         Txt_Email_Login.TabIndex = 0;
         // 
         // Txt_Senha_Login
         // 
         Txt_Senha_Login.Animated = true;
         Txt_Senha_Login.AutoSizeMode = AutoSizeMode.GrowAndShrink;
         Txt_Senha_Login.BorderRadius = 5;
         Txt_Senha_Login.CustomizableEdges = customizableEdges9;
         Txt_Senha_Login.DefaultText = "";
         Txt_Senha_Login.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
         Txt_Senha_Login.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
         Txt_Senha_Login.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
         Txt_Senha_Login.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
         Txt_Senha_Login.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
         Txt_Senha_Login.Font = new Font("Segoe UI", 15F);
         Txt_Senha_Login.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
         Txt_Senha_Login.Location = new Point(19, 162);
         Txt_Senha_Login.Margin = new Padding(6, 7, 6, 7);
         Txt_Senha_Login.Name = "Txt_Senha_Login";
         Txt_Senha_Login.PasswordChar = '*';
         Txt_Senha_Login.PlaceholderText = "Senha";
         Txt_Senha_Login.SelectedText = "";
         Txt_Senha_Login.ShadowDecoration.CustomizableEdges = customizableEdges10;
         Txt_Senha_Login.Size = new Size(207, 38);
         Txt_Senha_Login.TabIndex = 1;
         // 
         // Lbl_Redefinir
         // 
         Lbl_Redefinir.AutoSize = true;
         Lbl_Redefinir.Cursor = Cursors.Hand;
         Lbl_Redefinir.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
         Lbl_Redefinir.Location = new Point(77, 326);
         Lbl_Redefinir.Name = "Lbl_Redefinir";
         Lbl_Redefinir.Size = new Size(90, 15);
         Lbl_Redefinir.TabIndex = 3;
         Lbl_Redefinir.Text = "Redefinir Senha";
         Lbl_Redefinir.Click += Lbl_Redefinir_Click;
         // 
         // label2
         // 
         label2.AutoSize = true;
         label2.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
         label2.Location = new Point(81, 21);
         label2.Name = "label2";
         label2.Size = new Size(83, 32);
         label2.TabIndex = 3;
         label2.Text = "Login";
         // 
         // Lbl_NovoUser
         // 
         Lbl_NovoUser.AutoSize = true;
         Lbl_NovoUser.Cursor = Cursors.Hand;
         Lbl_NovoUser.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
         Lbl_NovoUser.Location = new Point(88, 297);
         Lbl_NovoUser.Name = "Lbl_NovoUser";
         Lbl_NovoUser.Size = new Size(69, 15);
         Lbl_NovoUser.TabIndex = 3;
         Lbl_NovoUser.Text = "Nova Conta";
         Lbl_NovoUser.Click += Lbl_NovoUser_Click;
         // 
         // FrmLogin
         // 
         AutoScaleDimensions = new SizeF(7F, 15F);
         AutoScaleMode = AutoScaleMode.Font;
         BackColor = Color.White;
         ClientSize = new Size(244, 354);
         Controls.Add(label2);
         Controls.Add(Lbl_NovoUser);
         Controls.Add(Lbl_Redefinir);
         Controls.Add(Txt_Senha_Login);
         Controls.Add(Txt_Email_Login);
         Controls.Add(guna2ControlBox1);
         Controls.Add(BtnLogin);
         FormBorderStyle = FormBorderStyle.None;
         MaximizeBox = false;
         MinimizeBox = false;
         Name = "FrmLogin";
         ShowIcon = false;
         StartPosition = FormStartPosition.CenterScreen;
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
      private Guna.UI2.WinForms.Guna2Button BtnLogin;
      private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
      private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
      private Guna.UI2.WinForms.Guna2TextBox Txt_Email_Login;
      private Guna.UI2.WinForms.Guna2TextBox Txt_Senha_Login;
      private Label label2;
      private Label Lbl_Redefinir;
      private Label Lbl_NovoUser;
   }
}
