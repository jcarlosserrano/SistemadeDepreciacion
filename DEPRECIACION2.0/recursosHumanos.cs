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
    public partial class recursosHumanos : Form
    {
        private SqlConnection sql_con;
        private SqlCommand sql_cmd;
        private SqlDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

        private SqlConnection sqlCon;
        private SqlCommand sqlCmd;
        private String strCmd;
        private DataTable dt;
        private SqlDataAdapter sqlDa;
        private Boolean editando;

        public recursosHumanos()
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

        private void SetConnection()
        {
            sql_con = new SqlConnection("Server=CORCHO;Database=sis325;Trusted_Connection=True");
        }


        // EJECUTAR QUERY
        private void Execute(String txtQuery)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }

        // CARGAR BD
        private void LoadData()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "Select *from recursosHumanos";
            DB = new SqlDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            recursosHumanosDataGridView.DataSource = DT;
            sql_con.Close();
        }

        private void actualizarTabla()
        {
            dt = new DataTable();
            strCmd = "Select *from recursosHumanos";
            sqlCmd = new SqlCommand(strCmd, sqlCon);
            sqlDa = new SqlDataAdapter(sqlCmd);
            sqlDa.Fill(dt);
            //dgvRubro.DataSource = dt;

        }


        private void recursosHumanosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
          // this.recursosHumanosBindingSource.EndEdit();
          // this.tableAdapterManager.UpdateAll(this.sis325DataSet);

        }

        private void recursosHumanos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sis325DataSet.recursosHumanos' Puede moverla o quitarla según sea necesario.
           // this.recursosHumanosTableAdapter.Fill(this.sis325DataSet.recursosHumanos);
          
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ciPersonal = ciPersonalTextBox.Text;
            string nombres = nombresTextBox.Text;
            string apellidoPat = apellidoPatTextBox.Text;
            string apelidoMat = apellidoMatTextBox.Text;
            string sexo = sexoComboBox.Text;
            string direccion = dirTextBox.Text;
            string profesion = profesTextBox.Text;
            string email = emailTextBox.Text;
            string cargo = cargoComboBox.Text;

            string procedencia = procedenciaComboBox.Text;

            string c1 = "insert into recursosHumanos (CiPersonal,Nombres,ApellidoPat,ApellidoMat,Sexo,Dir,Profes,Email,Cargo,procedencia) values ('" + ciPersonal + "','" + nombres + "','" + apellidoPat + "','" + apelidoMat + "','" + sexo + "','" + direccion + "','" + profesion + "','" + email + "','" + cargo + "','" + procedencia + "');";
            Execute(c1);
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ciPersonal = ciPersonalTextBox.Text;
            string nombres = nombresTextBox.Text;
            string apellidoPat = apellidoPatTextBox.Text;
            string apelidoMat = apellidoMatTextBox.Text;
            string sexo = sexoComboBox.Text;
            string direccion = dirTextBox.Text;
            string profesion = profesTextBox.Text;
            string email = emailTextBox.Text;
            string cargo = cargoComboBox.Text;
            string procedencia = procedenciaComboBox.Text;

            string c1 = "update recursosHumanos set CiPersonal='" + ciPersonal + "',Nombres='" + nombres + "', ApellidoPat='" + apellidoPat + "',ApellidoMat='" + apelidoMat + "', Sexo='" + sexo + "', Dir='" + direccion + "', Profes='" + profesion + "', Email='" + email + "', Cargo='" + cargo + "', procedencia= '" + procedencia + "' where idCliente='" + idClienteTextBox.Text + "';";
            Execute(c1);
            LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea eliminar el registro?", "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string c1 = "delete from recursosHumanos where idCliente='" + idClienteTextBox.Text + "';";
                Execute(c1);
                LoadData();
                MessageBox.Show("¡Eliminado correctamente!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            idClienteTextBox.Clear();
            ciPersonalTextBox.Clear();
            nombresTextBox.Clear();
            apellidoPatTextBox.Clear();
            apellidoMatTextBox.Clear();
            dirTextBox.Clear();
            profesTextBox.Clear();
            emailTextBox.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void recursosHumanosDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.recursosHumanosDataGridView.Rows[e.RowIndex];

                idClienteTextBox.Text = row.Cells[0].Value.ToString();
                ciPersonalTextBox.Text = row.Cells[1].Value.ToString();
                nombresTextBox.Text = row.Cells[2].Value.ToString();
                apellidoPatTextBox.Text = row.Cells[3].Value.ToString();
                apellidoMatTextBox.Text = row.Cells[4].Value.ToString();
                sexoComboBox.Text = row.Cells[5].Value.ToString();
                dirTextBox.Text = row.Cells[6].Value.ToString();
                profesTextBox.Text = row.Cells[7].Value.ToString();
                emailTextBox.Text = row.Cells[8].Value.ToString();
                cargoComboBox.Text = row.Cells[9].Value.ToString();
                procedenciaComboBox.Text = row.Cells[10].Value.ToString();
            }
        }

        private void nombresTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //VALIDANDO LETRAS
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                //MessageBox.Show("¡Solo letras!");
                e.Handled = true;
            }
        }

        private void apellidoPatTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //VALIDANDO LETRAS
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                //MessageBox.Show("¡Solo letras!");
                e.Handled = true;
            }
        }

        private void apellidoMatTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //VALIDANDO LETRAS
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                //MessageBox.Show("¡Solo letras!");
                e.Handled = true;
            }
        }

        private void ciPersonalTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;

            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;

            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                //   MessageBox.Show("¡Solo números!");
                e.Handled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sexoLabel_Click(object sender, EventArgs e)
        {

        }

        private void sexoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void idClienteLabel_Click(object sender, EventArgs e)
        {

        }

        private void idClienteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ciPersonalLabel_Click(object sender, EventArgs e)
        {

        }

        private void ciPersonalTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombresLabel_Click(object sender, EventArgs e)
        {

        }

        private void nombresTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void apellidoPatLabel_Click(object sender, EventArgs e)
        {

        }

        private void apellidoPatTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void apellidoMatLabel_Click(object sender, EventArgs e)
        {

        }

        private void apellidoMatTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dirLabel_Click(object sender, EventArgs e)
        {

        }

        private void dirTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void profesLabel_Click(object sender, EventArgs e)
        {

        }

        private void profesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cargoLabel_Click(object sender, EventArgs e)
        {

        }

        private void cargoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void procedenciaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void recursosHumanosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void recursosHumanos_Load_1(object sender, EventArgs e)
        {
            actualizarTabla();
            recursosHumanosDataGridView.DataSource = dt;
            recursosHumanosDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            recursosHumanosDataGridView.MultiSelect = false;
        }

        private Boolean borrar()
        {
            try
            {
                strCmd = "delete from recursosHumanos WHERE idCliente='" + recursosHumanosDataGridView.Rows[recursosHumanosDataGridView.SelectedRows[0].Index].Cells["idCliente"].Value.ToString() + "'" + "AND CiPersonal='" + recursosHumanosDataGridView.Rows[recursosHumanosDataGridView.SelectedRows[0].Index].Cells["CiPersonal"].Value.ToString() + "'";
                sqlCmd = new SqlCommand(strCmd, sqlCon);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show(recursosHumanosDataGridView.Rows[recursosHumanosDataGridView.SelectedRows[0].Index].Cells["CiPersonal"].Value.ToString() + "BORRADO CORRECTAMENTE", "AVISO");
                return true;
            }
            catch (SqlException)
            {
                MessageBox.Show("No se a podido eliminar el registro", "Advertencia");
                return false;
                // throw;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            borrar();
            actualizarTabla();
            recursosHumanosDataGridView.DataSource = dt;
        }

        private void recursosHumanosDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (recursosHumanosDataGridView.SelectedRows.Count > 0)
            {
                editando = true;
                idClienteTextBox.Text = recursosHumanosDataGridView.Rows[recursosHumanosDataGridView.SelectedRows[0].Index].Cells["idCliente"].Value.ToString();
                ciPersonalTextBox.Text = recursosHumanosDataGridView.Rows[recursosHumanosDataGridView.SelectedRows[0].Index].Cells["CiPersonal"].Value.ToString();
                nombresTextBox.Text = recursosHumanosDataGridView.Rows[recursosHumanosDataGridView.SelectedRows[0].Index].Cells["Nombres"].Value.ToString();
                apellidoPatTextBox.Text = recursosHumanosDataGridView.Rows[recursosHumanosDataGridView.SelectedRows[0].Index].Cells["ApellidoPat"].Value.ToString();
                apellidoMatTextBox.Text = recursosHumanosDataGridView.Rows[recursosHumanosDataGridView.SelectedRows[0].Index].Cells["ApellidoMat"].Value.ToString();
                dirTextBox.Text = recursosHumanosDataGridView.Rows[recursosHumanosDataGridView.SelectedRows[0].Index].Cells["Dir"].Value.ToString();
                profesTextBox.Text = recursosHumanosDataGridView.Rows[recursosHumanosDataGridView.SelectedRows[0].Index].Cells["Profes"].Value.ToString();
                emailTextBox.Text = recursosHumanosDataGridView.Rows[recursosHumanosDataGridView.SelectedRows[0].Index].Cells["Email"].Value.ToString();

            }
        }

        private Boolean editar()
        {
            try
            {
                if (editando)
                {
                    strCmd = "update recursosHumanos set CiPersonal='" + ciPersonalTextBox.Text + "',Nombres='" + nombresTextBox.Text + "',ApellidoPat='" + apellidoPatTextBox.Text + "',ApellidoMat='" + apellidoMatTextBox.Text + "',Dir='" + dirTextBox.Text + "',Profes='" + profesTextBox.Text + "',Email='" + emailTextBox.Text + "',Cargo='" + cargoComboBox.Text + "',procedencia='" + procedenciaComboBox.Text + "',Sexo='" + sexoComboBox.Text + "' where CiPersonal=" + recursosHumanosDataGridView.Rows[recursosHumanosDataGridView.SelectedRows[0].Index].Cells["CiPersonal"].Value.ToString() + "";

                    sqlCmd = new SqlCommand(strCmd, sqlCon);
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("REGISTRO EDITADO EXITOSAMENTE", "Aviso");
                    editando = false;
                }
                return true;

            }
            catch (SqlException)
            {
                MessageBox.Show(ciPersonalTextBox.Text + nombresTextBox.Text + apellidoPatTextBox.Text);
                MessageBox.Show("no se inserto", "advertencia");
                return false;
                // throw;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            editar();
            actualizarTabla();
            recursosHumanosDataGridView.DataSource = dt;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            idClienteTextBox.Text="";
            ciPersonalTextBox.Text = "";
            nombresTextBox.Text = "";
            apellidoPatTextBox.Text = "";
            apellidoMatTextBox.Text = "";
            dirTextBox.Text = "";
            profesTextBox.Text = "";
            emailTextBox.Text = "";
            ciPersonalTextBox.Focus();

        }

        
    }
}
