
namespace AppDev_CW_dNF
{
    partial class Landing
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
            this.btnGive = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGive
            // 
            this.btnGive.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGive.Location = new System.Drawing.Point(193, 415);
            this.btnGive.Name = "btnGive";
            this.btnGive.Size = new System.Drawing.Size(148, 64);
            this.btnGive.TabIndex = 1;
            this.btnGive.Text = "Give Review";
            this.btnGive.UseVisualStyleBackColor = true;
            this.btnGive.Click += new System.EventHandler(this.btnGive_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.Location = new System.Drawing.Point(193, 306);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(148, 64);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.lbPassword);
            this.panelContent.Controls.Add(this.lbName);
            this.panelContent.Controls.Add(this.txtName);
            this.panelContent.Controls.Add(this.txtPassword);
            this.panelContent.Controls.Add(this.btnLogin);
            this.panelContent.Controls.Add(this.btnGive);
            this.panelContent.Location = new System.Drawing.Point(0, 1);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(569, 561);
            this.panelContent.TabIndex = 3;
            // 
            // lbPassword
            // 
            this.lbPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.lbPassword.Location = new System.Drawing.Point(152, 181);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(139, 32);
            this.lbPassword.TabIndex = 6;
            this.lbPassword.Text = "Password";
            // 
            // lbName
            // 
            this.lbName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.SystemColors.Control;
            this.lbName.Location = new System.Drawing.Point(152, 87);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(145, 32);
            this.lbName.TabIndex = 5;
            this.lbName.Text = "Username";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Location = new System.Drawing.Point(158, 137);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(227, 22);
            this.txtName.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Location = new System.Drawing.Point(158, 229);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(227, 22);
            this.txtPassword.TabIndex = 3;
            // 
            // Landing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(563, 560);
            this.Controls.Add(this.panelContent);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Landing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Landing";
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGive;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassword;
    }
}