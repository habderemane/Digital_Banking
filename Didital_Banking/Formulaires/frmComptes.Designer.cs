namespace Didital_Banking.Formulaires
{
    partial class frmComptes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbClient = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.splitter10 = new System.Windows.Forms.Splitter();
            this.txtSolde = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label2 = new System.Windows.Forms.Label();
            this.splitter6 = new System.Windows.Forms.Splitter();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter9 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgComptes = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbProduits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgComptes)).BeginInit();
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
            this.panel1.Controls.Add(this.cbbClient);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.splitter10);
            this.panel1.Controls.Add(this.txtSolde);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.splitter4);
            this.panel1.Controls.Add(this.cbbType);
            this.panel1.Controls.Add(this.splitter3);
            this.panel1.Controls.Add(this.btnAjouter);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.splitter6);
            this.panel1.Controls.Add(this.txtNumero);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.splitter9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 672);
            this.panel1.TabIndex = 0;
            // 
            // cbbClient
            // 
            this.cbbClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbClient.FormattingEnabled = true;
            this.cbbClient.Location = new System.Drawing.Point(10, 287);
            this.cbbClient.Name = "cbbClient";
            this.cbbClient.Size = new System.Drawing.Size(277, 37);
            this.cbbClient.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(10, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 29);
            this.label4.TabIndex = 24;
            this.label4.Text = "Client";
            // 
            // splitter10
            // 
            this.splitter10.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitter10.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter10.Location = new System.Drawing.Point(10, 238);
            this.splitter10.Name = "splitter10";
            this.splitter10.Size = new System.Drawing.Size(277, 20);
            this.splitter10.TabIndex = 26;
            this.splitter10.TabStop = false;
            // 
            // txtSolde
            // 
            this.txtSolde.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSolde.Location = new System.Drawing.Point(10, 201);
            this.txtSolde.Name = "txtSolde";
            this.txtSolde.Size = new System.Drawing.Size(277, 37);
            this.txtSolde.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(10, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "Solde";
            // 
            // splitter4
            // 
            this.splitter4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitter4.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter4.Location = new System.Drawing.Point(10, 152);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(277, 20);
            this.splitter4.TabIndex = 23;
            this.splitter4.TabStop = false;
            // 
            // cbbType
            // 
            this.cbbType.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Items.AddRange(new object[] {
            "Courant",
            "Epargne"});
            this.cbbType.Location = new System.Drawing.Point(10, 115);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(277, 37);
            this.cbbType.TabIndex = 18;
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
            // btnAjouter
            // 
            this.btnAjouter.AutoSize = true;
            this.btnAjouter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAjouter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.FlatAppearance.CheckedBackColor = System.Drawing.Color.Aqua;
            this.btnAjouter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnAjouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(10, 612);
            this.btnAjouter.MaximumSize = new System.Drawing.Size(0, 80);
            this.btnAjouter.MinimumSize = new System.Drawing.Size(0, 50);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(277, 50);
            this.btnAjouter.TabIndex = 10;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // splitter1
            // 
            this.splitter1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(10, 662);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(277, 10);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(10, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type";
            // 
            // splitter6
            // 
            this.splitter6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitter6.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter6.Location = new System.Drawing.Point(10, 66);
            this.splitter6.Name = "splitter6";
            this.splitter6.Size = new System.Drawing.Size(277, 20);
            this.splitter6.TabIndex = 14;
            this.splitter6.TabStop = false;
            // 
            // txtNumero
            // 
            this.txtNumero.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNumero.Location = new System.Drawing.Point(10, 29);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(277, 37);
            this.txtNumero.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero";
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
            this.panel2.Controls.Add(this.dgComptes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(296, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 672);
            this.panel2.TabIndex = 1;
            // 
            // dgComptes
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dgComptes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgComptes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgComptes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgComptes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgComptes.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgComptes.Location = new System.Drawing.Point(0, 0);
            this.dgComptes.Name = "dgComptes";
            this.dgComptes.RowHeadersWidth = 51;
            this.dgComptes.RowTemplate.Height = 24;
            this.dgComptes.Size = new System.Drawing.Size(583, 672);
            this.dgComptes.TabIndex = 12;
            this.dgComptes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgComptes_MouseClick);
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
            // frmComptes
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
            this.Name = "frmComptes";
            this.Text = "Gestion des Comptes";
            this.Load += new System.EventHandler(this.frmComptes_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgComptes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter6;
        private System.Windows.Forms.Splitter splitter9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgComptes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn PU;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbProduits;
        private System.Windows.Forms.ComboBox cbbClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Splitter splitter10;
        private System.Windows.Forms.TextBox txtSolde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.ComboBox cbbType;
    }
}