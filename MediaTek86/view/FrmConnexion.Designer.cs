
namespace MediaTek86.view
{
    partial class FrmConnexion
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
            this.btnConnexion = new System.Windows.Forms.Button();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblMdp = new System.Windows.Forms.Label();
            this.cbxAfficherPwd = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(184, 109);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(98, 23);
            this.btnConnexion.TabIndex = 0;
            this.btnConnexion.Text = "Se connecter";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(109, 22);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(173, 20);
            this.txtLogin.TabIndex = 1;
            // 
            // txtMdp
            // 
            this.txtMdp.Location = new System.Drawing.Point(109, 56);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.Size = new System.Drawing.Size(173, 20);
            this.txtMdp.TabIndex = 2;
            this.txtMdp.UseSystemPasswordChar = true;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(14, 22);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(39, 13);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "Login :";
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Location = new System.Drawing.Point(14, 56);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(77, 13);
            this.lblMdp.TabIndex = 4;
            this.lblMdp.Text = "Mot de passe :";
            // 
            // cbxAfficherPwd
            // 
            this.cbxAfficherPwd.AutoSize = true;
            this.cbxAfficherPwd.Location = new System.Drawing.Point(109, 82);
            this.cbxAfficherPwd.Name = "cbxAfficherPwd";
            this.cbxAfficherPwd.Size = new System.Drawing.Size(139, 17);
            this.cbxAfficherPwd.TabIndex = 5;
            this.cbxAfficherPwd.Text = "Afficher le mot de passe";
            this.cbxAfficherPwd.UseVisualStyleBackColor = true;
            this.cbxAfficherPwd.CheckedChanged += new System.EventHandler(this.cbxAfficherPwd_CheckedChanged);
            // 
            // FrmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 144);
            this.Controls.Add(this.cbxAfficherPwd);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtMdp);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.btnConnexion);
            this.Name = "FrmConnexion";
            this.Text = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.CheckBox cbxAfficherPwd;
    }
}