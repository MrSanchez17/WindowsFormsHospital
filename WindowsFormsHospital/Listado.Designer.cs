namespace WindowsFormsHospital
{
    partial class Listado
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
            this.label1 = new System.Windows.Forms.Label();
            this.listListadoInfo = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "LISTADO";
            // 
            // listListadoInfo
            // 
            this.listListadoInfo.HideSelection = false;
            this.listListadoInfo.Location = new System.Drawing.Point(88, 105);
            this.listListadoInfo.Name = "listListadoInfo";
            this.listListadoInfo.Size = new System.Drawing.Size(490, 297);
            this.listListadoInfo.TabIndex = 3;
            this.listListadoInfo.UseCompatibleStateImageBehavior = false;
            this.listListadoInfo.View = System.Windows.Forms.View.List;
            // 
            // Listado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 450);
            this.Controls.Add(this.listListadoInfo);
            this.Controls.Add(this.label1);
            this.Name = "Listado";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listListadoInfo;
    }
}