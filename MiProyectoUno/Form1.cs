using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace MiProyectoUno
{
    public partial class Form1 : Form
    {
        Familia familia1 = new Familia();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            dgvFamilia.DataSource = familia1.LlenarFamilia();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string idfamilia = dgvFamilia.SelectedCells[0].Value.ToString();

            familia1.EliminarFamilia(idfamilia);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
