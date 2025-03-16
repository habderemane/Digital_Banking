using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Didital_Banking
{
    public partial class frmMainMenu : Form
    {
        private Button currentButton;
        private Form activeForm;

        // Deplacement

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd,
            int wMsg, int wParam, int lParam);

        public frmMainMenu()
        {
            InitializeComponent();
            btnCloseChildForm.Visible = false;
            lblTitre.Location = new Point((panelHead.Width - lblTitre.Width) / 2, (panelHead.Height - lblTitre.Height) / 2);
            this.Text = string.Empty;
            this.ControlBox = false;
        }

        // methode de gestion de formulaire enfant

        // Marquage du bouton utilisé
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.Blue;
                    currentButton.ForeColor = Color.White; ;
                    btnCloseChildForm.Visible = true;
                }
            }
        }
        // deactivation des boutons 

        private void DisableButton()
        {
            foreach (Control previonsBtn in panelBar.Controls)
            {
                if (previonsBtn.GetType() == typeof(Button))
                {
                    previonsBtn.BackColor = Color.White;
                    previonsBtn.ForeColor = Color.Blue;

                }
            }
        }
        // Chargement des formulaires enfants
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.Width = pnlBody.Width;
            childForm.Height = pnlBody.Height;
            this.pnlBody.Controls.Add(childForm);
            this.pnlBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitre.Text = childForm.Text;
            lblTitre.Location = new Point((panelHead.Width - lblTitre.Width) / 2, (panelHead.Height - lblTitre.Height) / 2);

        }

        // Fermeture de formulaire
        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            lblTitre.Text = "MENU";
            currentButton = null;
            btnCloseChildForm.Visible = false;
            lblTitre.Location = new Point((panelHead.Width - lblTitre.Width) / 2, (panelHead.Height - lblTitre.Height) / 2);
        }



        // controle de la fenetre
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                btnClients.Height += 20;
                btnComptes.Height += 20;
                btnTransactions.Height += 20;
                btnAdministrateurs.Height += 20;
                pnlLogo.Height += 20;
                lblTitre.Location = new Point((panelHead.Width - lblTitre.Width) / 2, (panelHead.Height - lblTitre.Height) / 2);
                panelHead.Height += 20;
                btnCloseChildForm.Height += 20;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                lblTitre.Location = new Point((panelHead.Width - lblTitre.Width) / 2, (panelHead.Height - lblTitre.Height) / 2);
                btnClients.Height -= 20;
                btnComptes.Height -= 20;
                btnTransactions.Height -= 20;
                btnTransactions.Height -= 20;
                btnAdministrateurs.Height -= 20;
                pnlLogo.Height -= 20;
                panelHead.Height -= 20;
                btnCloseChildForm.Height -= 20;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formulaires.frmClients(), sender);
        }

        private void btnComptes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formulaires.frmComptes(), sender);
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formulaires.frmTransactions(), sender);
        }

        private void btnAdministrateurs_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formulaires.frmAdministrateur(), sender);
        }
    }
}
