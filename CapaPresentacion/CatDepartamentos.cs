using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class CatDepartamentos : Form
    {
        CN_Departamento depto = new CN_Departamento();

        public CatDepartamentos()
        {
            InitializeComponent();
        }

        private void CatDepartamentos_Load(object sender, EventArgs e)
        {
            Actualizar_Grd_Departamentos();
        }

        private void Btn_InsertarDepto_Click(object sender, EventArgs e)
        {
            String msj = String.Empty;
            try
            {
                depto.Id_Ofi = Int32.Parse(Txt_IdOficina.Text);
                depto.Depto_Descripcion = Txt_DescripcionDepto.Text;

                if(Cbo_DeptoActivo.Text == "Activo")
                {
                    depto.Depto_Activo = true;
                }
                else
                {
                    depto.Depto_Activo = false;
                }

                msj = depto.Insertar_Departamento();

                Limpiar_Formulario();
                Actualizar_Grd_Departamentos();
                MessageBox.Show(msj);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_ModificarDepto_Click(object sender, EventArgs e)
        {
            String msj = String.Empty;
            try
            {
                depto.Id_Depto = Int32.Parse(Txt_IdDpto.Text);
                depto.Id_Ofi = Int32.Parse(Txt_IdOficina.Text);
                depto.Depto_Descripcion = Txt_DescripcionDepto.Text;

                if (Cbo_DeptoActivo.Text == "Activo")
                {
                    depto.Depto_Activo = true;
                }
                else
                {
                    depto.Depto_Activo = false;
                }

                msj = depto.Modificar_Departamento();

                Limpiar_Formulario();
                Actualizar_Grd_Departamentos();
                MessageBox.Show(msj);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Limpiar_Formulario()
        {
            Txt_DescripcionDepto.Clear();
            Txt_IdOficina.Clear();
            Txt_IdDpto.Clear();
            Cbo_DeptoActivo.Text = String.Empty;
        }

        private void Actualizar_Grd_Departamentos()
        {
            try
            {
                DataTable dt = depto.Consulta_Departamentos();
                Grd_Departamentos.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Grd_Departamentos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Obtienes la fila actual
            var row = (sender as DataGridView).CurrentRow;

            Txt_IdDpto.Text = row.Cells[0].Value.ToString();
            Txt_DescripcionDepto.Text = row.Cells[1].Value.ToString();
            Txt_IdOficina.Text = row.Cells[2].Value.ToString();
            Cbo_DeptoActivo.Text = row.Cells[4].Value.ToString();
        }
    }
}
