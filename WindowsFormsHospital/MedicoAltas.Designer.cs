namespace WindowsFormsApp
{
    partial class MedicoAltas
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
            this.labMedicosAltas = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labApellido = new System.Windows.Forms.Label();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.labDNI = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.labTelefono = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labDireccion = new System.Windows.Forms.Label();
            this.butGuardarAlta = new System.Windows.Forms.Button();
            this.butCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labMedicosAltas
            // 
            this.labMedicosAltas.AutoSize = true;
            this.labMedicosAltas.BackColor = System.Drawing.SystemColors.Control;
            this.labMedicosAltas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labMedicosAltas.Location = new System.Drawing.Point(43, 32);
            this.labMedicosAltas.Name = "labMedicosAltas";
            this.labMedicosAltas.Size = new System.Drawing.Size(100, 22);
            this.labMedicosAltas.TabIndex = 0;
            this.labMedicosAltas.Text = "Medico altas";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(43, 85);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(65, 20);
            this.labName.TabIndex = 1;
            this.labName.Text = "Nombre";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(47, 108);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(160, 26);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(235, 108);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(160, 26);
            this.textBoxSurname.TabIndex = 4;
            // 
            // labApellido
            // 
            this.labApellido.AutoSize = true;
            this.labApellido.Location = new System.Drawing.Point(231, 85);
            this.labApellido.Name = "labApellido";
            this.labApellido.Size = new System.Drawing.Size(65, 20);
            this.labApellido.TabIndex = 3;
            this.labApellido.Text = "Apellido";
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(429, 108);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(160, 26);
            this.textBoxDNI.TabIndex = 6;
            // 
            // labDNI
            // 
            this.labDNI.AutoSize = true;
            this.labDNI.Location = new System.Drawing.Point(425, 85);
            this.labDNI.Name = "labDNI";
            this.labDNI.Size = new System.Drawing.Size(37, 20);
            this.labDNI.TabIndex = 5;
            this.labDNI.Text = "DNI";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(47, 206);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(160, 26);
            this.textBoxTelefono.TabIndex = 8;
            // 
            // labTelefono
            // 
            this.labTelefono.AutoSize = true;
            this.labTelefono.Location = new System.Drawing.Point(43, 183);
            this.labTelefono.Name = "labTelefono";
            this.labTelefono.Size = new System.Drawing.Size(71, 20);
            this.labTelefono.TabIndex = 7;
            this.labTelefono.Text = "Telefono";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(235, 206);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 26);
            this.textBox1.TabIndex = 10;
            // 
            // labDireccion
            // 
            this.labDireccion.AutoSize = true;
            this.labDireccion.Location = new System.Drawing.Point(231, 183);
            this.labDireccion.Name = "labDireccion";
            this.labDireccion.Size = new System.Drawing.Size(75, 20);
            this.labDireccion.TabIndex = 9;
            this.labDireccion.Text = "Direccion";
            // 
            // butGuardarAlta
            // 
            this.butGuardarAlta.Location = new System.Drawing.Point(532, 268);
            this.butGuardarAlta.Name = "butGuardarAlta";
            this.butGuardarAlta.Size = new System.Drawing.Size(104, 32);
            this.butGuardarAlta.TabIndex = 11;
            this.butGuardarAlta.Text = "Dar alta";
            this.butGuardarAlta.UseVisualStyleBackColor = true;
            this.butGuardarAlta.Click += new System.EventHandler(this.butGuardarAlta_Click);
            // 
            // butCancelar
            // 
            this.butCancelar.Location = new System.Drawing.Point(408, 268);
            this.butCancelar.Name = "butCancelar";
            this.butCancelar.Size = new System.Drawing.Size(104, 32);
            this.butCancelar.TabIndex = 12;
            this.butCancelar.Text = "Cancelar";
            this.butCancelar.UseVisualStyleBackColor = true;
            // 
            // MedicoAltas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 312);
            this.Controls.Add(this.butCancelar);
            this.Controls.Add(this.butGuardarAlta);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labDireccion);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.labTelefono);
            this.Controls.Add(this.textBoxDNI);
            this.Controls.Add(this.labDNI);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.labApellido);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.labMedicosAltas);
            this.Name = "MedicoAltas";
            this.Text = "MedicoAltas";
            this.Load += new System.EventHandler(this.MedicoAltas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labMedicosAltas;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labApellido;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Label labDNI;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label labTelefono;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labDireccion;
        private System.Windows.Forms.Button butGuardarAlta;
        private System.Windows.Forms.Button butCancelar;
    }
}