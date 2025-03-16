namespace Didital_Banking.Formulaires
{
    partial class frmAdministrateur
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.splitter5 = new System.Windows.Forms.Splitter();
            this.label2 = new System.Windows.Forms.Label();
            this.splitter6 = new System.Windows.Forms.Splitter();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.splitter7 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter9 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgAdministrateur = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbProduits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAdministrateur)).BeginInit();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(882, 673);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitter3);
            this.panel1.Controls.Add(this.btnAjouter);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.btnSupprimer);
            this.panel1.Controls.Add(this.splitter4);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.splitter5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.splitter6);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.splitter7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.splitter9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 607);
            this.panel1.TabIndex = 0;
            // 
            // splitter3
            // 
            this.splitter3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter3.Location = new System.Drawing.Point(10, 487);
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
            this.btnAjouter.Location = new System.Drawing.Point(10, 497);
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
            this.splitter1.Location = new System.Drawing.Point(10, 547);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(277, 10);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.AutoSize = true;
            this.btnSupprimer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSupprimer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSupprimer.FlatAppearance.BorderSize = 0;
            this.btnSupprimer.FlatAppearance.CheckedBackColor = System.Drawing.Color.Aqua;
            this.btnSupprimer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.btnSupprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Location = new System.Drawing.Point(10, 557);
            this.btnSupprimer.MaximumSize = new System.Drawing.Size(0, 80);
            this.btnSupprimer.MinimumSize = new System.Drawing.Size(0, 50);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(277, 50);
            this.btnSupprimer.TabIndex = 6;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // splitter4
            // 
            this.splitter4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitter4.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter4.Location = new System.Drawing.Point(10, 172);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(277, 20);
            this.splitter4.TabIndex = 12;
            this.splitter4.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPassword.Location = new System.Drawing.Point(10, 135);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(277, 37);
            this.txtPassword.TabIndex = 3;
            // 
            // splitter5
            // 
            this.splitter5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitter5.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter5.Location = new System.Drawing.Point(10, 125);
            this.splitter5.Name = "splitter5";
            this.splitter5.Size = new System.Drawing.Size(277, 10);
            this.splitter5.TabIndex = 13;
            this.splitter5.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(10, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // splitter6
            // 
            this.splitter6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitter6.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter6.Location = new System.Drawing.Point(10, 76);
            this.splitter6.Name = "splitter6";
            this.splitter6.Size = new System.Drawing.Size(277, 20);
            this.splitter6.TabIndex = 14;
            this.splitter6.TabStop = false;
            // 
            // txtUsername
            // 
            this.txtUsername.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtUsername.Location = new System.Drawing.Point(10, 39);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(277, 37);
            this.txtUsername.TabIndex = 1;
            // 
            // splitter7
            // 
            this.splitter7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitter7.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter7.Location = new System.Drawing.Point(10, 29);
            this.splitter7.Name = "splitter7";
            this.splitter7.Size = new System.Drawing.Size(277, 10);
            this.splitter7.TabIndex = 15;
            this.splitter7.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // splitter9
            // 
            this.splitter9.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitter9.Location = new System.Drawing.Point(0, 0);
            this.splitter9.Name = "splitter9";
            this.splitter9.Size = new System.Drawing.Size(10, 607);
            this.splitter9.TabIndex = 17;
            this.splitter9.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgAdministrateur);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(296, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 607);
            this.panel2.TabIndex = 1;
            // 
            // dgAdministrateur
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dgAdministrateur.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgAdministrateur.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgAdministrateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAdministrateur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAdministrateur.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgAdministrateur.Location = new System.Drawing.Point(0, 0);
            this.dgAdministrateur.Name = "dgAdministrateur";
            this.dgAdministrateur.RowHeadersWidth = 51;
            this.dgAdministrateur.RowTemplate.Height = 24;
            this.dgAdministrateur.Size = new System.Drawing.Size(583, 607);
            this.dgAdministrateur.TabIndex = 12;
            this.dgAdministrateur.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgAdministrateur_MouseClick);
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
            // frmAdministrateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(882, 673);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmAdministrateur";
            this.Text = "Gestion des Administrateurs";
            this.Load += new System.EventHandler(this.frmAdministrateur_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAdministrateur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.Splitter splitter5;
        private System.Windows.Forms.Splitter splitter6;
        private System.Windows.Forms.Splitter splitter7;
        private System.Windows.Forms.Splitter splitter9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgAdministrateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn PU;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbProduits;
    }
}