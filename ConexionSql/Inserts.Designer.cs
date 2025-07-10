namespace ConexionSql
{
    partial class Inserts
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
            this.textBoxNombreTrabajo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpSalarioMin = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.SalarioMaximo = new System.Windows.Forms.Label();
            this.numericUpSalarioMax = new System.Windows.Forms.NumericUpDown();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpSalarioMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpSalarioMax)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNombreTrabajo
            // 
            this.textBoxNombreTrabajo.Location = new System.Drawing.Point(73, 93);
            this.textBoxNombreTrabajo.Name = "textBoxNombreTrabajo";
            this.textBoxNombreTrabajo.Size = new System.Drawing.Size(311, 26);
            this.textBoxNombreTrabajo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Puesto de trabajo";
            // 
            // numericUpSalarioMin
            // 
            this.numericUpSalarioMin.Location = new System.Drawing.Point(73, 193);
            this.numericUpSalarioMin.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpSalarioMin.Name = "numericUpSalarioMin";
            this.numericUpSalarioMin.Size = new System.Drawing.Size(120, 26);
            this.numericUpSalarioMin.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Salario minimo";
            // 
            // SalarioMaximo
            // 
            this.SalarioMaximo.AutoSize = true;
            this.SalarioMaximo.Location = new System.Drawing.Point(343, 167);
            this.SalarioMaximo.Name = "SalarioMaximo";
            this.SalarioMaximo.Size = new System.Drawing.Size(112, 20);
            this.SalarioMaximo.TabIndex = 5;
            this.SalarioMaximo.Text = "Salario minimo";
            // 
            // numericUpSalarioMax
            // 
            this.numericUpSalarioMax.Location = new System.Drawing.Point(343, 193);
            this.numericUpSalarioMax.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numericUpSalarioMax.Name = "numericUpSalarioMax";
            this.numericUpSalarioMax.Size = new System.Drawing.Size(120, 26);
            this.numericUpSalarioMax.TabIndex = 4;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(627, 361);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(130, 52);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Inserts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.SalarioMaximo);
            this.Controls.Add(this.numericUpSalarioMax);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpSalarioMin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNombreTrabajo);
            this.Name = "Inserts";
            this.Text = "Inserts";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpSalarioMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpSalarioMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNombreTrabajo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpSalarioMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SalarioMaximo;
        private System.Windows.Forms.NumericUpDown numericUpSalarioMax;
        private System.Windows.Forms.Button buttonSave;
    }
}