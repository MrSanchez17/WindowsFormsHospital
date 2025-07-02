using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Hospital : Form
    {
        public Hospital()
        {
            InitializeComponent();
        }

        private void Hospital_Load(object sender, EventArgs e)
        {
            MedicoAltas medicoAltasForm = new MedicoAltas();
            medicoAltasForm.ShowDialog();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Hospital
            // 
            this.ClientSize = new System.Drawing.Size(561, 569);
            this.Name = "Hospital";
            this.ResumeLayout(false);

        }
    }
}
