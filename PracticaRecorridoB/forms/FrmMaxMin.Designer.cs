namespace PracticaRecorridoB.forms
{
    partial class FrmMaxMin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbResultado = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNumeros = new System.Windows.Forms.TextBox();
            this.btnBuscarMaxMin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnBuscarMaxMin);
            this.groupBox1.Controls.Add(this.tbNumeros);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rtbResultado);
            this.groupBox1.Location = new System.Drawing.Point(42, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 480);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // rtbResultado
            // 
            this.rtbResultado.Location = new System.Drawing.Point(37, 171);
            this.rtbResultado.Name = "rtbResultado";
            this.rtbResultado.Size = new System.Drawing.Size(529, 262);
            this.rtbResultado.TabIndex = 0;
            this.rtbResultado.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese una lista de numeros separada por coma";
            // 
            // tbNumeros
            // 
            this.tbNumeros.Location = new System.Drawing.Point(37, 139);
            this.tbNumeros.Name = "tbNumeros";
            this.tbNumeros.Size = new System.Drawing.Size(434, 26);
            this.tbNumeros.TabIndex = 2;
            // 
            // btnBuscarMaxMin
            // 
            this.btnBuscarMaxMin.Location = new System.Drawing.Point(477, 135);
            this.btnBuscarMaxMin.Name = "btnBuscarMaxMin";
            this.btnBuscarMaxMin.Size = new System.Drawing.Size(89, 30);
            this.btnBuscarMaxMin.TabIndex = 3;
            this.btnBuscarMaxMin.Text = "Organizar";
            this.btnBuscarMaxMin.UseVisualStyleBackColor = true;
            this.btnBuscarMaxMin.Click += new System.EventHandler(this.btnBuscarMaxMin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ejemplo: 8, 15, 4, 2, 25, 19, 3, 10";
            // 
            // FrmMaxMin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMaxMin";
            this.Text = "FrmMaxMin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarMaxMin;
        private System.Windows.Forms.TextBox tbNumeros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbResultado;
        private System.Windows.Forms.Label label2;
    }
}