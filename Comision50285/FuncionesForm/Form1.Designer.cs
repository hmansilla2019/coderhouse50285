namespace FuncionesForm
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
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.lblSegundoNumero = new System.Windows.Forms.Label();
            this.numNumero1 = new System.Windows.Forms.NumericUpDown();
            this.numNumero2 = new System.Windows.Forms.NumericUpDown();
            this.btnSumar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numNumero1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumero2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.Location = new System.Drawing.Point(95, 81);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(128, 15);
            this.lblNumero1.TabIndex = 0;
            this.lblNumero1.Text = "Ingrese primer numero";
            // 
            // lblSegundoNumero
            // 
            this.lblSegundoNumero.AutoSize = true;
            this.lblSegundoNumero.Location = new System.Drawing.Point(95, 124);
            this.lblSegundoNumero.Name = "lblSegundoNumero";
            this.lblSegundoNumero.Size = new System.Drawing.Size(139, 15);
            this.lblSegundoNumero.TabIndex = 1;
            this.lblSegundoNumero.Text = "Ingrese segundo numero";
            // 
            // numNumero1
            // 
            this.numNumero1.Location = new System.Drawing.Point(322, 79);
            this.numNumero1.Name = "numNumero1";
            this.numNumero1.Size = new System.Drawing.Size(150, 23);
            this.numNumero1.TabIndex = 2;
            // 
            // numNumero2
            // 
            this.numNumero2.Location = new System.Drawing.Point(322, 116);
            this.numNumero2.Name = "numNumero2";
            this.numNumero2.Size = new System.Drawing.Size(150, 23);
            this.numNumero2.TabIndex = 3;
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(436, 279);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(75, 23);
            this.btnSumar.TabIndex = 4;
            this.btnSumar.Text = "Sumar";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.numNumero2);
            this.Controls.Add(this.numNumero1);
            this.Controls.Add(this.lblSegundoNumero);
            this.Controls.Add(this.lblNumero1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numNumero1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumero2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNumero1;
        private Label lblSegundoNumero;
        private NumericUpDown numNumero1;
        private NumericUpDown numNumero2;
        private Button btnSumar;
    }
}