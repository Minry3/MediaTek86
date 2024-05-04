using System;
using MediaTek86.controller;
using MediaTek86.model;
using System.Windows.Forms;

namespace MediaTek86.view
{
    /// <summary>
    /// Fenêtre de connexion (seul le responsable peut accéder à l'application)
    /// </summary>
    public partial class FrmConnexion : Form
    {
        /// <summary>
        /// Contrôleur de la fenêtre
        /// </summary>
        private FrmConnexionController controller;

        /// <summary>
        /// Construction des composants graphiques et appel des autres initialisations
        /// </summary>
        public FrmConnexion()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initialisation:
        /// Création du contrôleur
        /// </summary>
        private void Init()
        {
            controller = new FrmConnexionController();
        }

        /// <summary>
        /// Demande au contrôleur de contrôler la connexion du responsable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            String login = txtLogin.Text;
            String pwd = txtMdp.Text;
            if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
            else
            {
                Responsable responsable = new Responsable(login, pwd);
                if (controller.ControleConnexion(responsable))
                {
                    FrmMediaTek86 frm = new FrmMediaTek86();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Connexion incorrecte. Le login et/ou le mot de passe sont incorrects", "Alerte");
                }
            }
        }

        /// <summary>
        /// Demande d'afficher le mot de passe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxAfficherPwd_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAfficherPwd.Checked)
            {
                txtMdp.UseSystemPasswordChar = false;
            }
            else
            {
                txtMdp.UseSystemPasswordChar = true;
            }
        }
    }
}
