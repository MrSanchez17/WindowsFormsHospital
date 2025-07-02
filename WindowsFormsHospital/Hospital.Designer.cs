namespace WindowsFormsApp
{
    partial class Hospital
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
            this.labHospital = new System.Windows.Forms.Label();
            this.butAltaMedico = new System.Windows.Forms.Button();
            this.butAltaPersonal = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labListarPacientes = new System.Windows.Forms.Button();
            this.butListarPersonal = new System.Windows.Forms.Button();
            this.butListarMedicos = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.butCrearCita = new System.Windows.Forms.Button();
            this.labAltas = new System.Windows.Forms.Label();
            this.labListados = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labHospital
            // 
            this.labHospital.AutoSize = true;
            this.labHospital.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labHospital.Location = new System.Drawing.Point(22, 33);
            this.labHospital.Name = "labHospital";
            this.labHospital.Size = new System.Drawing.Size(204, 22);
            this.labHospital.TabIndex = 0;
            this.labHospital.Text = "HOSPITAL ALCOBENDAS";
            // 
            // butAltaMedico
            // 
            this.butAltaMedico.Location = new System.Drawing.Point(76, 153);
            this.butAltaMedico.Name = "butAltaMedico";
            this.butAltaMedico.Size = new System.Drawing.Size(154, 37);
            this.butAltaMedico.TabIndex = 1;
            this.butAltaMedico.Text = "Dar alta medico";
            this.butAltaMedico.UseVisualStyleBackColor = true;
            // 
            // butAltaPersonal
            // 
            this.butAltaPersonal.Location = new System.Drawing.Point(76, 210);
            this.butAltaPersonal.Name = "butAltaPersonal";
            this.butAltaPersonal.Size = new System.Drawing.Size(154, 37);
            this.butAltaPersonal.TabIndex = 2;
            this.butAltaPersonal.Text = "Dar alta personal";
            this.butAltaPersonal.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Dar alta paciente";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labListarPacientes
            // 
            this.labListarPacientes.Location = new System.Drawing.Point(315, 273);
            this.labListarPacientes.Name = "labListarPacientes";
            this.labListarPacientes.Size = new System.Drawing.Size(154, 37);
            this.labListarPacientes.TabIndex = 6;
            this.labListarPacientes.Text = "Lista de pacientes";
            this.labListarPacientes.UseVisualStyleBackColor = true;
            // 
            // butListarPersonal
            // 
            this.butListarPersonal.Location = new System.Drawing.Point(315, 210);
            this.butListarPersonal.Name = "butListarPersonal";
            this.butListarPersonal.Size = new System.Drawing.Size(154, 37);
            this.butListarPersonal.TabIndex = 5;
            this.butListarPersonal.Text = "Lista de personal";
            this.butListarPersonal.UseVisualStyleBackColor = true;
            // 
            // butListarMedicos
            // 
            this.butListarMedicos.Location = new System.Drawing.Point(315, 153);
            this.butListarMedicos.Name = "butListarMedicos";
            this.butListarMedicos.Size = new System.Drawing.Size(154, 37);
            this.butListarMedicos.TabIndex = 4;
            this.butListarMedicos.Text = "Lista de medicos";
            this.butListarMedicos.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(546, 210);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(154, 37);
            this.button6.TabIndex = 8;
            this.button6.Text = "Eliminar paciente";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // butCrearCita
            // 
            this.butCrearCita.Location = new System.Drawing.Point(546, 153);
            this.butCrearCita.Name = "butCrearCita";
            this.butCrearCita.Size = new System.Drawing.Size(154, 37);
            this.butCrearCita.TabIndex = 7;
            this.butCrearCita.Text = "Crear cita";
            this.butCrearCita.UseVisualStyleBackColor = true;
            // 
            // labAltas
            // 
            this.labAltas.AutoSize = true;
            this.labAltas.Location = new System.Drawing.Point(76, 106);
            this.labAltas.Name = "labAltas";
            this.labAltas.Size = new System.Drawing.Size(45, 20);
            this.labAltas.TabIndex = 10;
            this.labAltas.Text = "Altas";
            // 
            // labListados
            // 
            this.labListados.AutoSize = true;
            this.labListados.Location = new System.Drawing.Point(311, 106);
            this.labListados.Name = "labListados";
            this.labListados.Size = new System.Drawing.Size(69, 20);
            this.labListados.TabIndex = 11;
            this.labListados.Text = "Listados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(542, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Gestion";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(315, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 52);
            this.button2.TabIndex = 13;
            this.button2.Text = "Lista todo el personal";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Hospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labListados);
            this.Controls.Add(this.labAltas);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.butCrearCita);
            this.Controls.Add(this.labListarPacientes);
            this.Controls.Add(this.butListarPersonal);
            this.Controls.Add(this.butListarMedicos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butAltaPersonal);
            this.Controls.Add(this.butAltaMedico);
            this.Controls.Add(this.labHospital);
            this.Name = "Hospital";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Hospital";
            this.Load += new System.EventHandler(this.Hospital_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labHospital;
        private System.Windows.Forms.Button butAltaMedico;
        private System.Windows.Forms.Button butAltaPersonal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button labListarPacientes;
        private System.Windows.Forms.Button butListarPersonal;
        private System.Windows.Forms.Button butListarMedicos;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button butCrearCita;
        private System.Windows.Forms.Label labAltas;
        private System.Windows.Forms.Label labListados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}