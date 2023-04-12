namespace exo1.vue
{
    partial class ConfirmForm
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
            this.labelPlaceDispo = new System.Windows.Forms.Label();
            this.labelMontant = new System.Windows.Forms.Label();
            this.labelArr = new System.Windows.Forms.Label();
            this.labelDep = new System.Windows.Forms.Label();
            this.labelDes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPassagers = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPlaceDispo
            // 
            this.labelPlaceDispo.AutoSize = true;
            this.labelPlaceDispo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlaceDispo.ForeColor = System.Drawing.Color.Red;
            this.labelPlaceDispo.Location = new System.Drawing.Point(226, 183);
            this.labelPlaceDispo.Name = "labelPlaceDispo";
            this.labelPlaceDispo.Size = new System.Drawing.Size(92, 17);
            this.labelPlaceDispo.TabIndex = 15;
            this.labelPlaceDispo.Text = "NbDisponible";
            this.labelPlaceDispo.Click += new System.EventHandler(this.labelPlaceDispo_Click);
            // 
            // labelMontant
            // 
            this.labelMontant.AutoSize = true;
            this.labelMontant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMontant.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelMontant.Location = new System.Drawing.Point(486, 81);
            this.labelMontant.Name = "labelMontant";
            this.labelMontant.Size = new System.Drawing.Size(16, 17);
            this.labelMontant.TabIndex = 14;
            this.labelMontant.Text = "€";
            // 
            // labelArr
            // 
            this.labelArr.AutoSize = true;
            this.labelArr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArr.ForeColor = System.Drawing.Color.SkyBlue;
            this.labelArr.Location = new System.Drawing.Point(212, 81);
            this.labelArr.Name = "labelArr";
            this.labelArr.Size = new System.Drawing.Size(57, 17);
            this.labelArr.TabIndex = 13;
            this.labelArr.Text = "DateArr";
            this.labelArr.Click += new System.EventHandler(this.labelArr_Click);
            // 
            // labelDep
            // 
            this.labelDep.AutoSize = true;
            this.labelDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDep.ForeColor = System.Drawing.Color.SkyBlue;
            this.labelDep.Location = new System.Drawing.Point(212, 30);
            this.labelDep.Name = "labelDep";
            this.labelDep.Size = new System.Drawing.Size(64, 17);
            this.labelDep.TabIndex = 12;
            this.labelDep.Text = "DateDep";
            this.labelDep.Click += new System.EventHandler(this.labelDep_Click);
            // 
            // labelDes
            // 
            this.labelDes.AutoSize = true;
            this.labelDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDes.ForeColor = System.Drawing.Color.SkyBlue;
            this.labelDes.Location = new System.Drawing.Point(212, 133);
            this.labelDes.Name = "labelDes";
            this.labelDes.Size = new System.Drawing.Size(35, 17);
            this.labelDes.TabIndex = 11;
            this.labelDes.Text = "Lieu";
            this.labelDes.Click += new System.EventHandler(this.labelDes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 170);
            this.label1.TabIndex = 9;
            this.label1.Text = "Date départ: \r\n\r\n\r\nDate arrivée:\r\n\r\n\r\nDestination: \r\n\r\n\r\nPlaces disponibles:\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(342, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Places que vous Reservez :";
            // 
            // labelPassagers
            // 
            this.labelPassagers.AutoSize = true;
            this.labelPassagers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassagers.ForeColor = System.Drawing.Color.Orange;
            this.labelPassagers.Location = new System.Drawing.Point(522, 31);
            this.labelPassagers.Name = "labelPassagers";
            this.labelPassagers.Size = new System.Drawing.Size(67, 18);
            this.labelPassagers.TabIndex = 17;
            this.labelPassagers.Text = "NbSaisie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(342, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Montant Totale TTC:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 48);
            this.button1.TabIndex = 19;
            this.button1.Text = "Confirmer le voyage";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(486, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 48);
            this.button2.TabIndex = 20;
            this.button2.Text = "Revenir en arrière";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ConfirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(625, 236);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelPassagers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelPlaceDispo);
            this.Controls.Add(this.labelMontant);
            this.Controls.Add(this.labelArr);
            this.Controls.Add(this.labelDep);
            this.Controls.Add(this.labelDes);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "ConfirmForm";
            this.Text = "ConfirmForm";
            this.Load += new System.EventHandler(this.ConfirmForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPlaceDispo;
        private System.Windows.Forms.Label labelMontant;
        private System.Windows.Forms.Label labelArr;
        private System.Windows.Forms.Label labelDep;
        private System.Windows.Forms.Label labelDes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPassagers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}