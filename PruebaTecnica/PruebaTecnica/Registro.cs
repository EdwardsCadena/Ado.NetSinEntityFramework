using PruebaTecnica.Data;
using PruebaTecnica.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaTecnica
{
    public partial class Registro : Form
    {
        private int? IdCliente;
        public Registro(int? IdCliente=null)
        {
            InitializeComponent();
            this.IdCliente = IdCliente;
            if (this.IdCliente != null)
                {
                    LoadCliente();
                }
        }

        private void LoadCliente()
        {
            Conexion conexion = new Conexion();
            Cliente cliente = conexion.Get((int)IdCliente);
            TexNombres.Text = cliente.Nombres;
            TexApellidos.Text = cliente.Apellidos;
            TexDireccion.Text = cliente.Direccion;
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            try
            {
                if (IdCliente == null)
                {
                    conexion.Add(TexNombres.Text, TexApellidos.Text, TexDireccion.Text);
                }
                else
                {
                    conexion.Update(TexNombres.Text, TexApellidos.Text, TexDireccion.Text, (int) IdCliente);
                }
                this.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error al guardar" + ex.Message);
            }
        }
    }
}
