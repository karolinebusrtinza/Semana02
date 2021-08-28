using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab02_01
{
    public partial class ManUsuario : Form
    {
        public ManUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string fechaNacimiento = txtdate.Text;
            string telefono = txtTelefono.Text;
            string Direccion = txtDireccion.Text;
            string Email = txtEmail.Text;


            dataGridView1.Rows.Add("", dni, nombre,telefono,Direccion, fechaNacimiento, apellido, Email);

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
