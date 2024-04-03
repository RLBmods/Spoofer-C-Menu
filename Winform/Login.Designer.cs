namespace Winform
{
    partial class Login
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.FormElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.FormShadow = new Siticone.UI.WinForms.SiticoneShadowForm(this.components);
            this.Logo = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Usernametextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Passwordtextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Loginbutton = new Guna.UI2.WinForms.Guna2Button();
            this.FormDragcontrol = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // FormElipse
            // 
            this.FormElipse.TargetControl = this;
            // 
            // Logo
            // 
            this.Logo.Image = global::Winform.Properties.Resources.Rlbmods_LOGO_Background;
            this.Logo.ImageRotate = 0F;
            this.Logo.Location = new System.Drawing.Point(119, 30);
            this.Logo.Name = "Logo";
            this.Logo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Logo.Size = new System.Drawing.Size(130, 129);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // Usernametextbox
            // 
            this.Usernametextbox.Animated = true;
            this.Usernametextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Usernametextbox.BorderRadius = 4;
            this.Usernametextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Usernametextbox.DefaultText = "";
            this.Usernametextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Usernametextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Usernametextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Usernametextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Usernametextbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Usernametextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Usernametextbox.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Usernametextbox.FocusedState.ForeColor = System.Drawing.Color.White;
            this.Usernametextbox.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usernametextbox.ForeColor = System.Drawing.Color.Silver;
            this.Usernametextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Usernametextbox.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Usernametextbox.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Usernametextbox.Location = new System.Drawing.Point(32, 180);
            this.Usernametextbox.Name = "Usernametextbox";
            this.Usernametextbox.PasswordChar = '\0';
            this.Usernametextbox.PlaceholderText = "Email Address";
            this.Usernametextbox.SelectedText = "";
            this.Usernametextbox.Size = new System.Drawing.Size(305, 46);
            this.Usernametextbox.TabIndex = 1;
            this.Usernametextbox.TextOffset = new System.Drawing.Point(0, 2);
            // 
            // Passwordtextbox
            // 
            this.Passwordtextbox.Animated = true;
            this.Passwordtextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Passwordtextbox.BorderRadius = 4;
            this.Passwordtextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Passwordtextbox.DefaultText = "";
            this.Passwordtextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Passwordtextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Passwordtextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Passwordtextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Passwordtextbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Passwordtextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Passwordtextbox.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Passwordtextbox.FocusedState.ForeColor = System.Drawing.Color.White;
            this.Passwordtextbox.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordtextbox.ForeColor = System.Drawing.Color.Silver;
            this.Passwordtextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Passwordtextbox.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Passwordtextbox.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Passwordtextbox.Location = new System.Drawing.Point(32, 233);
            this.Passwordtextbox.Name = "Passwordtextbox";
            this.Passwordtextbox.PasswordChar = '•';
            this.Passwordtextbox.PlaceholderText = "Password";
            this.Passwordtextbox.SelectedText = "";
            this.Passwordtextbox.Size = new System.Drawing.Size(305, 46);
            this.Passwordtextbox.TabIndex = 2;
            this.Passwordtextbox.TextOffset = new System.Drawing.Point(0, 2);
            // 
            // Loginbutton
            // 
            this.Loginbutton.Animated = true;
            this.Loginbutton.BorderColor = System.Drawing.Color.DarkRed;
            this.Loginbutton.BorderRadius = 3;
            this.Loginbutton.BorderThickness = 1;
            this.Loginbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Loginbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Loginbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Loginbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Loginbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Loginbutton.FillColor = System.Drawing.Color.DarkRed;
            this.Loginbutton.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbutton.ForeColor = System.Drawing.Color.White;
            this.Loginbutton.Location = new System.Drawing.Point(32, 288);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(305, 44);
            this.Loginbutton.TabIndex = 3;
            this.Loginbutton.Text = "Login";
            this.Loginbutton.TextOffset = new System.Drawing.Point(0, -2);
            // 
            // FormDragcontrol
            // 
            this.FormDragcontrol.TargetControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(369, 507);
            this.Controls.Add(this.Loginbutton);
            this.Controls.Add(this.Passwordtextbox);
            this.Controls.Add(this.Usernametextbox);
            this.Controls.Add(this.Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rlbmods";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox Logo;
        private Guna.UI2.WinForms.Guna2Elipse FormElipse;
        private Siticone.UI.WinForms.SiticoneShadowForm FormShadow;
        private Guna.UI2.WinForms.Guna2TextBox Usernametextbox;
        private Guna.UI2.WinForms.Guna2Button Loginbutton;
        private Guna.UI2.WinForms.Guna2TextBox Passwordtextbox;
        private Siticone.UI.WinForms.SiticoneDragControl FormDragcontrol;
    }
}

