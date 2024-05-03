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
        /// Booléan pour savoir si une modification est demandée
        /// </summary>
        private Boolean modifPersonnel = false;

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

        private void btnGererAbsences_Click(object sender, EventArgs e)
        {
            if (dgvLesPersonnels.SelectedRows.Count > 0)
            {
                int idpersonnel = (int)dgvLesPersonnels.SelectedRows[0].Cells["idpersonnel"].Value;
                List<Absences> lesAbsences = controller.GetlesAbsences(idpersonnel);
                bdgAbsences.DataSource = lesAbsences;
                dgvAbsences.DataSource = bdgAbsences;
                dgvAbsences.Columns["Personnel"].Visible = false;
                dgvAbsences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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
                    personnel.Nom = txtNom.Text;
                    personnel.Prenom = txtPrenom.Text;
                    personnel.Tel = txtTel.Text;
                    personnel.Mail = txtMail.Text;
                    personnel.Service = service;
                    controller.UpdatePersonnel(personnel);
                }
                else
                {
                    Personnel personnel = new Personnel(0, txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text, service);
                    controller.AddPersonnel(personnel);
                }
                RemplirListePersonnels();
                EnCoursModifPersonnel(false);
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
                Personnel personnel = (Personnel)bdgPersonnels.List[bdgPersonnels.Position];
                txtNom.Text = personnel.Nom;
                txtPrenom.Text = personnel.Prenom;
                txtTel.Text = personnel.Tel;
                txtMail.Text = personnel.Mail;
                comboService.SelectedIndex = comboService.FindStringExact(personnel.Service.Nom);
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
                grpBoxLesPersonnels.Text = "modifier un personnel";
            }
            else
            {
                grpBoxLesPersonnels.Text = "ajouter un personnel";
                txtNom.Text = "";
                txtPrenom.Text = "";
                txtTel.Text = "";
                txtMail.Text = "";
            }
        }
    }
}
