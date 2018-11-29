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
    public partial class ACTIVOS : Form
    {
        private SqlConnection sqlCon;
        private SqlCommand sqlCmd;
        private String strCmd;
        private DataTable dt;
        private DataTable dt1;
        private SqlDataAdapter sqlDa;
        private Boolean editando;

        public ACTIVOS()
        {
            InitializeComponent();

            String instancia = "CORCHO";
            String bd = "sis325";

            try
            {
                sqlCon = new SqlConnection("Server=" + instancia + ";Database=" + bd + ";Trusted_Connection=True; MultipleActiveResultSets=true");
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

        private void actualizarTabla1()
        {
            dt1 = new DataTable();
            strCmd = "select * from rubro";
            sqlCmd = new SqlCommand(strCmd, sqlCon);
            sqlDa = new SqlDataAdapter(sqlCmd);
            sqlDa.Fill(dt1);
            //dgvRubro.DataSource = dt;

        }

        string codigo;

        private void ACTIVOS_Load(object sender, EventArgs e)
        {
            actualizarTabla();
            dataGridView1.DataSource = dt;
            actualizarTabla1();
            txtCodRubro.DisplayMember = "DESCRIPCION";
            txtCodRubro.ValueMember = "DESCRIPCION";
            txtCodRubro.DataSource = dt1;
            //txtCoeficiente.Text = txtAnios.ValueMember;

        }

        private void actualizarTabla()
        {
            dt = new DataTable();
            strCmd = "select * from activoFijo";
            sqlCmd = new SqlCommand(strCmd, sqlCon);
            sqlDa = new SqlDataAdapter(sqlCmd);
            sqlDa.Fill(dt);
            //dgvRubro.DataSource = dt;

        }


        private Boolean camposCompletos()
        {
            if (txtCodRubro.Text.Equals("") || txtCodActivo.Text.Equals("") || txtDescripActivo.Text.Equals(""))
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
                strCmd = "INSERT INTO activoFijo (ID_RUBRO,CODIGO_ACTIVO,DESCRIPCION,MARCA,PROCEDENCIA,COLOR,FECHA_COMPRA,VALOR_COMPRA,ESTADO) VALUES (" + txtRubro.Text + "," + txtCodActivo.Text + ",'" + txtDescripActivo.Text + "','" + txtMarca.Text + "','" + txtProcedencia.Text + "','" + txtColor.Text + "','" + dtpFecha.Value.TimeOfDay.ToString() + "'," + txtValorCompra.Text + ",'" + cmbEstado.Text + "')";
                sqlCmd = new SqlCommand(strCmd, sqlCon);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("REGISTRO INSTERADA EXITOSAMENTE", "Aviso");
                return true;
                //}
                //else
                //    MessageBox.Show("error");
                //        return (SqlException)
               
                //sqlCon.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show(txtRubro.Text + txtCodActivo.Text + txtDescripActivo.Text);
                MessageBox.Show("no se inserto", "advertencia");
                return false;
                // throw;
            }
        }





        private void button2_Click(object sender, EventArgs e)
        {
            if (camposCompletos())
            {
                guardar();
                actualizarTabla1();
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("VERIFIQUE TODOS LOS CAMPOS DEBEN ESTAR CORRECTOS");
            }
        }

       
        string respuesta;
        public string SeleccionarRubro()
        {
            var query = "SELECT id_rubro FROM rubro WHERE descripcion='" + txtCodRubro.Text + "'";
            using (SqlCommand cmd = new SqlCommand(query, sqlCon))
            {
                SqlDataReader read = cmd.ExecuteReader();
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        respuesta = read["id_rubro"].ToString();
                    }
                    return respuesta;
                }
                else
                {
                    throw new Exception("no se encontro dicho rubro");
                }
            }
        }

        public string SeleccionaCodActivo()
        {
            var query = "select count(ID_ACTIVO) from activoFijo WHERE ID_RUBRO='" + txtRubro.Text + "'";
            using (SqlCommand cmd = new SqlCommand(query, sqlCon))
            {
                SqlDataReader read = cmd.ExecuteReader();
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        MessageBox.Show(read[""].ToString());
                        respuesta = read[""].ToString();
                    }
                    return respuesta;
                }
                else
                {
                    throw new Exception("no se encontro dicho rubro");
                }
            }
        }

        private void txtCodRubro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string codigoRubro;
            string codigoActivo;
            int codActivo;

            txtRubro.Text = SeleccionarRubro();
            codigoActivo = SeleccionaCodActivo();

            codigoRubro = txtRubro.Text;
           // codigoActivo = txtProcedencia.Text;

            codActivo = Convert.ToInt32(codigoRubro) + Convert.ToInt32(codigoActivo) + 1;
            txtCodActivo.Text = codActivo.ToString();


            //txtColor.Text = dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value.ToString();



        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void pxbAgregar_Click(object sender, EventArgs e)
        {
            txtCodActivo.Text = "";
            txtDescripActivo.Text="";
            txtMarca.Text = "";
            txtColor.Text = "";
            txtProcedencia.Text="";
            txtValorCompra.Text = "";
            txtDescripActivo.Focus();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                editando = true;
                //txtCodRubro.Text = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["ID_RUBRO"].Value.ToString();
                txtRubro.Text = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["ID_RUBRO"].Value.ToString();
                txtCodActivo.Text = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["CODIGO_ACTIVO"].Value.ToString();
                txtDescripActivo.Text = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["DESCRIPCION"].Value.ToString();
                txtMarca.Text = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["MARCA"].Value.ToString();
                txtProcedencia.Text = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["PROCEDENCIA"].Value.ToString();
                txtColor.Text = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["COLOR"].Value.ToString();
                dtpFecha.Text = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["FECHA_COMPRA"].Value.ToString();
                txtValorCompra.Text = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["VALOR_COMPRA"].Value.ToString();
                cmbEstado.Text = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["ESTADO"].Value.ToString();

            }
        }

        private Boolean borrar()
        {
            try
            {
                strCmd = "delete from activoFijo WHERE ID_ACTIVO='" + dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["ID_ACTIVO"].Value.ToString() + "'" + "AND ID_RUBRO='" + dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["ID_RUBRO"].Value.ToString() + "'";
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


        private void pxbEliminar_Click(object sender, EventArgs e)
        {
            borrar();
            actualizarTabla();
            dataGridView1.DataSource = dt;
        }

        private Boolean editar()
        {
            try
            {
                if (editando)
                {
                    strCmd = "update activoFijo set ID_RUBRO=" + txtRubro.Text + ",CODIGO_ACTIVO=" + txtCodActivo.Text + ",DESCRIPCION='" + txtDescripActivo.Text + "',MARCA='" + txtMarca.Text + "',PROCEDENCIA='" + txtProcedencia.Text + "',COLOR='" + txtColor.Text + "',FECHA_COMPRA='" + dtpFecha.Value.TimeOfDay.ToString() + "',VALOR_COMPRA=" + txtValorCompra.Text + ",ESTADO='" + cmbEstado.Text + "' where ID_ACTIVO=" + dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["ID_ACTIVO"].Value.ToString() + "";

                    sqlCmd = new SqlCommand(strCmd, sqlCon);
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("REGISTRO EDITADO EXITOSAMENTE", "Aviso");
                    editando = false;
                }
                return true;

            }
            catch (SqlException)
            {
                MessageBox.Show(txtDescripActivo.Text + txtMarca.Text + txtProcedencia.Text);
                MessageBox.Show("no se inserto", "advertencia");
                return false;
                // throw;
            }
        }

        private void pxbEditar_Click(object sender, EventArgs e)
        {
            editar();
            actualizarTabla();
            dataGridView1.DataSource = dt;
        }

        
    }
}