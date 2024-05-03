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
    }
}
