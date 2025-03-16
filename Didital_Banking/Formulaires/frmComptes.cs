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
    public partial class frmComptes : Form
    {
        BankingContext db = new BankingContext();
        public frmComptes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fonction permettant de charger les clients 
        /// </summary>
        /// <returns>List de clients pour un combobox</returns>
        private List<ComboBoxItem> chargerClient()
        {
            List<ComboBoxItem> ListItems = new List<ComboBoxItem>();
            ComboBoxItem i = new ComboBoxItem();
            i.Text = "Selectionnez un client";
            i.Value = 0;
            ListItems.Add(i);
            foreach (var item in db.Clients.ToList())
            {
                ComboBoxItem j = new ComboBoxItem();
                j.Text = item.Nom.ToString()+" "+item.Prenom.ToString();
                j.Value = item.Id;
                ListItems.Add(j);
            }

            return ListItems;
        }

        /// <summary>
        /// Fonction pour ajouter un compte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Compte compte = new Compte();
            compte.Solde = int.Parse(txtSolde.Text);
            compte.ClientId = int.Parse(cbbClient.SelectedValue.ToString());
            compte.Type = cbbType.Text;
            compte.Numero = txtNumero.Text;
            db.Comptes.Add(compte);
            db.SaveChanges();
            ClearField();

        }

        /// <summary>
        /// Fonction permettant d'afficher le solde
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgComptes_MouseClick(object sender, MouseEventArgs e)
        {
            Compte compte = db.Comptes.Find(int.Parse(dgComptes.CurrentRow.Cells[0].Value.ToString()));
            if(compte!=null)
            MessageBox.Show(string.Format("Le compte {0} a un solde de {1}",compte.Numero,compte.Solde));

        }

        private void frmComptes_Load(object sender, EventArgs e)
        {
            ClearField();
        }

        private void ClearField()
        {
            txtNumero.Text = string.Empty;
            txtSolde.Text = string.Empty;
            cbbType.Text = string.Empty;
            cbbClient.DataSource = chargerClient();
            cbbClient.ValueMember = "Value";
            cbbClient.DisplayMember = "Text";
            dgComptes.DataSource = db.Comptes.Select(a=> new
            {
                a.Id,
                a.Numero,
                a.Solde,
                a.Client,
                a.Type,

            }).ToList();
            txtNumero.Focus();
        }
    }
    public class ComboBoxItem
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
