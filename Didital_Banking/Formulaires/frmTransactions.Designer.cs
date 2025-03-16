namespace Didital_Banking.Formulaires
{
    partial class frmTransactions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.btnValider = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter9 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgTransaction = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbProduits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.splitter6 = new System.Windows.Forms.Splitter();
            this.lblCompteSource = new System.Windows.Forms.Label();
            this.cbbSource = new System.Windows.Forms.ComboBox();
            this.cbbDestinataire = new System.Windows.Forms.ComboBox();
            this.lblDestinataire = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66667F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(882, 738);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbDestinataire);
            this.panel1.Controls.Add(this.lblDestinataire);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.cbbSource);
            this.panel1.Controls.Add(this.lblCompteSource);
            this.panel1.Controls.Add(this.splitter6);
            this.panel1.Controls.Add(this.txtMontant);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.splitter4);
            this.panel1.Controls.Add(this.cbbType);
            this.panel1.Controls.Add(this.splitter3);
            this.panel1.Controls.Add(this.btnValider);
            this.panel1.Controls.Add(this.splitter2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.splitter9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 672);
            this.panel1.TabIndex = 0;
            // 
            // splitter3
            // 
            this.splitter3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter3.Location = new System.Drawing.Point(10, 602);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(277, 10);
            this.splitter3.TabIndex = 11;
            this.splitter3.TabStop = false;
            // 
            // btnValider
            // 
            this.btnValider.AutoSize = true;
            this.btnValider.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnValider.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnValider.FlatAppearance.BorderSize = 0;
            this.btnValider.FlatAppearance.CheckedBackColor = System.Drawing.Color.Aqua;
            this.btnValider.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnValider.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValider.ForeColor = System.Drawing.Color.White;
            this.btnValider.Location = new System.Drawing.Point(10, 612);
            this.btnValider.MaximumSize = new System.Drawing.Size(0, 80);
            this.btnValider.MinimumSize = new System.Drawing.Size(0, 50);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(277, 50);
            this.btnValider.TabIndex = 10;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // splitter2
            // 
            this.splitter2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter2.Location = new System.Drawing.Point(10, 662);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(277, 10);
            this.splitter2.TabIndex = 9;
            this.splitter2.TabStop = false;
            // 
            // splitter9
            // 
            this.splitter9.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitter9.Location = new System.Drawing.Point(0, 0);
            this.splitter9.Name = "splitter9";
            this.splitter9.Size = new System.Drawing.Size(10, 672);
            this.splitter9.TabIndex = 17;
            this.splitter9.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgTransaction);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(296, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 672);
            this.panel2.TabIndex = 1;
            // 
            // dgTransaction
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dgTransaction.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgTransaction.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgTransaction.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgTransaction.Location = new System.Drawing.Point(0, 0);
            this.dgTransaction.Name = "dgTransaction";
            this.dgTransaction.RowHeadersWidth = 51;
            this.dgTransaction.RowTemplate.Height = 24;
            this.dgTransaction.Size = new System.Drawing.Size(583, 672);
            this.dgTransaction.TabIndex = 12;
            // 
            // Nom
            // 
            this.Nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nom.HeaderText = "Nom";
            this.Nom.MinimumWidth = 10;
            this.Nom.Name = "Nom";
            // 
            // Adresse
            // 
            this.Adresse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Adresse.HeaderText = "Adresse";
            this.Adresse.MinimumWidth = 6;
            this.Adresse.Name = "Adresse";
            // 
            // PU
            // 
            this.PU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PU.HeaderText = "Telephone";
            this.PU.MinimumWidth = 6;
            this.PU.Name = "PU";
            // 
            // nbProduits
            // 
            this.nbProduits.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nbProduits.HeaderText = "Produits";
            this.nbProduits.MinimumWidth = 6;
            this.nbProduits.Name = "nbProduits";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type";
            // 
            // cbbType
            // 
            this.cbbType.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Items.AddRange(new object[] {
            "Dépôt",
            "Retrait",
            "Virement"});
            this.cbbType.Location = new System.Drawing.Point(10, 29);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(277, 37);
            this.cbbType.TabIndex = 18;
            this.cbbType.SelectedValueChanged += new System.EventHandler(this.cbbType_SelectedValueChanged);
            // 
            // splitter4
            // 
            this.splitter4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitter4.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter4.Location = new System.Drawing.Point(10, 66);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(277, 20);
            this.splitter4.TabIndex = 19;
            this.splitter4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(10, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "Montant";
            // 
            // txtMontant
            // 
            this.txtMontant.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMontant.Location = new System.Drawing.Point(10, 115);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(277, 37);
            this.txtMontant.TabIndex = 21;
            // 
            // splitter6
            // 
            this.splitter6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitter6.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter6.Location = new System.Drawing.Point(10, 152);
            this.splitter6.Name = "splitter6";
            this.splitter6.Size = new System.Drawing.Size(277, 20);
            this.splitter6.TabIndex = 25;
            this.splitter6.TabStop = false;
            // 
            // lblCompteSource
            // 
            this.lblCompteSource.AutoSize = true;
            this.lblCompteSource.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCompteSource.Location = new System.Drawing.Point(10, 172);
            this.lblCompteSource.Name = "lblCompteSource";
            this.lblCompteSource.Size = new System.Drawing.Size(210, 29);
            this.lblCompteSource.TabIndex = 26;
            this.lblCompteSource.Text = "Compte Source";
            // 
            // cbbSource
            // 
            this.cbbSource.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbbSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSource.FormattingEnabled = true;
            this.cbbSource.Location = new System.Drawing.Point(10, 201);
            this.cbbSource.Name = "cbbSource";
            this.cbbSource.Size = new System.Drawing.Size(277, 37);
            this.cbbSource.TabIndex = 27;
            this.cbbSource.SelectedValueChanged += new System.EventHandler(this.cbbSource_SelectedValueChanged);
            // 
            // cbbDestinataire
            // 
            this.cbbDestinataire.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbbDestinataire.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDestinataire.FormattingEnabled = true;
            this.cbbDestinataire.Location = new System.Drawing.Point(10, 287);
            this.cbbDestinataire.Name = "cbbDestinataire";
            this.cbbDestinataire.Size = new System.Drawing.Size(277, 37);
            this.cbbDestinataire.TabIndex = 30;
            this.cbbDestinataire.SelectedValueChanged += new System.EventHandler(this.cbbDestinataire_SelectedValueChanged);
            // 
            // lblDestinataire
            // 
            this.lblDestinataire.AutoSize = true;
            this.lblDestinataire.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDestinataire.Location = new System.Drawing.Point(10, 258);
            this.lblDestinataire.Name = "lblDestinataire";
            this.lblDestinataire.Size = new System.Drawing.Size(276, 29);
            this.lblDestinataire.TabIndex = 29;
            this.lblDestinataire.Text = "Compte Destinataire";
            // 
            // splitter1
            // 
            this.splitter1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(10, 238);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(277, 20);
            this.splitter1.TabIndex = 28;
            this.splitter1.TabStop = false;
            // 
            // frmTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(882, 738);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmTransactions";
            this.Text = "Gestion des Transactions";
            this.Load += new System.EventHandler(this.frmTransactions_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTransaction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Splitter splitter9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn PU;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbProduits;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCompteSource;
        private System.Windows.Forms.Splitter splitter6;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.ComboBox cbbType;
        private System.Windows.Forms.ComboBox cbbDestinataire;
        private System.Windows.Forms.Label lblDestinataire;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ComboBox cbbSource;
    }
}