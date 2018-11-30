using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/* LIBRERIA PARA LA BASE DE DATOS*/
using System.Data.SqlClient;
/* LIBRERIA PARA GRAFICAR */
using System.Windows.Forms.DataVisualization.Charting;

namespace DEPRECIACION2._0
{
    public partial class informeActivoFijo : Form
    {
        private SqlConnection sql_con;
        private SqlCommand sql_cmd;
        private SqlDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        public informeActivoFijo()
        {
            InitializeComponent();
            chart1.Titles.Add("PROMEDIOS DE ACTIVOS FIJOS");
            LoadGraphics();
        }

        //CONEXION DB
        private void SetConnection()
        {
            sql_con = new SqlConnection("Server=localhost;Database=sis325;Trusted_Connection=True");
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

        /* CARGAR BD
        private void LoadData()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "Select *from persona";
            DB = new SqlDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView1.DataSource = DT;
            //sql_con.Close();
        }*/

        public void LoadGraphics()
        {
            chart1.Series.Clear();
            
            SetConnection();
            sql_con.Open();
            string sql1 = "select count(ID_RUBRO) FROM activofijo";

            sql_cmd = new SqlCommand(sql1, sql_con);
            SqlDataReader cant = sql_cmd.ExecuteReader();
            cant.Read();

            int i = Convert.ToInt32(cant.GetValue(0).ToString());
            int cont = 1;

            sql_con.Close();
            
            while (cont <= i+2)
            {
                
                sql_con.Open();    
                string sql = "select count(ID_RUBRO),(Select DESCRIPCION from rubro where id_rubro='"+(10000*cont)+"') FROM activofijo where ID_RUBRO="+(10000*cont);

                sql_cmd = new SqlCommand(sql, sql_con);
                SqlDataReader sdr = sql_cmd.ExecuteReader();
                sdr.Read();

                //MessageBox.Show("" + sdr.GetValue(0).ToString());
                if (sdr.GetValue(0).ToString() != "0" || !string.IsNullOrEmpty(sdr.GetValue(1).ToString()))
                {

                    double valor = Convert.ToDouble(sdr.GetValue(0).ToString());
                    /*
                    chart1.Series.Add("MASCULINO");
                    chart1.Series["MASCULINO"].ChartType = SeriesChartType.Column;
                    chart1.Series["MASCULINO"].Label = edadM.ToString();
                    chart1.Series["MASCULINO"].Points.AddY(edadM);
                    chart1.Series["MASCULINO"].ChartArea = "ChartArea1";*/
                    MessageBox.Show(sdr.GetValue(1).ToString());
                    chart1.Series.Add(sdr.GetValue(1).ToString());
                    chart1.Series[sdr.GetValue(1).ToString()].Label = valor.ToString();
                    chart1.Series[sdr.GetValue(1).ToString()].ChartType = SeriesChartType.Column;
                    chart1.Series[sdr.GetValue(1).ToString()].Points.AddY(valor);
                    chart1.Series[sdr.GetValue(1).ToString()].ChartArea = "ChartArea1";
                }
                    /*
                else
                {
                    /*
                    chart1.Series.Add("MASCULINO");
                    chart1.Series["MASCULINO"].Label = "0";
                    chart1.Series["MASCULINO"].ChartType = SeriesChartType.Column;
                    chart1.Series["MASCULINO"].Points.AddY(0);
                    chart1.Series["MASCULINO"].ChartArea = "ChartArea1";*/
                    /*
                    chart1.Series.Add("");
                    chart1.Series[""].Label = "0";
                    chart1.Series[""].ChartType = SeriesChartType.Column;
                    chart1.Series[""].Points.AddY(0);
                    chart1.Series[""].ChartArea = "ChartArea1
                     
                    MessageBox.Show("vacio "+sdr.GetValue(1).ToString());
                }*/
                cont++;
                sql_con.Close();
            }
            
            /*
            if (sdr.GetValue(1).ToString() != "")
            {
                double edadF = Convert.ToDouble(sdr.GetValue(1).ToString());

                chart1.Series.Add("FEMENINO");
                chart1.Series["FEMENINO"].Label = edadF.ToString();
                chart1.Series["FEMENINO"].ChartType = SeriesChartType.Column;
                chart1.Series["FEMENINO"].Points.AddY(edadF);
                chart1.Series["FEMENINO"].ChartArea = "ChartArea1";
            }
            else
            {
                chart1.Series.Add("FEMENINO");
                chart1.Series["FEMENINO"].Label = "0";
                chart1.Series["FEMENINO"].ChartType = SeriesChartType.Column;
                chart1.Series["FEMENINO"].Points.AddY(0);
                chart1.Series["FEMENINO"].ChartArea = "ChartArea1";
            }
            */
            
        }
    }
}
