
namespace Forms
{
    partial class frmEmpleado
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
            this.lblRegistro = new System.Windows.Forms.Label();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.lblContador = new System.Windows.Forms.Label();
            this.gbOpciones = new System.Windows.Forms.GroupBox();
            this.rbContadorDesactivado = new System.Windows.Forms.RadioButton();
            this.rbContadorActivated = new System.Windows.Forms.RadioButton();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.gbOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.Location = new System.Drawing.Point(218, 130);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(121, 21);
            this.lblRegistro.TabIndex = 10;
            this.lblRegistro.Text = "Nº de Registros:";
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.btnLimpiar);
            this.gbDatos.Controls.Add(this.lblSueldo);
            this.gbDatos.Controls.Add(this.lblNombre);
            this.gbDatos.Controls.Add(this.lblNumero);
            this.gbDatos.Controls.Add(this.btnInsertar);
            this.gbDatos.Controls.Add(this.txtSueldo);
            this.gbDatos.Controls.Add(this.txtNumero);
            this.gbDatos.Controls.Add(this.txtNombre);
            this.gbDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatos.Location = new System.Drawing.Point(11, 17);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(201, 223);
            this.gbDatos.TabIndex = 9;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos Del Empleado:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.ForeColor = System.Drawing.Color.Red;
            this.btnLimpiar.Location = new System.Drawing.Point(104, 185);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(16, 160);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(69, 16);
            this.lblSueldo.TabIndex = 7;
            this.lblSueldo.Text = "Sueldos:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(10, 101);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(75, 16);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombres:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(16, 48);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(66, 16);
            this.lblNumero.TabIndex = 5;
            this.lblNumero.Text = "Número:";
            // 
            // btnInsertar
            // 
            this.btnInsertar.ForeColor = System.Drawing.Color.Green;
            this.btnInsertar.Location = new System.Drawing.Point(19, 185);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 4;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(91, 157);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(100, 22);
            this.txtSueldo.TabIndex = 3;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(91, 45);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 22);
            this.txtNumero.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(91, 101);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // dgvInfo
            // 
            this.dgvInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvInfo.Location = new System.Drawing.Point(12, 246);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.Size = new System.Drawing.Size(400, 150);
            this.dgvInfo.TabIndex = 8;
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.Location = new System.Drawing.Point(345, 130);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(0, 21);
            this.lblContador.TabIndex = 12;
            // 
            // gbOpciones
            // 
            this.gbOpciones.Controls.Add(this.rbContadorDesactivado);
            this.gbOpciones.Controls.Add(this.rbContadorActivated);
            this.gbOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpciones.Location = new System.Drawing.Point(218, 17);
            this.gbOpciones.Name = "gbOpciones";
            this.gbOpciones.Size = new System.Drawing.Size(194, 110);
            this.gbOpciones.TabIndex = 11;
            this.gbOpciones.TabStop = false;
            this.gbOpciones.Text = "Opciones De Contador:";
            // 
            // rbContadorDesactivado
            // 
            this.rbContadorDesactivado.AutoSize = true;
            this.rbContadorDesactivado.Location = new System.Drawing.Point(6, 76);
            this.rbContadorDesactivado.Name = "rbContadorDesactivado";
            this.rbContadorDesactivado.Size = new System.Drawing.Size(181, 20);
            this.rbContadorDesactivado.TabIndex = 1;
            this.rbContadorDesactivado.TabStop = true;
            this.rbContadorDesactivado.Text = "Contador Desactivado";
            this.rbContadorDesactivado.UseVisualStyleBackColor = true;
            this.rbContadorDesactivado.CheckedChanged += new System.EventHandler(this.rbContadorInactivated_CheckedChanged);
            // 
            // rbContadorActivated
            // 
            this.rbContadorActivated.AutoSize = true;
            this.rbContadorActivated.Location = new System.Drawing.Point(6, 35);
            this.rbContadorActivated.Name = "rbContadorActivated";
            this.rbContadorActivated.Size = new System.Drawing.Size(154, 20);
            this.rbContadorActivated.TabIndex = 0;
            this.rbContadorActivated.TabStop = true;
            this.rbContadorActivated.Text = "Contador Activado";
            this.rbContadorActivated.UseVisualStyleBackColor = true;
            this.rbContadorActivated.CheckedChanged += new System.EventHandler(this.rbContadorActivated_CheckedChanged);
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 410);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.gbOpciones);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.dgvInfo);
            this.Name = "frmEmpleado";
            this.Text = "Empleados";
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.gbOpciones.ResumeLayout(false);
            this.gbOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView dgvInfo;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.GroupBox gbOpciones;
        private System.Windows.Forms.RadioButton rbContadorDesactivado;
        private System.Windows.Forms.RadioButton rbContadorActivated;
    }
}

