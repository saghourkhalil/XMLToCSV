using System.Drawing;

namespace XMLtooCSV
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxCheminFichierXml = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirFichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrezFichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonOuvrirFichier = new ePOSOne.btnProduct.Button_WOC();
            this.buttonEnregistrezFichier = new ePOSOne.btnProduct.Button_WOC();
            this.labelTextTitre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 290);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBoxCheminFichierXml
            // 
            this.textBoxCheminFichierXml.Location = new System.Drawing.Point(210, 126);
            this.textBoxCheminFichierXml.Name = "textBoxCheminFichierXml";
            this.textBoxCheminFichierXml.Size = new System.Drawing.Size(349, 20);
            this.textBoxCheminFichierXml.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(808, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirFichierToolStripMenuItem,
            this.enregistrezFichierToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitterToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.menuToolStripMenuItem.Text = "Fichier";
            // 
            // ouvrirFichierToolStripMenuItem
            // 
            this.ouvrirFichierToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.ouvrirFichierToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ouvrirFichierToolStripMenuItem.Name = "ouvrirFichierToolStripMenuItem";
            this.ouvrirFichierToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.ouvrirFichierToolStripMenuItem.Text = "Ouvrir fichier";
            this.ouvrirFichierToolStripMenuItem.Click += new System.EventHandler(this.ouvrirFichierToolStripMenuItem_Click);
            // 
            // enregistrezFichierToolStripMenuItem
            // 
            this.enregistrezFichierToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enregistrezFichierToolStripMenuItem.Name = "enregistrezFichierToolStripMenuItem";
            this.enregistrezFichierToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.enregistrezFichierToolStripMenuItem.Text = "Enregistrez fichier";
            this.enregistrezFichierToolStripMenuItem.Click += new System.EventHandler(this.enregistrezFichierToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // buttonOuvrirFichier
            // 
            this.buttonOuvrirFichier.BorderColor = System.Drawing.Color.DarkOrange;
            this.buttonOuvrirFichier.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.buttonOuvrirFichier.FlatAppearance.BorderSize = 0;
            this.buttonOuvrirFichier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOuvrirFichier.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOuvrirFichier.Location = new System.Drawing.Point(53, 105);
            this.buttonOuvrirFichier.Name = "buttonOuvrirFichier";
            this.buttonOuvrirFichier.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.buttonOuvrirFichier.OnHoverButtonColor = System.Drawing.Color.DarkOrange;
            this.buttonOuvrirFichier.OnHoverTextColor = System.Drawing.Color.Black;
            this.buttonOuvrirFichier.Size = new System.Drawing.Size(136, 60);
            this.buttonOuvrirFichier.TabIndex = 5;
            this.buttonOuvrirFichier.Text = "Ouvrir Fichier";
            this.buttonOuvrirFichier.TextColor = System.Drawing.Color.White;
            this.buttonOuvrirFichier.UseVisualStyleBackColor = true;
            this.buttonOuvrirFichier.Click += new System.EventHandler(this.buttonOuvrirFichier_Click);
            // 
            // buttonEnregistrezFichier
            // 
            this.buttonEnregistrezFichier.BorderColor = System.Drawing.Color.DarkOrange;
            this.buttonEnregistrezFichier.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.buttonEnregistrezFichier.FlatAppearance.BorderSize = 0;
            this.buttonEnregistrezFichier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnregistrezFichier.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnregistrezFichier.Location = new System.Drawing.Point(579, 105);
            this.buttonEnregistrezFichier.Name = "buttonEnregistrezFichier";
            this.buttonEnregistrezFichier.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.buttonEnregistrezFichier.OnHoverButtonColor = System.Drawing.Color.DarkOrange;
            this.buttonEnregistrezFichier.OnHoverTextColor = System.Drawing.Color.Black;
            this.buttonEnregistrezFichier.Size = new System.Drawing.Size(136, 60);
            this.buttonEnregistrezFichier.TabIndex = 6;
            this.buttonEnregistrezFichier.Text = "Enregistrez Fichier";
            this.buttonEnregistrezFichier.TextColor = System.Drawing.Color.White;
            this.buttonEnregistrezFichier.UseVisualStyleBackColor = true;
            this.buttonEnregistrezFichier.Click += new System.EventHandler(this.buttonEnregistrezFichier_Click);
            // 
            // labelTextTitre
            // 
            this.labelTextTitre.AutoSize = true;
            this.labelTextTitre.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.labelTextTitre.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelTextTitre.Location = new System.Drawing.Point(208, 43);
            this.labelTextTitre.Name = "labelTextTitre";
            this.labelTextTitre.Size = new System.Drawing.Size(351, 31);
            this.labelTextTitre.TabIndex = 7;
            this.labelTextTitre.Text = "Convertisseur de Fichier";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(808, 480);
            this.Controls.Add(this.labelTextTitre);
            this.Controls.Add(this.buttonEnregistrezFichier);
            this.Controls.Add(this.buttonOuvrirFichier);
            this.Controls.Add(this.textBoxCheminFichierXml);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convertisseur Fichier kml en csv";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxCheminFichierXml;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirFichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrezFichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private ePOSOne.btnProduct.Button_WOC buttonOuvrirFichier;
        private ePOSOne.btnProduct.Button_WOC buttonEnregistrezFichier;
        private System.Windows.Forms.Label labelTextTitre;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

