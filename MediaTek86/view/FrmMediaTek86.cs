using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MediaTek86.controller;
using MediaTek86.model;

namespace MediaTek86
{
    /// <summary>
    /// Fenêtre d'affichage des personnels et de leur service
    /// </summary>
    public partial class FrmMediaTek86 : Form
    {
        /// <summary>
        /// Objet pour gérer la liste des personnels
        /// </summary>
        private BindingSource bdgPersonnels = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des services
        /// </summary>
        private BindingSource bdgServices = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des motifs
        /// </summary>
        private BindingSource bdgMotifs = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des absences
        /// </summary>
        private BindingSource bdgAbsences = new BindingSource();
        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FrmMediaTek86Controller controller;
        /// <summary>
        /// Booléan pour savoir si une modification de personnel est demandée
        /// </summary>
        private Boolean modifPersonnel = false;
        /// <summary>
        /// Booléan pour savoir si une modification d'absence est demandée
        /// </summary>
        private Boolean modifAbsence = false;

        /// <summary>
        /// construction des composants graphiques et appel des autres initialisations
        /// </summary>
        public FrmMediaTek86()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initialisations :
        /// Création du controleur et remplissage des listes
        /// </summary>
        private void Init()
        {
            controller = new FrmMediaTek86Controller();
            RemplirListePersonnels();
            RemplirListeServices();
            RemplirListeMotifs();
            EnCoursModifPersonnel(false);
            EnCoursGestionAbsence(false);
        }

        /// <summary>
        /// Afficher les personnels
        /// </summary>
        private void RemplirListePersonnels()
        {
            List<Personnel> lesPersonnels = controller.GetLesPersonnels();
            bdgPersonnels.DataSource = lesPersonnels;
            dgvLesPersonnels.DataSource = bdgPersonnels;
            dgvLesPersonnels.Columns["idpersonnel"].Visible = false;
            dgvLesPersonnels.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// Affiche les services
        /// </summary>
        private void RemplirListeServices()
        {
            List<Service> lesServices = controller.GetLesServices();
            bdgServices.DataSource = lesServices;
            comboService.DataSource = bdgServices;
        }

        /// <summary>
        /// Affiche les motifs
        /// </summary>
        private void RemplirListeMotifs()
        {
            List<Motif> lesMotifs = controller.GetLesMotifs();
            bdgMotifs.DataSource = lesMotifs;
            comboMotif.DataSource = bdgMotifs;
        }


        /// <summary>
        /// Affiche les absences du personnel sélectionné
        /// </summary>
        private void RemplirListeAbsences()
        {
            int idpersonnel = (int)dgvLesPersonnels.SelectedRows[0].Cells["idpersonnel"].Value;
            List<Absences> lesAbsences = controller.GetlesAbsences(idpersonnel);
            bdgAbsences.DataSource = lesAbsences;
            dgvAbsences.DataSource = bdgAbsences;
            dgvAbsences.Columns["Personnel"].Visible = false;
            dgvAbsences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        /// <summary>
        /// Demande de gestion d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGererAbsences_Click(object sender, EventArgs e)
        {
            if (dgvLesPersonnels.SelectedRows.Count > 0)
            {
                EnCoursGestionAbsence(true);
                RemplirListeAbsences();
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        /// <summary>
        /// Demande d'enregistrement de l'ajout ou de la modif d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrerPersonnel_Click(object sender, EventArgs e)
        {
            if (!txtNom.Text.Equals("") && !txtPrenom.Text.Equals("") && !txtTel.Text.Equals("") && !txtMail.Text.Equals("") && comboService.SelectedIndex != -1)
            {
                Service service = (Service)bdgServices.List[bdgServices.Position];
                if (modifPersonnel)
                {
                    Personnel personnel = (Personnel)bdgPersonnels.List[bdgPersonnels.Position];
                    if (MessageBox.Show("Voulez-vous vraiment modifier " + personnel.Nom + " " + personnel.Prenom + " ?", "Confirmation de modification", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        personnel.Nom = txtNom.Text;
                        personnel.Prenom = txtPrenom.Text;
                        personnel.Tel = txtTel.Text;
                        personnel.Mail = txtMail.Text;
                        personnel.Service = service;
                        controller.UpdatePersonnel(personnel);
                    }
                }
                else
                {
                    Personnel personnel = new Personnel(0, txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text, service);
                    controller.AddPersonnel(personnel);
                }
                RemplirListePersonnels();
                EnCoursModifPersonnel(false);
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }

        /// <summary>
        /// Demande de modification d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifPersonnel_Click(object sender, EventArgs e)
        {
            if(dgvLesPersonnels.SelectedRows.Count > 0)
            {
                modifPersonnel = true;
                EnCoursModifPersonnel(true);
                Personnel personnel = (Personnel)bdgPersonnels.List[bdgPersonnels.Position];
                txtNom.Text = personnel.Nom;
                txtPrenom.Text = personnel.Prenom;
                txtTel.Text = personnel.Tel;
                txtMail.Text = personnel.Mail;
                comboService.SelectedIndex = comboService.FindStringExact(personnel.Service.Nom);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }


        /// <summary>
        /// Modification de l'affichage selon le statut de la demande (en cours de modif ou ajout d'un personnel)
        /// </summary>
        /// <param name="enCours"></param>
        private void EnCoursModifPersonnel(Boolean enCours)
        {
            modifPersonnel = enCours;
            grpBoxLesPersonnels.Enabled = !enCours;
            if (enCours)
            {
                grpBoxAjoutPersonnel.Text = "modifier un personnel";
            }
            else
            {
                grpBoxAjoutPersonnel.Text = "ajouter un personnel";
                txtNom.Text = "";
                txtPrenom.Text = "";
                txtTel.Text = "";
                txtMail.Text = "";
            }
        }

        /// <summary>
        /// Modification de l'affichage selon le statut de la demande (gestion des absences)
        /// </summary>
        /// <param name="enCours"></param>
        private void EnCoursGestionAbsence(Boolean enCours)
        {
            grpBoxAbsences.Enabled = enCours;
            grpBoxLesPersonnels.Enabled = !enCours;
            grpBoxAjoutPersonnel.Enabled = !enCours;
            btnAnnulerAbsence.Enabled = !enCours;
            if (enCours)
            {
                Personnel personnel = (Personnel)bdgPersonnels.List[bdgPersonnels.Position];
                lblNomPersonnel.Text = (string)personnel.Nom + " " + (string)personnel.Prenom;
                dgvAbsences.Focus();
            }
            else
            {
                lblNomPersonnel.Text = "";
                dgvAbsences.DataSource = null;
                if (dgvLesPersonnels.Rows.Count > 0)
                {
                    dgvLesPersonnels.FirstDisplayedScrollingRowIndex = 0;
                    dgvLesPersonnels.Rows[0].Selected = true;
                }
            }
        }

        /// <summary>
        /// Modification de l'affichage selon le statut de la demande (modif d'une absence)
        /// </summary>
        /// <param name="enCours"></param>
        public void EnCoursModifAbsence(Boolean enCours)
        {
            modifAbsence = enCours;
            btnAnnulerAbsence.Enabled = enCours;
            btnSupprimerAbsence.Enabled = !enCours;
            btnModifierAbsence.Enabled = !enCours;
        }

        /// <summary>
        /// Demande de suppression d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSuppPersonnel_Click(object sender, EventArgs e)
        {
            if (dgvLesPersonnels.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnels.List[bdgPersonnels.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer " + personnel.Nom + " " + personnel.Prenom + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelPersonnel(personnel);
                    RemplirListePersonnels();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }
        
        /// <summary>
        /// Annuler la demande d'ajout ou de modif d'un personnel
        /// Vide les zones de sasie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnulerPersonnel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EnCoursModifPersonnel(false);
            }
        }

        /// <summary>
        /// Annulation de la demande de gestion des absences d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnulerAbsence_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EnCoursModifAbsence(false);
                lblNomPersonnel.Text = "";
            }
        }

        /// <summary>
        /// Demande de modification d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifierAbsence_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                modifAbsence = true;
                EnCoursModifAbsence(true);
                Absences absence = (Absences)bdgAbsences.List[bdgAbsences.Position];
                dateDebut.Value = absence.DateDebut;
                dateFin.Value = absence.DateFin;
                comboMotif.SelectedIndex = comboMotif.FindStringExact(absence.Motif.Libelle);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        /// <summary>
        /// Demande d'enregistrement d'une modification ou d'un ajout d'absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrerAbsence_Click(object sender, EventArgs e)
        {
            if (dateDebut.Value < dateFin.Value && comboService.SelectedIndex != -1)
            {
                Personnel personnel = (Personnel)bdgPersonnels.List[bdgPersonnels.Position];
                Motif motif = (Motif)bdgMotifs.List[bdgMotifs.Position];
                if (modifAbsence)
                {
                    Absences absence = (Absences)bdgAbsences.List[bdgAbsences.Position];
                    if (MessageBox.Show("Voulez-vous vraiment modifier l'absence de " + lblNomPersonnel.Text + " ?", "Confirmation de modification", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DateTime ancienneDateDebut = absence.DateDebut;
                        absence.DateDebut = dateDebut.Value;
                        absence.DateFin = dateFin.Value;
                        absence.Motif = motif;
                        controller.UpdateAbsence(absence, ancienneDateDebut);
                    }
                }
                else
                {
                    Absences absence = new Absences(personnel, dateDebut.Value, dateFin.Value, motif);
                    controller.AddAbsence(absence);
                }
                RemplirListeAbsences();
                EnCoursModifAbsence(false);
            }
            else
            {
                MessageBox.Show("La date de début doit être antérieure à la date de fin.", "Information");
            }
        }

        /// <summary>
        /// Demande de retour à la liste des personnels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRetour_Click(object sender, EventArgs e)
        {
            EnCoursGestionAbsence(false);
        }

        /// <summary>
        /// Permet de rendre l'annulation de l'ajout ou de la modif d'absence possible
        /// </summary>
        private void AnnulationAbsence()
        {
            btnAnnulerAbsence.Enabled = true;
        }
        /// <summary>
        /// Changement de la valeur permettant de sélectionner la date de début d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateDebut_ValueChanged(object sender, EventArgs e)
        {
            AnnulationAbsence();
        }

        /// <summary>
        /// Changement de la valeur permettant de sélectionner la date de fin d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateFin_ValueChanged(object sender, EventArgs e)
        {
            AnnulationAbsence();
        }

        /// <summary>
        /// Changement de la valeur permettant de sélectionner le motif d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboMotif_SelectedIndexChanged(object sender, EventArgs e)
        {
            AnnulationAbsence();
        }

        /// <summary>
        /// Demande de suppression d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimerAbsence_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                Absences absence = (Absences)bdgAbsences.List[bdgAbsences.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer l'absence de " + absence.Personnel.Nom + " " + absence.Personnel.Prenom + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelAbsence(absence);
                    RemplirListeAbsences();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }
    }
}
