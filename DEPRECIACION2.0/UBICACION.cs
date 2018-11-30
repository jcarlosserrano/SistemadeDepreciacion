using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DEPRECIACION2._0
{
    public partial class UBICACION : Form
    {
        private SqlConnection sqlCon;
        private SqlCommand sqlCmd;
        private String strCmd;
        private DataTable dt;
        private SqlDataAdapter sqlDa;
        private Boolean editando;

        public UBICACION()
        {
            InitializeComponent();

            String bd = "sis325";

            try
            {
                sqlCon = new SqlConnection("Server= localhost; Database=" + bd + ";Trusted_Connection=True; MultipleActiveResultSets=true");
                sqlCon.Open();
                //MessageBox.Show("base de datos");
            }
            catch (SqlException)
            {
                MessageBox.Show("No se pudo conectar con la base de datos");
                Application.Exit();
                //throw;
            }
        }

        private void actualizarTabla()
        {
            dt = new DataTable();
            strCmd = "select * from ubicacion";
            sqlCmd = new SqlCommand(strCmd, sqlCon);
            sqlDa = new SqlDataAdapter(sqlCmd);
            sqlDa.Fill(dt);
            //dgvRubro.DataSource = dt;

        }

        private void UBICACION_Load(object sender, EventArgs e)
        {
            actualizarTabla();
            ubicacionDataGridView.DataSource = dt;
            ubicacionDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ubicacionDataGridView.MultiSelect = false;
        }

        private Boolean camposCompletos()
        {
            if (areaTextBox.Text.Equals("") || descripcionUbicacionTextBox.Text.Equals("") )
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private Boolean guardar()
        {
            try
            {

                //if (txtDescripcion.Equals("")){
                strCmd = "insert  into ubicacion (area, descripcionUbicacion) VALUES ('" + areaTextBox.Text + "','" + descripcionUbicacionTextBox.Text + "')";
                sqlCmd = new SqlCommand(strCmd, sqlCon);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("REGISTRO INSTERADA EXITOSAMENTE", "Aviso");
                return true;
                //}
                //else
                //    MessageBox.Show("error");
                //        return false;

            }
            catch (SqlException)
            {
                MessageBox.Show(areaTextBox.Text + descripcionUbicacionTextBox.Text);
                MessageBox.Show("no se inserto", "advertencia");
                return false;
                // throw;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (camposCompletos())
            {
                guardar();
                actualizarTabla();
                ubicacionDataGridView.DataSource = dt;
            }
            else
            {
                MessageBox.Show("VERIFIQUE TODOS LOS CAMPOS DEBEN ESTAR CORRECTOS");
            }
        }

        private Boolean editar()
        {
            try
            {
                if (editando)
                {
                    strCmd = "update ubicacion set area='" + areaTextBox.Text + "',descripcionUbicacion='" + descripcionUbicacionTextBox.Text + "' where id_ubicacion=" + ubicacionDataGridView.Rows[ubicacionDataGridView.SelectedRows[0].Index].Cells["id_ubicacion"].Value.ToString() + "";

                    sqlCmd = new SqlCommand(strCmd, sqlCon);
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("REGISTRO EDITADO EXITOSAMENTE", "Aviso");
                    editando = false;
                }
                return true;

            }
            catch (SqlException)
            {
                MessageBox.Show(areaTextBox.Text + descripcionUbicacionTextBox.Text);
                MessageBox.Show("no se inserto", "advertencia");
                return false;
                // throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            editar();
            actualizarTabla();
            ubicacionDataGridView.DataSource = dt;
        }

        private void ubicacionDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ubicacionDataGridView.SelectedRows.Count > 0)
            {
                editando = true;
                id_ubicacionTextBox.Text = ubicacionDataGridView.Rows[ubicacionDataGridView.SelectedRows[0].Index].Cells["id_ubicacion"].Value.ToString();
                areaTextBox.Text = ubicacionDataGridView.Rows[ubicacionDataGridView.SelectedRows[0].Index].Cells["area"].Value.ToString();
                descripcionUbicacionTextBox.Text = ubicacionDataGridView.Rows[ubicacionDataGridView.SelectedRows[0].Index].Cells["descripcionUbicacion"].Value.ToString();

            }
        }


        private Boolean borrar()
        {
            try
            {
                strCmd = "delete from ubicacion WHERE area='" + ubicacionDataGridView.Rows[ubicacionDataGridView.SelectedRows[0].Index].Cells["area"].Value.ToString() + "'" + "AND id_ubicacion='" + ubicacionDataGridView.Rows[ubicacionDataGridView.SelectedRows[0].Index].Cells["id_ubicacion"].Value.ToString() + "'";
                sqlCmd = new SqlCommand(strCmd, sqlCon);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show(ubicacionDataGridView.Rows[ubicacionDataGridView.SelectedRows[0].Index].Cells["area"].Value.ToString() + "BORRADO CORRECTAMENTE", "AVISO");
                return true;
            }
            catch (SqlException)
            {
                MessageBox.Show("No se a podido eliminar el registro", "Advertencia");
                return false;
                // throw;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            borrar();
            actualizarTabla();
            ubicacionDataGridView.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            id_ubicacionTextBox.Text = "";
            areaTextBox.Text = "";
            descripcionUbicacionTextBox.Text = "";
            areaTextBox.Focus();
        }

        
    }
}
