namespace ReciboSueldo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblAntiguedad = new System.Windows.Forms.Label();
            this.lblHorasTrabajadas = new System.Windows.Forms.Label();
            this.btnCalcularMostrar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.numAntiguedad = new System.Windows.Forms.NumericUpDown();
            this.numHorasTrabajadas = new System.Windows.Forms.NumericUpDown();
            this.gbResultados = new System.Windows.Forms.GroupBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.numValorHora = new System.Windows.Forms.NumericUpDown();
            this.lblbalorHora = new System.Windows.Forms.Label();
            this.lblTotalNeto = new System.Windows.Forms.Label();
            this.lblTotalDescuentos = new System.Windows.Forms.Label();
            this.lblTotalCobrar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numAntiguedad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHorasTrabajadas)).BeginInit();
            this.gbResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValorHora)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(133, 42);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(54, 15);
            this.lblEmpleado.TabIndex = 0;
            this.lblEmpleado.Text = "Nombre:";
            // 
            // lblAntiguedad
            // 
            this.lblAntiguedad.AutoSize = true;
            this.lblAntiguedad.Location = new System.Drawing.Point(133, 81);
            this.lblAntiguedad.Name = "lblAntiguedad";
            this.lblAntiguedad.Size = new System.Drawing.Size(72, 15);
            this.lblAntiguedad.TabIndex = 1;
            this.lblAntiguedad.Text = "Antiguedad:";
            // 
            // lblHorasTrabajadas
            // 
            this.lblHorasTrabajadas.AutoSize = true;
            this.lblHorasTrabajadas.Location = new System.Drawing.Point(133, 115);
            this.lblHorasTrabajadas.Name = "lblHorasTrabajadas";
            this.lblHorasTrabajadas.Size = new System.Drawing.Size(99, 15);
            this.lblHorasTrabajadas.TabIndex = 2;
            this.lblHorasTrabajadas.Text = "Horas Tranajadas:";
            // 
            // btnCalcularMostrar
            // 
            this.btnCalcularMostrar.Location = new System.Drawing.Point(182, 167);
            this.btnCalcularMostrar.Name = "btnCalcularMostrar";
            this.btnCalcularMostrar.Size = new System.Drawing.Size(254, 52);
            this.btnCalcularMostrar.TabIndex = 3;
            this.btnCalcularMostrar.Text = "Calcular Importe a Cobrar";
            this.btnCalcularMostrar.UseVisualStyleBackColor = true;
            this.btnCalcularMostrar.Click += new System.EventHandler(this.btnCalcularMostrar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(258, 39);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(178, 23);
            this.txtNombre.TabIndex = 4;
            // 
            // numAntiguedad
            // 
            this.numAntiguedad.Location = new System.Drawing.Point(258, 73);
            this.numAntiguedad.Name = "numAntiguedad";
            this.numAntiguedad.Size = new System.Drawing.Size(120, 23);
            this.numAntiguedad.TabIndex = 5;
            // 
            // numHorasTrabajadas
            // 
            this.numHorasTrabajadas.Location = new System.Drawing.Point(258, 108);
            this.numHorasTrabajadas.Name = "numHorasTrabajadas";
            this.numHorasTrabajadas.Size = new System.Drawing.Size(120, 23);
            this.numHorasTrabajadas.TabIndex = 6;
            // 
            // gbResultados
            // 
            this.gbResultados.Controls.Add(this.lblTotalNeto);
            this.gbResultados.Controls.Add(this.btnCerrar);
            this.gbResultados.Controls.Add(this.lblTotalDescuentos);
            this.gbResultados.Controls.Add(this.lblTotalCobrar);
            this.gbResultados.Location = new System.Drawing.Point(578, 28);
            this.gbResultados.Name = "gbResultados";
            this.gbResultados.Size = new System.Drawing.Size(397, 229);
            this.gbResultados.TabIndex = 7;
            this.gbResultados.TabStop = false;
            this.gbResultados.Text = "Resultados";
            this.gbResultados.Visible = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(106, 158);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(254, 52);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // numValorHora
            // 
            this.numValorHora.Location = new System.Drawing.Point(258, 2);
            this.numValorHora.Name = "numValorHora";
            this.numValorHora.Size = new System.Drawing.Size(120, 23);
            this.numValorHora.TabIndex = 9;
            // 
            // lblbalorHora
            // 
            this.lblbalorHora.AutoSize = true;
            this.lblbalorHora.Location = new System.Drawing.Point(133, 9);
            this.lblbalorHora.Name = "lblbalorHora";
            this.lblbalorHora.Size = new System.Drawing.Size(65, 15);
            this.lblbalorHora.TabIndex = 8;
            this.lblbalorHora.Text = "Valor Hora:";
            // 
            // lblTotalNeto
            // 
            this.lblTotalNeto.AutoSize = true;
            this.lblTotalNeto.Location = new System.Drawing.Point(71, 106);
            this.lblTotalNeto.Name = "lblTotalNeto";
            this.lblTotalNeto.Size = new System.Drawing.Size(112, 15);
            this.lblTotalNeto.TabIndex = 12;
            this.lblTotalNeto.Text = "Total Neto a Cobrar:";
            // 
            // lblTotalDescuentos
            // 
            this.lblTotalDescuentos.AutoSize = true;
            this.lblTotalDescuentos.Location = new System.Drawing.Point(71, 72);
            this.lblTotalDescuentos.Name = "lblTotalDescuentos";
            this.lblTotalDescuentos.Size = new System.Drawing.Size(99, 15);
            this.lblTotalDescuentos.TabIndex = 11;
            this.lblTotalDescuentos.Text = "Total Descuentos:";
            // 
            // lblTotalCobrar
            // 
            this.lblTotalCobrar.AutoSize = true;
            this.lblTotalCobrar.Location = new System.Drawing.Point(71, 33);
            this.lblTotalCobrar.Name = "lblTotalCobrar";
            this.lblTotalCobrar.Size = new System.Drawing.Size(115, 15);
            this.lblTotalCobrar.TabIndex = 10;
            this.lblTotalCobrar.Text = "Total a Cobrar Bruto:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 269);
            this.Controls.Add(this.numValorHora);
            this.Controls.Add(this.lblbalorHora);
            this.Controls.Add(this.gbResultados);
            this.Controls.Add(this.numHorasTrabajadas);
            this.Controls.Add(this.numAntiguedad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnCalcularMostrar);
            this.Controls.Add(this.lblHorasTrabajadas);
            this.Controls.Add(this.lblAntiguedad);
            this.Controls.Add(this.lblEmpleado);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numAntiguedad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHorasTrabajadas)).EndInit();
            this.gbResultados.ResumeLayout(false);
            this.gbResultados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValorHora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblEmpleado;
        private Label lblAntiguedad;
        private Label lblHorasTrabajadas;
        private Button btnCalcularMostrar;
        private TextBox txtNombre;
        private NumericUpDown numAntiguedad;
        private NumericUpDown numHorasTrabajadas;
        private GroupBox gbResultados;
        private Button btnCerrar;
        private Label lblTotalNeto;
        private Label lblTotalDescuentos;
        private Label lblTotalCobrar;
        private NumericUpDown numValorHora;
        private Label lblbalorHora;
    }
}