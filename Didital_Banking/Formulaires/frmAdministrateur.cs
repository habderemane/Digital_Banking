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
    public partial class frmAdministrateur : Form
    {
        BankingContext db = new BankingContext();
        public frmAdministrateur()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim()==string.Empty||txtUsername.Text.Trim()==string.Empty)
            {
            }
            else
            {
                Admin admin = new Admin();
                admin.Password = txtPassword.Text;
                admin.Username = txtUsername.Text;
                db.Admins.Add(admin);
                db.SaveChanges();
                MessageBox.Show("Administrateur ajoute avec succes!");
                ClearField();
            }
        }

        private void ClearField()
        {
            txtPassword.Text = string.Empty;
            txtUsername.Text = string.Empty;
            dgAdministrateur.DataSource = db.Admins.ToList();
            txtUsername.Focus();
            btnSupprimer.Enabled = false;
        }

        private void dgAdministrateur_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgAdministrateur.CurrentRow.Cells[0].Value.ToString()!="")
            {
                btnSupprimer.Enabled = true;
            }
        }

        private void frmAdministrateur_Load(object sender, EventArgs e)
        {
            ClearField();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgAdministrateur.CurrentRow.Cells[0].Value.ToString() != "")
            {
                Admin admin = db.Admins.Find(int.Parse(dgAdministrateur.CurrentRow.Cells[0].Value.ToString()));
                if (admin != null)
                {
                    db.Admins.Remove(admin);
                    db.SaveChanges();
                    ClearField();
                }
            }
        }
    }
}
