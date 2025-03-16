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
    public partial class frmTransactions : Form
    {
        BankingContext db = new BankingContext();
        public frmTransactions()
        {
            InitializeComponent();
        }

        private void cbbType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbType.Text == "Virement")
            {
                cbbDestinataire.Visible = true;
                cbbSource.Visible = true;
                lblCompteSource.Visible = true;
                lblDestinataire.Visible = true;
                ClearField();
            }
            if (cbbType.Text == "Dépôt")
            {
                cbbSource.Visible = false;
                lblCompteSource.Visible = false;
                lblDestinataire.Visible = true;
                cbbDestinataire.Visible = true;
                ClearField();
            }
            if (cbbType.Text == "Retrait")
            {
                cbbSource.Visible = true;
                lblCompteSource.Visible = true;
                lblDestinataire.Visible = false;
                cbbDestinataire.Visible = false;
                ClearField();
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction();
            transaction.Montant = int.Parse(txtMontant.Text);
            transaction.Date = DateTime.Now;
            transaction.Type = cbbType.Text;
            if (cbbType.Text == "Virement")
            {
                Compte comS = db.Comptes.Where(c => c.Numero == cbbSource.Text).FirstOrDefault();
                Compte comD = db.Comptes.Where(c => c.Numero == cbbDestinataire.Text).FirstOrDefault();
                comD.Solde += transaction.Montant;
                comS.Solde -= transaction.Montant;
                db.SaveChanges();
                transaction.CompteSourceId = comS.Id;
                transaction.CompteDestId = comD.Id;
            }
            if (cbbType.Text == "Dépôt")
            {
                Compte comD = db.Comptes.Where(c => c.Numero == cbbDestinataire.Text).FirstOrDefault();
                comD.Solde += transaction.Montant;
                db.SaveChanges();
                transaction.CompteDestId = comD.Id;
            }
            if (cbbType.Text == "Retrait")
            {
                Compte comS = db.Comptes.Where(c => c.Numero == cbbSource.Text).FirstOrDefault();
                comS.Solde -= transaction.Montant;
                db.SaveChanges();
                transaction.CompteSourceId = comS.Id;
            }
            db.Transactions.Add(transaction);
            db.SaveChanges();
            ClearField();
        }

        private void ClearField()
        {
            txtMontant.Text = string.Empty;
            cbbDestinataire.Text = string.Empty;
            cbbSource.Text = string.Empty;
            cbbType.Text = string.Empty;
            dgTransaction.DataSource = db.Transactions.Select(a => new
            {
                a.Id,
                a.CompteDest,
                a.CompteSource,
                a.Type,
                a.Montant,
                a.Date
            }).ToList();
            cbbSource.DataSource = chargerCompte(null);
            cbbSource.ValueMember = "Value";
            cbbSource.DisplayMember = "Text";
            cbbDestinataire.DataSource = chargerCompte(null);
            cbbDestinataire.ValueMember = "Value";
            cbbDestinataire.DisplayMember = "Text";
        }
        private List<ComboBoxItem> chargerCompte(int? id)
        {
            List<ComboBoxItem> ListItems = new List<ComboBoxItem>();
            ComboBoxItem i = new ComboBoxItem();
            i.Text = "Selectionnez un compte";
            i.Value = 0;
            ListItems.Add(i);
            foreach (var item in db.Comptes.Where(a => a.Id != id).ToList())
            {
                ComboBoxItem j = new ComboBoxItem();
                j.Text = item.Numero;
                j.Value = item.Id;
                ListItems.Add(j);
            }

            return ListItems;
        }

        private void frmTransactions_Load(object sender, EventArgs e)
        {
            ClearField();
        }

        private void cbbSource_SelectedValueChanged(object sender, EventArgs e)
        {
            int idS = 0;
            if (int.TryParse(cbbSource.SelectedValue.ToString(), out idS))
            {
                if (idS != 0 && (cbbDestinataire.Text == "Selectionnez un compte" || cbbDestinataire.Text == cbbSource.Text))
                {
                    cbbDestinataire.DataSource = chargerCompte(int.Parse(cbbSource.SelectedValue.ToString()));
                    cbbDestinataire.ValueMember = "Value";
                    cbbDestinataire.DisplayMember = "Text";

                }
            }
        }

        private void cbbDestinataire_SelectedValueChanged(object sender, EventArgs e)
        {
            int idD = 0;
            if (int.TryParse(cbbDestinataire.SelectedValue.ToString(), out idD))
            {
                if (idD != 0 && (cbbSource.Text == "Selectionnez un compte" || cbbDestinataire.Text == cbbSource.Text))
                {
                    cbbSource.DataSource = chargerCompte(int.Parse(cbbDestinataire.SelectedValue.ToString()));
                    cbbSource.ValueMember = "Value";
                    cbbSource.DisplayMember = "Text";
                }
            }
        }
    }
}
