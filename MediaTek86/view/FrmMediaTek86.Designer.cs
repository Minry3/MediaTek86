
namespace MediaTek86
{
    partial class FrmMediaTek86
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpBoxLesPersonnels = new System.Windows.Forms.GroupBox();
            this.grpBoxAjoutPersonnel = new System.Windows.Forms.GroupBox();
            this.grpBoxAbsences = new System.Windows.Forms.GroupBox();
            this.dgvLesPersonnels = new System.Windows.Forms.DataGridView();
            this.btnGererAbsences = new System.Windows.Forms.Button();
            this.btnSuppPersonnel = new System.Windows.Forms.Button();
            this.btnModifPersonnel = new System.Windows.Forms.Button();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.comboService = new System.Windows.Forms.ComboBox();
            this.btnEnregistrerPersonnel = new System.Windows.Forms.Button();
            this.btnAnnulerPersonnel = new System.Windows.Forms.Button();
            this.btnAnnulerAbsence = new System.Windows.Forms.Button();
            this.btnEnregistrerAbsence = new System.Windows.Forms.Button();
            this.btnSupprimerAbsence = new System.Windows.Forms.Button();
            this.btnModifierAbsence = new System.Windows.Forms.Button();
            this.dgvAbsences = new System.Windows.Forms.DataGridView();
            this.lblPersonnel = new System.Windows.Forms.Label();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.lblMotif = new System.Windows.Forms.Label();
            this.dateDebut = new System.Windows.Forms.DateTimePicker();
            this.dateFin = new System.Windows.Forms.DateTimePicker();
            this.comboMotif = new System.Windows.Forms.ComboBox();
            this.lblNomPersonnel = new System.Windows.Forms.Label();
            this.grpBoxLesPersonnels.SuspendLayout();
            this.grpBoxAjoutPersonnel.SuspendLayout();
            this.grpBoxAbsences.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLesPersonnels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxLesPersonnels
            // 
            this.grpBoxLesPersonnels.Controls.Add(this.btnModifPersonnel);
            this.grpBoxLesPersonnels.Controls.Add(this.btnSuppPersonnel);
            this.grpBoxLesPersonnels.Controls.Add(this.btnGererAbsences);
            this.grpBoxLesPersonnels.Controls.Add(this.dgvLesPersonnels);
            this.grpBoxLesPersonnels.Location = new System.Drawing.Point(12, 12);
            this.grpBoxLesPersonnels.Name = "grpBoxLesPersonnels";
            this.grpBoxLesPersonnels.Size = new System.Drawing.Size(776, 249);
            this.grpBoxLesPersonnels.TabIndex = 0;
            this.grpBoxLesPersonnels.TabStop = false;
            this.grpBoxLesPersonnels.Text = "Les Personnels";
            // 
            // grpBoxAjoutPersonnel
            // 
            this.grpBoxAjoutPersonnel.Controls.Add(this.btnAnnulerPersonnel);
            this.grpBoxAjoutPersonnel.Controls.Add(this.btnEnregistrerPersonnel);
            this.grpBoxAjoutPersonnel.Controls.Add(this.comboService);
            this.grpBoxAjoutPersonnel.Controls.Add(this.txtMail);
            this.grpBoxAjoutPersonnel.Controls.Add(this.txtTel);
            this.grpBoxAjoutPersonnel.Controls.Add(this.txtPrenom);
            this.grpBoxAjoutPersonnel.Controls.Add(this.txtNom);
            this.grpBoxAjoutPersonnel.Controls.Add(this.lblService);
            this.grpBoxAjoutPersonnel.Controls.Add(this.lblMail);
            this.grpBoxAjoutPersonnel.Controls.Add(this.lblTel);
            this.grpBoxAjoutPersonnel.Controls.Add(this.lblPrenom);
            this.grpBoxAjoutPersonnel.Controls.Add(this.lblNom);
            this.grpBoxAjoutPersonnel.Location = new System.Drawing.Point(12, 267);
            this.grpBoxAjoutPersonnel.Name = "grpBoxAjoutPersonnel";
            this.grpBoxAjoutPersonnel.Size = new System.Drawing.Size(311, 242);
            this.grpBoxAjoutPersonnel.TabIndex = 1;
            this.grpBoxAjoutPersonnel.TabStop = false;
            this.grpBoxAjoutPersonnel.Text = "Ajouter un personnel";
            // 
            // grpBoxAbsences
            // 
            this.grpBoxAbsences.Controls.Add(this.lblNomPersonnel);
            this.grpBoxAbsences.Controls.Add(this.comboMotif);
            this.grpBoxAbsences.Controls.Add(this.dateFin);
            this.grpBoxAbsences.Controls.Add(this.dateDebut);
            this.grpBoxAbsences.Controls.Add(this.lblMotif);
            this.grpBoxAbsences.Controls.Add(this.lblDateFin);
            this.grpBoxAbsences.Controls.Add(this.lblDateDebut);
            this.grpBoxAbsences.Controls.Add(this.lblPersonnel);
            this.grpBoxAbsences.Controls.Add(this.dgvAbsences);
            this.grpBoxAbsences.Controls.Add(this.btnModifierAbsence);
            this.grpBoxAbsences.Controls.Add(this.btnSupprimerAbsence);
            this.grpBoxAbsences.Controls.Add(this.btnEnregistrerAbsence);
            this.grpBoxAbsences.Controls.Add(this.btnAnnulerAbsence);
            this.grpBoxAbsences.Location = new System.Drawing.Point(329, 267);
            this.grpBoxAbsences.Name = "grpBoxAbsences";
            this.grpBoxAbsences.Size = new System.Drawing.Size(459, 242);
            this.grpBoxAbsences.TabIndex = 2;
            this.grpBoxAbsences.TabStop = false;
            this.grpBoxAbsences.Text = "Absences";
            // 
            // dgvLesPersonnels
            // 
            this.dgvLesPersonnels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLesPersonnels.Location = new System.Drawing.Point(6, 19);
            this.dgvLesPersonnels.Name = "dgvLesPersonnels";
            this.dgvLesPersonnels.Size = new System.Drawing.Size(764, 191);
            this.dgvLesPersonnels.TabIndex = 0;
            // 
            // btnGererAbsences
            // 
            this.btnGererAbsences.Location = new System.Drawing.Point(6, 216);
            this.btnGererAbsences.Name = "btnGererAbsences";
            this.btnGererAbsences.Size = new System.Drawing.Size(112, 23);
            this.btnGererAbsences.TabIndex = 1;
            this.btnGererAbsences.Text = "Gérer les absences";
            this.btnGererAbsences.UseVisualStyleBackColor = true;
            this.btnGererAbsences.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSuppPersonnel
            // 
            this.btnSuppPersonnel.Location = new System.Drawing.Point(658, 216);
            this.btnSuppPersonnel.Name = "btnSuppPersonnel";
            this.btnSuppPersonnel.Size = new System.Drawing.Size(112, 23);
            this.btnSuppPersonnel.TabIndex = 2;
            this.btnSuppPersonnel.Text = "Supprimer";
            this.btnSuppPersonnel.UseVisualStyleBackColor = true;
            // 
            // btnModifPersonnel
            // 
            this.btnModifPersonnel.Location = new System.Drawing.Point(540, 216);
            this.btnModifPersonnel.Name = "btnModifPersonnel";
            this.btnModifPersonnel.Size = new System.Drawing.Size(112, 23);
            this.btnModifPersonnel.TabIndex = 3;
            this.btnModifPersonnel.Text = "Modifier";
            this.btnModifPersonnel.UseVisualStyleBackColor = true;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(20, 33);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom";
            this.lblNom.Click += new System.EventHandler(this.lblNom_Click);
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(20, 69);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "Prénom";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(20, 101);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(22, 13);
            this.lblTel.TabIndex = 2;
            this.lblTel.Text = "Tel";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(20, 132);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(26, 13);
            this.lblMail.TabIndex = 3;
            this.lblMail.Text = "Mail";
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(20, 166);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(43, 13);
            this.lblService.TabIndex = 4;
            this.lblService.Text = "Service";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(88, 30);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(191, 20);
            this.txtNom.TabIndex = 5;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(88, 66);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(191, 20);
            this.txtPrenom.TabIndex = 6;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(88, 98);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(191, 20);
            this.txtTel.TabIndex = 7;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(88, 129);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(191, 20);
            this.txtMail.TabIndex = 8;
            // 
            // comboService
            // 
            this.comboService.FormattingEnabled = true;
            this.comboService.Location = new System.Drawing.Point(88, 163);
            this.comboService.Name = "comboService";
            this.comboService.Size = new System.Drawing.Size(191, 21);
            this.comboService.TabIndex = 9;
            // 
            // btnEnregistrerPersonnel
            // 
            this.btnEnregistrerPersonnel.Location = new System.Drawing.Point(6, 213);
            this.btnEnregistrerPersonnel.Name = "btnEnregistrerPersonnel";
            this.btnEnregistrerPersonnel.Size = new System.Drawing.Size(73, 23);
            this.btnEnregistrerPersonnel.TabIndex = 4;
            this.btnEnregistrerPersonnel.Text = "Enregistrer";
            this.btnEnregistrerPersonnel.UseVisualStyleBackColor = true;
            // 
            // btnAnnulerPersonnel
            // 
            this.btnAnnulerPersonnel.Location = new System.Drawing.Point(85, 213);
            this.btnAnnulerPersonnel.Name = "btnAnnulerPersonnel";
            this.btnAnnulerPersonnel.Size = new System.Drawing.Size(73, 23);
            this.btnAnnulerPersonnel.TabIndex = 10;
            this.btnAnnulerPersonnel.Text = "Annuler";
            this.btnAnnulerPersonnel.UseVisualStyleBackColor = true;
            this.btnAnnulerPersonnel.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAnnulerAbsence
            // 
            this.btnAnnulerAbsence.Location = new System.Drawing.Point(380, 213);
            this.btnAnnulerAbsence.Name = "btnAnnulerAbsence";
            this.btnAnnulerAbsence.Size = new System.Drawing.Size(73, 23);
            this.btnAnnulerAbsence.TabIndex = 11;
            this.btnAnnulerAbsence.Text = "Annuler";
            this.btnAnnulerAbsence.UseVisualStyleBackColor = true;
            // 
            // btnEnregistrerAbsence
            // 
            this.btnEnregistrerAbsence.Location = new System.Drawing.Point(301, 213);
            this.btnEnregistrerAbsence.Name = "btnEnregistrerAbsence";
            this.btnEnregistrerAbsence.Size = new System.Drawing.Size(73, 23);
            this.btnEnregistrerAbsence.TabIndex = 11;
            this.btnEnregistrerAbsence.Text = "Enregistrer";
            this.btnEnregistrerAbsence.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerAbsence
            // 
            this.btnSupprimerAbsence.Location = new System.Drawing.Point(6, 213);
            this.btnSupprimerAbsence.Name = "btnSupprimerAbsence";
            this.btnSupprimerAbsence.Size = new System.Drawing.Size(73, 23);
            this.btnSupprimerAbsence.TabIndex = 12;
            this.btnSupprimerAbsence.Text = "Supprimer";
            this.btnSupprimerAbsence.UseVisualStyleBackColor = true;
            // 
            // btnModifierAbsence
            // 
            this.btnModifierAbsence.Location = new System.Drawing.Point(85, 213);
            this.btnModifierAbsence.Name = "btnModifierAbsence";
            this.btnModifierAbsence.Size = new System.Drawing.Size(73, 23);
            this.btnModifierAbsence.TabIndex = 13;
            this.btnModifierAbsence.Text = "Modifier";
            this.btnModifierAbsence.UseVisualStyleBackColor = true;
            // 
            // dgvAbsences
            // 
            this.dgvAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsences.Location = new System.Drawing.Point(6, 19);
            this.dgvAbsences.Name = "dgvAbsences";
            this.dgvAbsences.Size = new System.Drawing.Size(225, 188);
            this.dgvAbsences.TabIndex = 14;
            // 
            // lblPersonnel
            // 
            this.lblPersonnel.AutoSize = true;
            this.lblPersonnel.Location = new System.Drawing.Point(252, 33);
            this.lblPersonnel.Name = "lblPersonnel";
            this.lblPersonnel.Size = new System.Drawing.Size(60, 13);
            this.lblPersonnel.TabIndex = 11;
            this.lblPersonnel.Text = "Personnel :";
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Location = new System.Drawing.Point(237, 69);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(75, 13);
            this.lblDateDebut.TabIndex = 15;
            this.lblDateDebut.Text = "Date de début";
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Location = new System.Drawing.Point(253, 101);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(59, 13);
            this.lblDateFin.TabIndex = 16;
            this.lblDateFin.Text = "Date de fin";
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(282, 132);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(30, 13);
            this.lblMotif.TabIndex = 17;
            this.lblMotif.Text = "Motif";
            // 
            // dateDebut
            // 
            this.dateDebut.Location = new System.Drawing.Point(318, 66);
            this.dateDebut.Name = "dateDebut";
            this.dateDebut.Size = new System.Drawing.Size(135, 20);
            this.dateDebut.TabIndex = 18;
            // 
            // dateFin
            // 
            this.dateFin.Location = new System.Drawing.Point(318, 98);
            this.dateFin.Name = "dateFin";
            this.dateFin.Size = new System.Drawing.Size(135, 20);
            this.dateFin.TabIndex = 19;
            // 
            // comboMotif
            // 
            this.comboMotif.FormattingEnabled = true;
            this.comboMotif.Location = new System.Drawing.Point(318, 128);
            this.comboMotif.Name = "comboMotif";
            this.comboMotif.Size = new System.Drawing.Size(135, 21);
            this.comboMotif.TabIndex = 11;
            // 
            // lblNomPersonnel
            // 
            this.lblNomPersonnel.AutoSize = true;
            this.lblNomPersonnel.Location = new System.Drawing.Point(318, 33);
            this.lblNomPersonnel.Name = "lblNomPersonnel";
            this.lblNomPersonnel.Size = new System.Drawing.Size(68, 13);
            this.lblNomPersonnel.TabIndex = 20;
            this.lblNomPersonnel.Text = "Nom Prénom";
            // 
            // FrmMediaTek86
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.grpBoxAbsences);
            this.Controls.Add(this.grpBoxAjoutPersonnel);
            this.Controls.Add(this.grpBoxLesPersonnels);
            this.Name = "FrmMediaTek86";
            this.Text = "MediaTek86";
            this.Load += new System.EventHandler(this.FrmMediaTek86_Load);
            this.grpBoxLesPersonnels.ResumeLayout(false);
            this.grpBoxAjoutPersonnel.ResumeLayout(false);
            this.grpBoxAjoutPersonnel.PerformLayout();
            this.grpBoxAbsences.ResumeLayout(false);
            this.grpBoxAbsences.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLesPersonnels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxLesPersonnels;
        private System.Windows.Forms.GroupBox grpBoxAjoutPersonnel;
        private System.Windows.Forms.GroupBox grpBoxAbsences;
        private System.Windows.Forms.Button btnGererAbsences;
        private System.Windows.Forms.DataGridView dgvLesPersonnels;
        private System.Windows.Forms.Button btnModifPersonnel;
        private System.Windows.Forms.Button btnSuppPersonnel;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Button btnAnnulerPersonnel;
        private System.Windows.Forms.Button btnEnregistrerPersonnel;
        private System.Windows.Forms.ComboBox comboService;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Button btnEnregistrerAbsence;
        private System.Windows.Forms.Button btnAnnulerAbsence;
        private System.Windows.Forms.Label lblNomPersonnel;
        private System.Windows.Forms.ComboBox comboMotif;
        private System.Windows.Forms.DateTimePicker dateFin;
        private System.Windows.Forms.DateTimePicker dateDebut;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.Label lblPersonnel;
        private System.Windows.Forms.DataGridView dgvAbsences;
        private System.Windows.Forms.Button btnModifierAbsence;
        private System.Windows.Forms.Button btnSupprimerAbsence;
    }
}

