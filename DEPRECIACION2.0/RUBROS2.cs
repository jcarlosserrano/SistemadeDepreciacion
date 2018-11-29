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
    public partial class RUBROS2 : Form
    {

        private SqlConnection sqlCon;
        private SqlCommand sqlCmd;
        private String strCmd;
        private DataTable dt;
        private SqlDataAdapter sqlDa;
        private Boolean editando;
      
        public RUBROS2()
        {
            InitializeComponent();


            String instancia = "CORCHO";
            String bd = "sis325";

            try
            {
                sqlCon = new SqlConnection("Server=" + instancia + ";Database=" + bd + ";Trusted_Connection=True");
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
            strCmd = "select * from rubro";
            sqlCmd = new SqlCommand(strCmd, sqlCon);
            sqlDa = new SqlDataAdapter(sqlCmd);
            sqlDa.Fill(dt);
            //dgvRubro.DataSource = dt;

        }


        private Boolean camposCompletos()
        {
            if (txtDescripcion.Text.Equals("") || txtAnios.Text.Equals("") || txtCoeficiente.Text.Equals(""))
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
                strCmd = "insert  into rubro (descripcion,vida_util,Porc_DEPRECIACION) VALUES ('" + txtDescripcion.Text + "'," + txtAnios.Text + "," + txtCoeficiente.Text + ")";
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
                MessageBox.Show(txtDescripcion.Text + txtAnios.Text + txtCoeficiente.Text);
                MessageBox.Show("no se inserto", "advertencia");
                return false;
                // throw;
            }

        }


        private Boolean editar()
        {
            try
            {
                if (editando)
                {
                    strCmd = "update rubro set descripcion='" + txtDescripcion.Text + "',vida_util=" + txtAnios.Text + ",Porc_DEPRECIACION=" + txtCoeficiente.Text + " where id_rubro=" + dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["id_rubro"].Value.ToString() + "";

                    sqlCmd = new SqlCommand(strCmd, sqlCon);
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("REGISTRO EDITADO EXITOSAMENTE", "Aviso");
                    editando = false;
                }
                return true;

            }
            catch (SqlException)
            {
                MessageBox.Show(txtDescripcion.Text + txtAnios.Text + txtCoeficiente.Text);
                MessageBox.Show("no se inserto", "advertencia");
                return false;
                // throw;
            }
        }

        private Boolean borrar()
        {
            try
            {
                strCmd = "delete from rubro WHERE descripcion='" + dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["descripcion"].Value.ToString() + "'" + "AND id_rubro='" + dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["id_rubro"].Value.ToString() + "'";
                sqlCmd = new SqlCommand(strCmd, sqlCon);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["descripcion"].Value.ToString() + "BORRADO CORRECTAMENTE", "AVISO");
                return true;
            }
            catch (SqlException)
            {
                MessageBox.Show("No se a podido eliminar el registro", "Advertencia");
                return false;
                // throw;
            }
        }


        private void buscar()
        {
            dt = new DataTable();
            strCmd = "SELECT * FROM rubro WHERE descripcion='" + txtDescripcion.Text + "'";
            sqlCmd = new SqlCommand(strCmd, sqlCon);
            sqlDa = new SqlDataAdapter(sqlCmd);
            sqlDa.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        private void RUBROS2_Load(object sender, EventArgs e)
        {
            actualizarTabla();
            dataGridView1.DataSource = dt;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                editando = true;
                txtDescripcion.Text = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["descripcion"].Value.ToString();
                txtAnios.Text = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["vida_util"].Value.ToString();
                txtCoeficiente.Text = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["Porc_DEPRECIACION"].Value.ToString();

            }
        }

        

       

        private void button2_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void txtAnios_Validating(object sender, CancelEventArgs e)
        {
            int valor;
            string texto=txtAnios.Text;
            bool ok = int.TryParse(texto, out valor);
            if (!ok)
            {
                MessageBox.Show("Error valor incorrecto");
                txtAnios.Text = "";
            }
                

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtDescripcion.Text = "";
            txtAnios.Text = "";
            txtCoeficiente.Text = "";
            txtDescripcion.Focus();
        }

        private void pxbAgregar_Click(object sender, EventArgs e)
        {
            txtDescripcion.Text = "";
            txtAnios.Text = "";
            txtCoeficiente.Text = "";
            txtDescripcion.Focus();
        }

        private void pxbGuardar_Click(object sender, EventArgs e)
        {
            if (camposCompletos())
            {
                guardar();
                actualizarTabla();
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("VERIFIQUE TODOS LOS CAMPOS DEBEN ESTAR CORRECTOS");
            }
        }

        private void pxbEliminar_Click(object sender, EventArgs e)
        {
            borrar();
            actualizarTabla();
            dataGridView1.DataSource = dt;
        }

        private void pxbEditar_Click(object sender, EventArgs e)
        {
            editar();
            actualizarTabla();
            dataGridView1.DataSource = dt;
        }

        private void pxbCancelar_Click(object sender, EventArgs e)
        {
            Form1 abrir = new Form1();
            abrir.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
