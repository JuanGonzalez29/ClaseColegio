using Forms_App1.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_App1
{
    public partial class Form1 : Form
    {
        SQLColegioVerano basededatos = new SQLColegioVerano();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Curso1.DataSource = basededatos.Cursoes.ToList();
            Curso1.DisplayMember = "Nombre";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Curso curo = (Curso)Curso1.SelectedItem;
            Profesor1.Text = curo.Profesore.Nombre;
            List<Alumno> alumno = curo.Alumnos.ToList();
            Alumnos1.DataSource = alumno;
            Alumnos1.Columns[4].Visible = false;
            Alumnos1.Columns[3].Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Alumnos1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
