using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConexionSql
{
    public partial class ConnectionSQL : Form
    {
        public ConnectionSQL()
        {
            InitializeComponent();
            this.Load += buttonRefresh_Click; 
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {

                    TrabajoServicio servicio = new TrabajoServicio();
                    List<Job> jobs = servicio.GetAll();
                    dataGridViewMostrar.DataSource = jobs;
        }
    }
}
