namespace StudentApiForm
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelUserName = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.UserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1.SuspendLayout();
            this.panelUserName.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnLogin);
            this.guna2Panel1.Controls.Add(this.guna2Panel4);
            this.guna2Panel1.Controls.Add(this.Password);
            this.guna2Panel1.Controls.Add(this.panelUserName);
            this.guna2Panel1.Controls.Add(this.UserName);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(734, 411);
            this.guna2Panel1.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Animated = true;
            this.btnLogin.AutoRoundedCorners = true;
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.BorderColor = System.Drawing.Color.BlueViolet;
            this.btnLogin.BorderRadius = 19;
            this.btnLogin.BorderThickness = 1;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.BlueViolet;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLogin.HoverState.BorderColor = System.Drawing.Color.DarkOrchid;
            this.btnLogin.HoverState.CustomBorderColor = System.Drawing.Color.DarkOrchid;
            this.btnLogin.HoverState.FillColor = System.Drawing.Color.DarkOrchid;
            this.btnLogin.Location = new System.Drawing.Point(224, 287);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(300, 40);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Log In";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.guna2Panel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.guna2Panel4.ForeColor = System.Drawing.Color.Black;
            this.guna2Panel4.Location = new System.Drawing.Point(225, 245);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(300, 2);
            this.guna2Panel4.TabIndex = 4;
            // 
            // Password
            // 
            this.Password.Animated = true;
            this.Password.AutoRoundedCorners = true;
            this.Password.BorderColor = System.Drawing.Color.BlueViolet;
            this.Password.BorderRadius = 19;
            this.Password.BorderThickness = 2;
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.DefaultText = "";
            this.Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.Password.ForeColor = System.Drawing.Color.Gray;
            this.Password.HoverState.BorderColor = System.Drawing.Color.BlueViolet;
            this.Password.IconLeft = ((System.Drawing.Image)(resources.GetObject("Password.IconLeft")));
            this.Password.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.Password.IconLeftSize = new System.Drawing.Size(33, 33);
            this.Password.IconRightSize = new System.Drawing.Size(25, 25);
            this.Password.Location = new System.Drawing.Point(225, 202);
            this.Password.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '●';
            this.Password.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.Password.PlaceholderText = "Your Password";
            this.Password.SelectedText = "";
            this.Password.Size = new System.Drawing.Size(300, 40);
            this.Password.TabIndex = 3;
            this.Password.UseSystemPasswordChar = true;
            // 
            // panelUserName
            // 
            this.panelUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.panelUserName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.panelUserName.Controls.Add(this.guna2Panel3);
            this.panelUserName.ForeColor = System.Drawing.Color.Gray;
            this.panelUserName.Location = new System.Drawing.Point(224, 180);
            this.panelUserName.Name = "panelUserName";
            this.panelUserName.Size = new System.Drawing.Size(300, 2);
            this.panelUserName.TabIndex = 0;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Black;
            this.guna2Panel3.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel3.ForeColor = System.Drawing.Color.Black;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 21);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(323, 2);
            this.guna2Panel3.TabIndex = 1;
            // 
            // UserName
            // 
            this.UserName.Animated = true;
            this.UserName.AutoRoundedCorners = true;
            this.UserName.BorderColor = System.Drawing.Color.BlueViolet;
            this.UserName.BorderRadius = 19;
            this.UserName.BorderThickness = 2;
            this.UserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserName.DefaultText = "";
            this.UserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.UserName.ForeColor = System.Drawing.Color.Gray;
            this.UserName.HoverState.BorderColor = System.Drawing.Color.BlueViolet;
            this.UserName.IconLeft = ((System.Drawing.Image)(resources.GetObject("UserName.IconLeft")));
            this.UserName.IconLeftOffset = new System.Drawing.Point(15, 0);
            this.UserName.IconLeftSize = new System.Drawing.Size(25, 25);
            this.UserName.IconRightSize = new System.Drawing.Size(25, 25);
            this.UserName.Location = new System.Drawing.Point(225, 137);
            this.UserName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.UserName.Name = "UserName";
            this.UserName.PasswordChar = '\0';
            this.UserName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.UserName.PlaceholderText = "Your User Name";
            this.UserName.SelectedText = "";
            this.UserName.Size = new System.Drawing.Size(300, 40);
            this.UserName.TabIndex = 2;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderColor = System.Drawing.Color.BlueViolet;
            this.guna2Panel2.BorderRadius = 30;
            this.guna2Panel2.BorderThickness = 2;
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel2.FillColor = System.Drawing.Color.BlueViolet;
            this.guna2Panel2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 1);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.BorderRadius = 30;
            this.guna2Panel2.ShadowDecoration.Enabled = true;
            this.guna2Panel2.Size = new System.Drawing.Size(734, 83);
            this.guna2Panel2.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(183, 14);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(353, 66);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "L O G I N";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.guna2Panel1.ResumeLayout(false);
            this.panelUserName.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2TextBox Password;
        internal Guna.UI2.WinForms.Guna2Panel panelUserName;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2TextBox UserName;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}