﻿
namespace AppDev_CW_dNF
{
    partial class mainFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFrame));
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnSee = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelPanel = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.panelSidebar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            resources.ApplyResources(this.panelSidebar, "panelSidebar");
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.panelSidebar.Controls.Add(this.btnLogOut);
            this.panelSidebar.Controls.Add(this.btnSee);
            this.panelSidebar.Controls.Add(this.btnEdit);
            this.panelSidebar.Controls.Add(this.btnshow);
            this.panelSidebar.Controls.Add(this.panelLogo);
            this.panelSidebar.Name = "panelSidebar";
            // 
            // btnLogOut
            // 
            resources.ApplyResources(this.btnLogOut, "btnLogOut");
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnSee
            // 
            resources.ApplyResources(this.btnSee, "btnSee");
            this.btnSee.FlatAppearance.BorderSize = 0;
            this.btnSee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSee.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSee.Name = "btnSee";
            this.btnSee.UseVisualStyleBackColor = true;
            this.btnSee.Click += new System.EventHandler(this.btnSee_Click);
            // 
            // btnEdit
            // 
            resources.ApplyResources(this.btnEdit, "btnEdit");
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnshow
            // 
            resources.ApplyResources(this.btnshow, "btnshow");
            this.btnshow.FlatAppearance.BorderSize = 0;
            this.btnshow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnshow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnshow.Name = "btnshow";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.labelPanel);
            resources.ApplyResources(this.panelLogo, "panelLogo");
            this.panelLogo.Name = "panelLogo";
            // 
            // labelPanel
            // 
            resources.ApplyResources(this.labelPanel, "labelPanel");
            this.labelPanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPanel.Name = "labelPanel";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.panelMain.Controls.Add(this.lbWelcome);
            resources.ApplyResources(this.panelMain, "panelMain");
            this.panelMain.Name = "panelMain";
            // 
            // lbWelcome
            // 
            this.lbWelcome.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            resources.ApplyResources(this.lbWelcome, "lbWelcome");
            this.lbWelcome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbWelcome.Name = "lbWelcome";
            // 
            // mainFrame
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSidebar);
            this.MaximizeBox = false;
            this.Name = "mainFrame";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.panelSidebar.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btnSee;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Label labelPanel;
        private System.Windows.Forms.Button btnLogOut;
    }
}

