namespace DEPRECIACION2._0
{
    partial class ACTIVOS
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodRubro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodActivo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescripActivo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProcedencia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtValorCompra = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtRubro = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pxbCancelar = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pxbEditar = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pxbEliminar = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pxbGuardar = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.pxbAgregar = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pxbCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxbEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxbEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxbGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxbAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(283, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(394, 31);
            this.label5.TabIndex = 41;
            this.label5.Text = "GESTION DE ACTIVOS FIJOS";
            // 
            // txtCodRubro
            // 
            this.txtCodRubro.FormattingEnabled = true;
            this.txtCodRubro.Items.AddRange(new object[] {
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
            this.txtCodRubro.Location = new System.Drawing.Point(267, 68);
            this.txtCodRubro.Name = "txtCodRubro";
            this.txtCodRubro.Size = new System.Drawing.Size(191, 24);
            this.txtCodRubro.TabIndex = 33;
            this.txtCodRubro.SelectedIndexChanged += new System.EventHandler(this.txtCodRubro_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "SELECCIONE EL CODIGO DE RUBRO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "CODIGO DEL ACTIVO:";
            // 
            // txtCodActivo
            // 
            this.txtCodActivo.Location = new System.Drawing.Point(267, 131);
            this.txtCodActivo.Name = "txtCodActivo";
            this.txtCodActivo.Size = new System.Drawing.Size(141, 22);
            this.txtCodActivo.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 17);
            this.label6.TabIndex = 42;
            this.label6.Text = "DESCRIPCION DEL ACTIVO:";
            // 
            // txtDescripActivo
            // 
            this.txtDescripActivo.Location = new System.Drawing.Point(264, 162);
            this.txtDescripActivo.Multiline = true;
            this.txtDescripActivo.Name = "txtDescripActivo";
            this.txtDescripActivo.Size = new System.Drawing.Size(257, 52);
            this.txtDescripActivo.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 44;
            this.label3.Text = "MARCA:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(264, 218);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(194, 22);
            this.txtMarca.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(580, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 46;
            this.label4.Text = "PROCEDENCIA:";
            // 
            // txtProcedencia
            // 
            this.txtProcedencia.Location = new System.Drawing.Point(696, 68);
            this.txtProcedencia.Name = "txtProcedencia";
            this.txtProcedencia.Size = new System.Drawing.Size(194, 22);
            this.txtProcedencia.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(613, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 48;
            this.label7.Text = "COLOR";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(696, 96);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(172, 22);
            this.txtColor.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(550, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 17);
            this.label8.TabIndex = 50;
            this.label8.Text = "FECHA DE COMPRA";
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.Location = new System.Drawing.Point(696, 167);
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.Size = new System.Drawing.Size(172, 22);
            this.txtValorCompra.TabIndex = 62;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(618, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 17);
            this.label9.TabIndex = 61;
            this.label9.Text = "ESTADO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(549, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 17);
            this.label10.TabIndex = 60;
            this.label10.Text = "VALOR DE COMPRA";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "NUEVO",
            "BUENO",
            "REGULAR",
            "MALO"});
            this.cmbEstado.Location = new System.Drawing.Point(696, 195);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(191, 24);
            this.cmbEstado.TabIndex = 63;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(696, 125);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(265, 22);
            this.dtpFecha.TabIndex = 70;
            this.dtpFecha.Value = new System.DateTime(2018, 11, 27, 18, 13, 51, 0);
            // 
            // txtRubro
            // 
            this.txtRubro.Location = new System.Drawing.Point(267, 103);
            this.txtRubro.Name = "txtRubro";
            this.txtRubro.Size = new System.Drawing.Size(141, 22);
            this.txtRubro.TabIndex = 72;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(109, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 17);
            this.label11.TabIndex = 71;
            this.label11.Text = "CODIGO DEL RUBRO:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(786, 404);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 18);
            this.label12.TabIndex = 82;
            this.label12.Text = "Cancelar";
            // 
            // pxbCancelar
            // 
            this.pxbCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pxbCancelar.Image = global::DEPRECIACION2._0.Properties.Resources.cancelar;
            this.pxbCancelar.Location = new System.Drawing.Point(769, 284);
            this.pxbCancelar.Name = "pxbCancelar";
            this.pxbCancelar.Size = new System.Drawing.Size(100, 100);
            this.pxbCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pxbCancelar.TabIndex = 81;
            this.pxbCancelar.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(633, 404);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 18);
            this.label13.TabIndex = 80;
            this.label13.Text = "Editar";
            // 
            // pxbEditar
            // 
            this.pxbEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pxbEditar.Image = global::DEPRECIACION2._0.Properties.Resources.editar;
            this.pxbEditar.Location = new System.Drawing.Point(616, 284);
            this.pxbEditar.Name = "pxbEditar";
            this.pxbEditar.Size = new System.Drawing.Size(100, 100);
            this.pxbEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pxbEditar.TabIndex = 79;
            this.pxbEditar.TabStop = false;
            this.pxbEditar.Click += new System.EventHandler(this.pxbEditar_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(481, 404);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 18);
            this.label14.TabIndex = 78;
            this.label14.Text = "Eliminar";
            // 
            // pxbEliminar
            // 
            this.pxbEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pxbEliminar.Image = global::DEPRECIACION2._0.Properties.Resources.eliminar;
            this.pxbEliminar.Location = new System.Drawing.Point(464, 284);
            this.pxbEliminar.Name = "pxbEliminar";
            this.pxbEliminar.Size = new System.Drawing.Size(100, 100);
            this.pxbEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pxbEliminar.TabIndex = 77;
            this.pxbEliminar.TabStop = false;
            this.pxbEliminar.Click += new System.EventHandler(this.pxbEliminar_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(328, 404);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 18);
            this.label15.TabIndex = 76;
            this.label15.Text = "Guardar";
            // 
            // pxbGuardar
            // 
            this.pxbGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pxbGuardar.Image = global::DEPRECIACION2._0.Properties.Resources.guardar;
            this.pxbGuardar.Location = new System.Drawing.Point(311, 284);
            this.pxbGuardar.Name = "pxbGuardar";
            this.pxbGuardar.Size = new System.Drawing.Size(100, 100);
            this.pxbGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pxbGuardar.TabIndex = 75;
            this.pxbGuardar.TabStop = false;
            this.pxbGuardar.Click += new System.EventHandler(this.pxbGuardar_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(178, 404);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 18);
            this.label16.TabIndex = 74;
            this.label16.Text = "Agregar";
            // 
            // pxbAgregar
            // 
            this.pxbAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pxbAgregar.Image = global::DEPRECIACION2._0.Properties.Resources.agregar;
            this.pxbAgregar.Location = new System.Drawing.Point(161, 284);
            this.pxbAgregar.Name = "pxbAgregar";
            this.pxbAgregar.Size = new System.Drawing.Size(100, 100);
            this.pxbAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pxbAgregar.TabIndex = 73;
            this.pxbAgregar.TabStop = false;
            this.pxbAgregar.Click += new System.EventHandler(this.pxbAgregar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Silver;
            this.dataGridView1.Location = new System.Drawing.Point(49, 457);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(965, 336);
            this.dataGridView1.TabIndex = 83;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // ACTIVOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 865);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pxbCancelar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pxbEditar);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pxbEliminar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pxbGuardar);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.pxbAgregar);
            this.Controls.Add(this.txtRubro);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.txtValorCompra);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtProcedencia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescripActivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodActivo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCodRubro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ACTIVOS";
            this.Text = "ACTIVOS";
            this.Load += new System.EventHandler(this.ACTIVOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pxbCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxbEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxbEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxbGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxbAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtCodRubro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodActivo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescripActivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProcedencia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtValorCompra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtRubro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pxbCancelar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pxbEditar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pxbEliminar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pxbGuardar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pxbAgregar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}