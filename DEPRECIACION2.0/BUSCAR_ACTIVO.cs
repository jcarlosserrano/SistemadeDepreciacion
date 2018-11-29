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
    public partial class BUSCAR_ACTIVO : Form
    {
        private SqlConnection sqlCon;
        private SqlCommand sqlCmd;
        private String strCmd;
        private DataTable dt;
        private SqlDataAdapter sqlDa;
        private Boolean editando;

        public BUSCAR_ACTIVO()
        {
            InitializeComponent();

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

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void buscar()
        {
            var query = "select * from activoFijo WHERE DESCRIPCION='" + txtDescripcion.Text + "'";
            using (SqlCommand cmd = new SqlCommand(query, sqlCon))
            {
                SqlDataReader read = cmd.ExecuteReader();
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        lbCodRubro.Text = read["CODIGO_ACTIVO"].ToString();
                        lbDescripcion.Text = read["DESCRIPCION"].ToString();
                        lbVidaUtil.Text = read["MARCA"].ToString();
                        lbCoeficiente.Text = read["COLOR"].ToString();
                        lbEstado.Text = read["ESTADO"].ToString();
                        lbTotal.Text = read["VALOR_COMPRA"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("no se encontro dicho rubro");
                    pnlDescripcion.Visible = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buscar();
            pnlDescripcion.Visible = true;
        }

    }
}
