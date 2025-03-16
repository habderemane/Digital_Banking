using Didital_Banking.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Didital_Banking.Formulaires
{
    public partial class frmClients : Form
    {
        BankingContext db = new BankingContext();
        int? id;
        public frmClients()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Telephone = txtTelephone.Text;
            client.Email = txtEmail.Text;
            client.DateInscription = dtpDate.Value;
            client.Prenom = txtPrenom.Text;
            client.Nom = txtNom.Text;
            db.Clients.Add(client);
            db.SaveChanges();
            ClearField();
            
        }

        private void frmClients_Load(object sender, EventArgs e)
        {
            ClearField();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (id!=null)
            {
                Client client = db.Clients.Find(id);
                client.Telephone = txtTelephone.Text;
                client.Email = txtEmail.Text;
                client.DateInscription = dtpDate.Value;
                client.Prenom = txtPrenom.Text;
                client.Nom = txtNom.Text;
                db.SaveChanges();
                ClearField();
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (id!=null)
            {
                Client client= db.Clients.Find(id);
                db.Clients.Remove(client);
                db.SaveChanges();
                ClearField() ;
            }

        }
        private void ClearField()
        {
            id= null;
            txtNom.Text = string.Empty;
            txtPrenom.Text = string.Empty;
            txtTelephone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            dtpDate.Text = string.Empty;
            dgClients.DataSource = db.Clients.ToList();
            txtNom.Focus();
            btnSupprimer.Enabled = false;
            btnModifier.Enabled = false;
        }

        private void dgClients_MouseClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(dgClients.CurrentRow.Cells[0].Value.ToString());
            Client client = db.Clients.Find(int.Parse(dgClients.CurrentRow.Cells[0].Value.ToString()));
            if (client!=null)
            {
                txtNom.Text = client.Nom;
                txtPrenom.Text= client.Prenom;
                txtTelephone.Text= client.Telephone;
                txtEmail.Text= client.Email;
                dtpDate.Value = client.DateInscription;
                btnAjouter.Enabled = false;
                btnSupprimer.Enabled = true;
                btnModifier.Enabled = true;
            }
        }
    }
}
