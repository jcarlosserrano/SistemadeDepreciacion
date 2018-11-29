using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DEPRECIACION2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;

        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new INICIO());
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            //subMenuReportes.Visible=true;
            if (subMenuReportes.Visible == true)
            {
                subMenuReportes.Visible = false;
            }
            else
            {
                subMenuReportes.Visible = true;
            }
            btnRubros.Location = new Point(12, 218);
            panel2.Location = new Point(3, 218);
            subMenuReportes.Location = new Point(73, 448);
            btnActivos.Location = new Point(12, 264);
            panel5.Location = new Point(3, 264);
            btnPersonal.Location = new Point(12, 310);
            panel3.Location = new Point(3, 310);
            btnUbicacion.Location = new Point(12, 356);
            panel6.Location = new Point(3, 356);
            btnReportes.Location = new Point(12, 402);
            panel7.Location = new Point(3, 402);
            subMenuRubros.Hide();
            submenuActivos.Hide();
            subMenuPersonal.Hide();
            subMenuUbicacion.Hide();

            if (subMenuReportes.Visible == false)
            {
                btnRubros.Location = new Point(12, 218);
                panel2.Location = new Point(3, 218);
                btnActivos.Location = new Point(12, 264);
                panel5.Location = new Point(3, 264);
                btnPersonal.Location = new Point(12, 310);
                panel3.Location = new Point(3, 310);
                btnUbicacion.Location = new Point(12, 356);
                panel6.Location = new Point(3, 356);
                btnReportes.Location = new Point(12, 402);
                panel7.Location = new Point(3, 402);
            }
        }

        private void rptActivos_Click(object sender, EventArgs e)
        {
            subMenuReportes.Visible = false;
        }

        private void rptDepresiacion_Click(object sender, EventArgs e)
        {
            subMenuReportes.Visible = false;
        }

        private void rptPersonal_Click(object sender, EventArgs e)
        {
            subMenuReportes.Visible = false;
        }

        private void rptDepartamentos_Click(object sender, EventArgs e)
        {
            subMenuReportes.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AbrirFormulario(object Formulario)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            Form fh = Formulario as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }


        private int pocitiony = 60;
        private bool click = true;

        private void btnRubros_Click(object sender, EventArgs e)
        {
            if (subMenuRubros.Visible == true)
            {
                subMenuRubros.Visible = false;
            }
            else
            {
                subMenuRubros.Visible = true;
            }
            btnRubros.Location = new Point(12, 218);
            panel2.Location = new Point(3, 218);
            subMenuRubros.Location = new Point(93, 259);
            btnActivos.Location = new Point(12, 336);
            panel5.Location = new Point(3, 336);
            btnPersonal.Location = new Point(12, 382);
            panel3.Location = new Point(3, 382);
            btnUbicacion.Location = new Point(12, 428);
            panel6.Location = new Point(3, 428);
            btnReportes.Location = new Point(12, 474);
            panel7.Location = new Point(3, 474);
            submenuActivos.Hide();
            subMenuPersonal.Hide();
            subMenuUbicacion.Hide();
            subMenuReportes.Hide();
            if (subMenuRubros.Visible == false)
            {
                btnRubros.Location = new Point(12, 218);
                panel2.Location = new Point(3, 218);
                btnActivos.Location = new Point(12, 264);
                panel5.Location = new Point(3, 264);
                btnPersonal.Location = new Point(12, 310);
                panel3.Location = new Point(3, 310);
                btnUbicacion.Location = new Point(12, 356);
                panel6.Location = new Point(3, 356);
                btnReportes.Location = new Point(12, 402);
                panel7.Location = new Point(3, 402); 
            }
            
                 
        }

       


        private void Form1_Load(object sender, EventArgs e)
        {
            
            pictureBox2_Click(null, e);

            this.WindowState = FormWindowState.Maximized;

            btnRubros.Location = new Point(12, 218);
            panel4.Location = new Point(3, 218);
            btnActivos.Location = new Point(12, 264);
            panel5.Location = new Point(3, 264);
            btnPersonal.Location = new Point(12, 310);
            panel3.Location = new Point(3, 310);
            btnUbicacion.Location = new Point(12, 356);
            panel6.Location = new Point(3, 356);
            btnReportes.Location = new Point(12, 402);
            panel7.Location = new Point(3, 402);
            subMenuRubros.Hide();
            submenuActivos.Hide();
            subMenuPersonal.Hide();
            subMenuUbicacion.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (submenuActivos.Visible == true)
            {
                submenuActivos.Visible = false;
            }
            else
            {
                submenuActivos.Visible = true;
            }
            btnRubros.Location = new Point(12, 218);
            panel2.Location = new Point(3, 218);
            submenuActivos.Location = new Point(93, 310);
            btnActivos.Location = new Point(12, 264);
            panel5.Location = new Point(3, 264);
            btnPersonal.Location = new Point(12, 382);
            panel3.Location = new Point(3, 382);
            btnUbicacion.Location = new Point(9, 428);
            panel6.Location = new Point(3, 428);
            btnReportes.Location = new Point(12, 479);
            panel7.Location = new Point(3, 479);
            subMenuRubros.Hide();
            subMenuPersonal.Hide();
            subMenuUbicacion.Hide();
            subMenuReportes.Hide();

            if (submenuActivos.Visible == false)
            {
                btnRubros.Location = new Point(12, 218);
                panel2.Location = new Point(3, 218);
                btnActivos.Location = new Point(12, 264);
                panel5.Location = new Point(3, 264);
                btnPersonal.Location = new Point(12, 310);
                panel3.Location = new Point(3, 310);
                btnUbicacion.Location = new Point(12, 356);
                panel6.Location = new Point(3, 356);
                btnReportes.Location = new Point(12, 402);
                panel7.Location = new Point(3, 402);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new RUBROS2());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new ACTIVOS());

        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {

        }

        private void btnPersonal_Click_1(object sender, EventArgs e)
        {
            if (subMenuPersonal.Visible == true)
            {
                subMenuPersonal.Visible = false;
            }
            else
            {
                subMenuPersonal.Visible = true;
            }
            btnRubros.Location = new Point(12, 218);
            panel2.Location = new Point(3, 218);
            subMenuPersonal.Location = new Point(93, 356);
            btnActivos.Location = new Point(12, 264);
            panel5.Location = new Point(3, 264);
            btnPersonal.Location = new Point(12, 310);
            panel3.Location = new Point(3, 310);
            btnUbicacion.Location = new Point(12, 428);
            panel6.Location = new Point(3, 428);
            btnReportes.Location = new Point(12, 474);
            panel7.Location = new Point(3, 474);
            subMenuRubros.Hide();
            submenuActivos.Hide();
            subMenuUbicacion.Hide();
            subMenuReportes.Hide();

            if (subMenuPersonal.Visible == false)
            {
                btnRubros.Location = new Point(12, 218);
                panel2.Location = new Point(3, 218);
                btnActivos.Location = new Point(12, 264);
                panel5.Location = new Point(3, 264);
                btnPersonal.Location = new Point(12, 310);
                panel3.Location = new Point(3, 310);
                btnUbicacion.Location = new Point(12, 356);
                panel6.Location = new Point(3, 356);
                btnReportes.Location = new Point(12, 402);
                panel7.Location = new Point(3, 402);
            }
        }

        private void btnUbicacion_Click(object sender, EventArgs e)
        {
            if (subMenuUbicacion.Visible == true)
            {
                subMenuUbicacion.Visible = false;
            }
            else
            {
                subMenuUbicacion.Visible = true;
            }
            btnRubros.Location = new Point(12, 218);
            panel2.Location = new Point(3, 218);
            subMenuUbicacion.Location = new Point(93, 402);
            btnActivos.Location = new Point(12, 264);
            panel5.Location = new Point(3, 264);
            btnPersonal.Location = new Point(12, 310);
            panel3.Location = new Point(3, 310);
            btnUbicacion.Location = new Point(12, 356);
            panel6.Location = new Point(3, 356);
            btnReportes.Location = new Point(12, 474);
            panel7.Location = new Point(3, 474);
            subMenuRubros.Hide();
            submenuActivos.Hide();
            subMenuPersonal.Hide();
            subMenuReportes.Hide();

            if (subMenuUbicacion.Visible == false)
            {
                btnRubros.Location = new Point(12, 218);
                panel2.Location = new Point(3, 218);
                btnActivos.Location = new Point(12, 264);
                panel5.Location = new Point(3, 264);
                btnPersonal.Location = new Point(12, 310);
                panel3.Location = new Point(3, 310);
                btnUbicacion.Location = new Point(12, 356);
                panel6.Location = new Point(3, 356);
                btnReportes.Location = new Point(12, 402);
                panel7.Location = new Point(3, 402);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new recursosHumanos());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new UBICACION());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BUSCAR_RUBRO abrir = new BUSCAR_RUBRO();
            abrir.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BUSCAR_ACTIVO abrir = new BUSCAR_ACTIVO();
            abrir.Show();
        }

    }
}
