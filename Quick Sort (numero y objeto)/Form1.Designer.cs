
namespace Quick_Sort
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstDatosDesordenados = new System.Windows.Forms.ListBox();
            this.lstDatosOrdenados = new System.Windows.Forms.ListBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.txtCantidadDatos = new System.Windows.Forms.TextBox();
            this.lblCantidadDatos = new System.Windows.Forms.Label();
            this.chkObjeto = new System.Windows.Forms.CheckBox();
            this.dtgAlumnosDesordenado = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgAlumnosOrdenado = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlumnosDesordenado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlumnosOrdenado)).BeginInit();
            this.SuspendLayout();
            // 
            // lstDatosDesordenados
            // 
            this.lstDatosDesordenados.FormattingEnabled = true;
            this.lstDatosDesordenados.ItemHeight = 20;
            this.lstDatosDesordenados.Location = new System.Drawing.Point(18, 95);
            this.lstDatosDesordenados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstDatosDesordenados.Name = "lstDatosDesordenados";
            this.lstDatosDesordenados.Size = new System.Drawing.Size(178, 444);
            this.lstDatosDesordenados.TabIndex = 0;
            // 
            // lstDatosOrdenados
            // 
            this.lstDatosOrdenados.FormattingEnabled = true;
            this.lstDatosOrdenados.ItemHeight = 20;
            this.lstDatosOrdenados.Location = new System.Drawing.Point(204, 95);
            this.lstDatosOrdenados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstDatosOrdenados.Name = "lstDatosOrdenados";
            this.lstDatosOrdenados.Size = new System.Drawing.Size(178, 444);
            this.lstDatosOrdenados.TabIndex = 1;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(270, 50);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(112, 35);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(18, 549);
            this.btnOrdenar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(367, 35);
            this.btnOrdenar.TabIndex = 3;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.Ordenar_Click);
            // 
            // txtCantidadDatos
            // 
            this.txtCantidadDatos.Location = new System.Drawing.Point(164, 54);
            this.txtCantidadDatos.Name = "txtCantidadDatos";
            this.txtCantidadDatos.Size = new System.Drawing.Size(100, 26);
            this.txtCantidadDatos.TabIndex = 4;
            // 
            // lblCantidadDatos
            // 
            this.lblCantidadDatos.AutoSize = true;
            this.lblCantidadDatos.Location = new System.Drawing.Point(14, 58);
            this.lblCantidadDatos.Name = "lblCantidadDatos";
            this.lblCantidadDatos.Size = new System.Drawing.Size(143, 20);
            this.lblCantidadDatos.TabIndex = 5;
            this.lblCantidadDatos.Text = "Cantidad de datos:";
            // 
            // chkObjeto
            // 
            this.chkObjeto.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkObjeto.Location = new System.Drawing.Point(18, 14);
            this.chkObjeto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkObjeto.Name = "chkObjeto";
            this.chkObjeto.Size = new System.Drawing.Size(364, 32);
            this.chkObjeto.TabIndex = 6;
            this.chkObjeto.Text = "Representar Mediante un Objeto";
            this.chkObjeto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkObjeto.UseVisualStyleBackColor = true;
            this.chkObjeto.CheckedChanged += new System.EventHandler(this.chkObjeto_CheckedChanged);
            // 
            // dtgAlumnosDesordenado
            // 
            this.dtgAlumnosDesordenado.AllowUserToAddRows = false;
            this.dtgAlumnosDesordenado.AllowUserToDeleteRows = false;
            this.dtgAlumnosDesordenado.AllowUserToOrderColumns = true;
            this.dtgAlumnosDesordenado.AllowUserToResizeColumns = false;
            this.dtgAlumnosDesordenado.AllowUserToResizeRows = false;
            this.dtgAlumnosDesordenado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgAlumnosDesordenado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgAlumnosDesordenado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAlumnosDesordenado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.edad,
            this.estatura});
            this.dtgAlumnosDesordenado.Location = new System.Drawing.Point(20, 95);
            this.dtgAlumnosDesordenado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgAlumnosDesordenado.Name = "dtgAlumnosDesordenado";
            this.dtgAlumnosDesordenado.RowHeadersWidth = 62;
            this.dtgAlumnosDesordenado.Size = new System.Drawing.Size(362, 214);
            this.dtgAlumnosDesordenado.TabIndex = 7;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nombre:";
            this.Nom.MinimumWidth = 8;
            this.Nom.Name = "Nom";
            // 
            // edad
            // 
            this.edad.HeaderText = "Edad";
            this.edad.MinimumWidth = 8;
            this.edad.Name = "edad";
            // 
            // estatura
            // 
            this.estatura.HeaderText = "Estatura";
            this.estatura.MinimumWidth = 8;
            this.estatura.Name = "estatura";
            // 
            // dtgAlumnosOrdenado
            // 
            this.dtgAlumnosOrdenado.AllowUserToAddRows = false;
            this.dtgAlumnosOrdenado.AllowUserToDeleteRows = false;
            this.dtgAlumnosOrdenado.AllowUserToOrderColumns = true;
            this.dtgAlumnosOrdenado.AllowUserToResizeColumns = false;
            this.dtgAlumnosOrdenado.AllowUserToResizeRows = false;
            this.dtgAlumnosOrdenado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgAlumnosOrdenado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgAlumnosOrdenado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAlumnosOrdenado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dtgAlumnosOrdenado.Location = new System.Drawing.Point(18, 319);
            this.dtgAlumnosOrdenado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgAlumnosOrdenado.Name = "dtgAlumnosOrdenado";
            this.dtgAlumnosOrdenado.RowHeadersWidth = 62;
            this.dtgAlumnosOrdenado.Size = new System.Drawing.Size(362, 214);
            this.dtgAlumnosOrdenado.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre:";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Edad";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Estatura";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 596);
            this.Controls.Add(this.dtgAlumnosOrdenado);
            this.Controls.Add(this.dtgAlumnosDesordenado);
            this.Controls.Add(this.chkObjeto);
            this.Controls.Add(this.lblCantidadDatos);
            this.Controls.Add(this.txtCantidadDatos);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lstDatosOrdenados);
            this.Controls.Add(this.lstDatosDesordenados);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Quick Sort";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlumnosDesordenado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlumnosOrdenado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDatosDesordenados;
        private System.Windows.Forms.ListBox lstDatosOrdenados;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.TextBox txtCantidadDatos;
        private System.Windows.Forms.Label lblCantidadDatos;
        private System.Windows.Forms.CheckBox chkObjeto;
        private System.Windows.Forms.DataGridView dtgAlumnosDesordenado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatura;
        private System.Windows.Forms.DataGridView dtgAlumnosOrdenado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}

