using PruebaTecnica.Data;
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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void refresh()
        {
            Conexion oconexion = new Conexion();
            dataGridView1.DataSource = oconexion.Get();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private int? getId()
        {
            try
            {
                return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()); 
            }
            catch (Exception)
            {

                return null;
            }
        }
        private void Nuevo_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.ShowDialog();
            refresh();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            int? Id = getId();
            if (Id != null)
            {
                Registro edit = new Registro(Id);
                edit.ShowDialog();
                refresh();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int? Id = getId();
            try
            {
                if (Id != null)
                {
                    Conexion conexion = new Conexion();
                    conexion.Delete((int)Id);
                    refresh();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hay un error al eliminar" + ex.Message);
            }
        }

        private void Refrescar_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
