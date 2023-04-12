namespace exo1
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
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDes = new System.Windows.Forms.Label();
            this.labelDep = new System.Windows.Forms.Label();
            this.labelArr = new System.Windows.Forms.Label();
            this.labelPrix = new System.Windows.Forms.Label();
            this.labelPlaceDispo = new System.Windows.Forms.Label();
            this.nbPersChoisi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.reserverBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.listBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(454, 96);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(194, 160);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(209, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 91);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date départ: \r\n\r\n\r\nDate retour:\r\n\r\n\r\nDestination: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(9, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 52);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prix:\r\n\r\n\r\nPlaces disponibles:";
            // 
            // labelDes
            // 
            this.labelDes.AutoSize = true;
            this.labelDes.ForeColor = System.Drawing.Color.SkyBlue;
            this.labelDes.Location = new System.Drawing.Point(291, 102);
            this.labelDes.Name = "labelDes";
            this.labelDes.Size = new System.Drawing.Size(51, 13);
            this.labelDes.TabIndex = 4;
            this.labelDes.Text = "LieuFront";
            // 
            // labelDep
            // 
            this.labelDep.AutoSize = true;
            this.labelDep.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.labelDep.Location = new System.Drawing.Point(291, 24);
            this.labelDep.Name = "labelDep";
            this.labelDep.Size = new System.Drawing.Size(74, 13);
            this.labelDep.TabIndex = 5;
            this.labelDep.Text = "DateDepFront";
            // 
            // labelArr
            // 
            this.labelArr.AutoSize = true;
            this.labelArr.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.labelArr.Location = new System.Drawing.Point(291, 65);
            this.labelArr.Name = "labelArr";
            this.labelArr.Size = new System.Drawing.Size(67, 13);
            this.labelArr.TabIndex = 6;
            this.labelArr.Text = "DateArrFront";
            // 
            // labelPrix
            // 
            this.labelPrix.AutoSize = true;
            this.labelPrix.ForeColor = System.Drawing.Color.Chocolate;
            this.labelPrix.Location = new System.Drawing.Point(112, 36);
            this.labelPrix.Name = "labelPrix";
            this.labelPrix.Size = new System.Drawing.Size(37, 13);
            this.labelPrix.TabIndex = 7;
            this.labelPrix.Text = "€Front";
            this.labelPrix.Click += new System.EventHandler(this.labelPrix_Click);
            // 
            // labelPlaceDispo
            // 
            this.labelPlaceDispo.AutoSize = true;
            this.labelPlaceDispo.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelPlaceDispo.Location = new System.Drawing.Point(112, 75);
            this.labelPlaceDispo.Name = "labelPlaceDispo";
            this.labelPlaceDispo.Size = new System.Drawing.Size(72, 13);
            this.labelPlaceDispo.TabIndex = 8;
            this.labelPlaceDispo.Text = "NbDispoFront";
            // 
            // nbPersChoisi
            // 
            this.nbPersChoisi.BackColor = System.Drawing.SystemColors.Info;
            this.nbPersChoisi.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.nbPersChoisi.Location = new System.Drawing.Point(207, 158);
            this.nbPersChoisi.Name = "nbPersChoisi";
            this.nbPersChoisi.Size = new System.Drawing.Size(66, 20);
            this.nbPersChoisi.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(62, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Réservation de place";
            // 
            // reserverBtn
            // 
            this.reserverBtn.BackColor = System.Drawing.Color.Transparent;
            this.reserverBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserverBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reserverBtn.Location = new System.Drawing.Point(286, 153);
            this.reserverBtn.Name = "reserverBtn";
            this.reserverBtn.Size = new System.Drawing.Size(79, 26);
            this.reserverBtn.TabIndex = 11;
            this.reserverBtn.Text = "Valider";
            this.reserverBtn.UseVisualStyleBackColor = false;
            this.reserverBtn.Click += new System.EventHandler(this.reserverBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.reserverBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelDes);
            this.groupBox1.Controls.Add(this.nbPersChoisi);
            this.groupBox1.Controls.Add(this.labelDep);
            this.groupBox1.Controls.Add(this.labelPlaceDispo);
            this.groupBox1.Controls.Add(this.labelArr);
            this.groupBox1.Controls.Add(this.labelPrix);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(38, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 200);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information de la réservation";
            this.groupBox1.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.MaximumSize = new System.Drawing.Size(700, 400);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDes;
        private System.Windows.Forms.Label labelDep;
        private System.Windows.Forms.Label labelArr;
        private System.Windows.Forms.Label labelPrix;
        private System.Windows.Forms.Label labelPlaceDispo;
        private System.Windows.Forms.TextBox nbPersChoisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button reserverBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

