namespace DEPRECIACION2._0
{
    partial class RUBROS2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.txtCoeficiente = new System.Windows.Forms.TextBox();
            this.txtAnios = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pxbCancelar = new System.Windows.Forms.PictureBox();
            this.pxbEditar = new System.Windows.Forms.PictureBox();
            this.pxbEliminar = new System.Windows.Forms.PictureBox();
            this.pxbGuardar = new System.Windows.Forms.PictureBox();
            this.pxbAgregar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxbCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxbEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxbEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxbGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxbAgregar)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "POR AÑO";
            // 
            // txtCoeficiente
            // 
            this.txtCoeficiente.Location = new System.Drawing.Point(204, 232);
            this.txtCoeficiente.Name = "txtCoeficiente";
            this.txtCoeficiente.Size = new System.Drawing.Size(115, 22);
            this.txtCoeficiente.TabIndex = 2;
            // 
            // txtAnios
            // 
            this.txtAnios.FormattingEnabled = true;
            this.txtAnios.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.txtAnios.Location = new System.Drawing.Point(204, 177);
            this.txtAnios.Name = "txtAnios";
            this.txtAnios.Size = new System.Drawing.Size(97, 24);
            this.txtAnios.TabIndex = 1;
            this.txtAnios.Validating += new System.ComponentModel.CancelEventHandler(this.txtAnios_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "% DE DEPRECIACION:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "AÑOS DE VIDA UTIL:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(204, 106);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(563, 49);
            this.txtDescripcion.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "DETALLE:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Silver;
            this.dataGridView1.Location = new System.Drawing.Point(49, 458);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(965, 336);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(331, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(359, 36);
            this.label5.TabIndex = 27;
            this.label5.Text = "GESTION DE RUBROS ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(267, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Agregar";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(417, 424);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Guardar";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(570, 424);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 18);
            this.label8.TabIndex = 5;
            this.label8.Text = "Eliminar";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(722, 424);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "Editar";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(875, 424);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 18);
            this.label10.TabIndex = 7;
            this.label10.Text = "Cancelar";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // pxbCancelar
            // 
            this.pxbCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pxbCancelar.Image = global::DEPRECIACION2._0.Properties.Resources.cancelar;
            this.pxbCancelar.Location = new System.Drawing.Point(858, 304);
            this.pxbCancelar.Name = "pxbCancelar";
            this.pxbCancelar.Size = new System.Drawing.Size(100, 100);
            this.pxbCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pxbCancelar.TabIndex = 36;
            this.pxbCancelar.TabStop = false;
            this.pxbCancelar.Click += new System.EventHandler(this.pxbCancelar_Click);
            // 
            // pxbEditar
            // 
            this.pxbEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pxbEditar.Image = global::DEPRECIACION2._0.Properties.Resources.editar;
            this.pxbEditar.Location = new System.Drawing.Point(705, 304);
            this.pxbEditar.Name = "pxbEditar";
            this.pxbEditar.Size = new System.Drawing.Size(100, 100);
            this.pxbEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pxbEditar.TabIndex = 34;
            this.pxbEditar.TabStop = false;
            this.pxbEditar.Click += new System.EventHandler(this.pxbEditar_Click);
            // 
            // pxbEliminar
            // 
            this.pxbEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pxbEliminar.Image = global::DEPRECIACION2._0.Properties.Resources.eliminar;
            this.pxbEliminar.Location = new System.Drawing.Point(553, 304);
            this.pxbEliminar.Name = "pxbEliminar";
            this.pxbEliminar.Size = new System.Drawing.Size(100, 100);
            this.pxbEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pxbEliminar.TabIndex = 32;
            this.pxbEliminar.TabStop = false;
            this.pxbEliminar.Click += new System.EventHandler(this.pxbEliminar_Click);
            // 
            // pxbGuardar
            // 
            this.pxbGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pxbGuardar.Image = global::DEPRECIACION2._0.Properties.Resources.guardar;
            this.pxbGuardar.Location = new System.Drawing.Point(400, 304);
            this.pxbGuardar.Name = "pxbGuardar";
            this.pxbGuardar.Size = new System.Drawing.Size(100, 100);
            this.pxbGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pxbGuardar.TabIndex = 30;
            this.pxbGuardar.TabStop = false;
            this.pxbGuardar.Click += new System.EventHandler(this.pxbGuardar_Click);
            // 
            // pxbAgregar
            // 
            this.pxbAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pxbAgregar.Image = global::DEPRECIACION2._0.Properties.Resources.agregar;
            this.pxbAgregar.Location = new System.Drawing.Point(250, 304);
            this.pxbAgregar.Name = "pxbAgregar";
            this.pxbAgregar.Size = new System.Drawing.Size(100, 100);
            this.pxbAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pxbAgregar.TabIndex = 28;
            this.pxbAgregar.TabStop = false;
            this.pxbAgregar.Click += new System.EventHandler(this.pxbAgregar_Click);
            // 
            // RUBROS2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 865);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pxbCancelar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pxbEditar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pxbEliminar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pxbGuardar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pxbAgregar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCoeficiente);
            this.Controls.Add(this.txtAnios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RUBROS2";
            this.Text = "RUBROS2";
            this.Load += new System.EventHandler(this.RUBROS2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxbCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxbEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxbEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxbGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxbAgregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCoeficiente;
        private System.Windows.Forms.ComboBox txtAnios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pxbAgregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pxbGuardar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pxbEliminar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pxbEditar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pxbCancelar;
    }
}