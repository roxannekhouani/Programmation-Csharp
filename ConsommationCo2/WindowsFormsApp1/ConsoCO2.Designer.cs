namespace Consommation_CO2
{
    partial class ConsoCO2
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
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
            this.checkBox_pied = new System.Windows.Forms.CheckBox();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.button_Valid = new System.Windows.Forms.Button();
            this.label_nbKm = new System.Windows.Forms.Label();
            this.label_nbPers = new System.Windows.Forms.Label();
            this.checkBox_voiture = new System.Windows.Forms.CheckBox();
            this.checkBox_car = new System.Windows.Forms.CheckBox();
            this.numericUpDown_nbKm = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_nbPersonne = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nbKm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nbPersonne)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox_pied
            // 
            this.checkBox_pied.BackColor = System.Drawing.Color.PeachPuff;
            this.checkBox_pied.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_pied.Location = new System.Drawing.Point(65, 136);
            this.checkBox_pied.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_pied.Name = "checkBox_pied";
            this.checkBox_pied.Size = new System.Drawing.Size(78, 22);
            this.checkBox_pied.TabIndex = 4;
            this.checkBox_pied.Text = "A pied";
            this.checkBox_pied.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_pied.UseVisualStyleBackColor = false;
            this.checkBox_pied.CheckedChanged += new System.EventHandler(this.checkBox_pied_CheckedChanged);
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.Location = new System.Drawing.Point(317, 123);
            this.richTextBoxResult.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.Size = new System.Drawing.Size(263, 214);
            this.richTextBoxResult.TabIndex = 7;
            this.richTextBoxResult.Text = "";
            // 
            // button_Valid
            // 
            this.button_Valid.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Valid.Location = new System.Drawing.Point(50, 284);
            this.button_Valid.Margin = new System.Windows.Forms.Padding(2);
            this.button_Valid.Name = "button_Valid";
            this.button_Valid.Size = new System.Drawing.Size(141, 30);
            this.button_Valid.TabIndex = 8;
            this.button_Valid.Text = "Calculer";
            this.button_Valid.UseVisualStyleBackColor = true;
            this.button_Valid.Click += new System.EventHandler(this.button_Valid_Click);
            // 
            // label_nbKm
            // 
            this.label_nbKm.AutoSize = true;
            this.label_nbKm.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nbKm.Location = new System.Drawing.Point(62, 33);
            this.label_nbKm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_nbKm.Name = "label_nbKm";
            this.label_nbKm.Size = new System.Drawing.Size(106, 17);
            this.label_nbKm.TabIndex = 0;
            this.label_nbKm.Text = "Nombre de km";
            this.label_nbKm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_nbPers
            // 
            this.label_nbPers.AutoSize = true;
            this.label_nbPers.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nbPers.Location = new System.Drawing.Point(278, 33);
            this.label_nbPers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_nbPers.Name = "label_nbPers";
            this.label_nbPers.Size = new System.Drawing.Size(163, 17);
            this.label_nbPers.TabIndex = 2;
            this.label_nbPers.Text = "Nombre de personne(s)";
            this.label_nbPers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox_voiture
            // 
            this.checkBox_voiture.BackColor = System.Drawing.Color.PeachPuff;
            this.checkBox_voiture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_voiture.Location = new System.Drawing.Point(65, 180);
            this.checkBox_voiture.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_voiture.Name = "checkBox_voiture";
            this.checkBox_voiture.Size = new System.Drawing.Size(101, 22);
            this.checkBox_voiture.TabIndex = 5;
            this.checkBox_voiture.Text = "En voiture";
            this.checkBox_voiture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_voiture.UseVisualStyleBackColor = false;
            this.checkBox_voiture.CheckedChanged += new System.EventHandler(this.checkBox_voiture_CheckedChanged);
            // 
            // checkBox_car
            // 
            this.checkBox_car.BackColor = System.Drawing.Color.PeachPuff;
            this.checkBox_car.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_car.Location = new System.Drawing.Point(65, 222);
            this.checkBox_car.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_car.Name = "checkBox_car";
            this.checkBox_car.Size = new System.Drawing.Size(78, 22);
            this.checkBox_car.TabIndex = 6;
            this.checkBox_car.Text = "En bus";
            this.checkBox_car.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_car.UseVisualStyleBackColor = false;
            this.checkBox_car.CheckedChanged += new System.EventHandler(this.checkBox_car_CheckedChanged);
            // 
            // numericUpDown_nbKm
            // 
            this.numericUpDown_nbKm.DecimalPlaces = 2;
            this.numericUpDown_nbKm.Location = new System.Drawing.Point(50, 65);
            this.numericUpDown_nbKm.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_nbKm.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.numericUpDown_nbKm.Name = "numericUpDown_nbKm";
            this.numericUpDown_nbKm.Size = new System.Drawing.Size(141, 20);
            this.numericUpDown_nbKm.TabIndex = 9;
            this.numericUpDown_nbKm.ValueChanged += new System.EventHandler(this.numericUpDown_nbKm_ValueChanged);
            // 
            // numericUpDown_nbPersonne
            // 
            this.numericUpDown_nbPersonne.Location = new System.Drawing.Point(267, 65);
            this.numericUpDown_nbPersonne.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_nbPersonne.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.numericUpDown_nbPersonne.Name = "numericUpDown_nbPersonne";
            this.numericUpDown_nbPersonne.Size = new System.Drawing.Size(174, 20);
            this.numericUpDown_nbPersonne.TabIndex = 10;
            // 
            // ConsoCO2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(601, 401);
            this.Controls.Add(this.numericUpDown_nbPersonne);
            this.Controls.Add(this.numericUpDown_nbKm);
            this.Controls.Add(this.checkBox_car);
            this.Controls.Add(this.checkBox_voiture);
            this.Controls.Add(this.label_nbPers);
            this.Controls.Add(this.label_nbKm);
            this.Controls.Add(this.button_Valid);
            this.Controls.Add(this.richTextBoxResult);
            this.Controls.Add(this.checkBox_pied);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(700, 613);
            this.MinimumSize = new System.Drawing.Size(458, 413);
            this.Name = "ConsoCO2";
            this.Text = "Consommation de CO2";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nbKm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nbPersonne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox_pied;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
        private System.Windows.Forms.Button button_Valid;
        private System.Windows.Forms.Label label_nbKm;
        private System.Windows.Forms.Label label_nbPers;
        private System.Windows.Forms.CheckBox checkBox_voiture;
        private System.Windows.Forms.CheckBox checkBox_car;
        private System.Windows.Forms.NumericUpDown numericUpDown_nbKm;
        private System.Windows.Forms.NumericUpDown numericUpDown_nbPersonne;
    }
}