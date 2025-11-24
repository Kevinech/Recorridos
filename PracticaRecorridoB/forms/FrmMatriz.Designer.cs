namespace PracticaRecorridoB.forms
{
    partial class FrmMatriz
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
            this.dgvMatriz = new System.Windows.Forms.DataGridView();
            this.rtbResultados = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGenerarMatriz = new System.Windows.Forms.Button();
            this.btnBuscarN = new System.Windows.Forms.Button();
            this.tbbuscarN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbResultados);
            this.groupBox1.Controls.Add(this.dgvMatriz);
            this.groupBox1.Location = new System.Drawing.Point(24, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 525);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visualizaciones";
            // 
            // dgvMatriz
            // 
            this.dgvMatriz.AllowUserToAddRows = false;
            this.dgvMatriz.AllowUserToDeleteRows = false;
            this.dgvMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriz.Location = new System.Drawing.Point(22, 25);
            this.dgvMatriz.Name = "dgvMatriz";
            this.dgvMatriz.ReadOnly = true;
            this.dgvMatriz.Size = new System.Drawing.Size(537, 222);
            this.dgvMatriz.TabIndex = 0;
            // 
            // rtbResultados
            // 
            this.rtbResultados.Location = new System.Drawing.Point(22, 286);
            this.rtbResultados.Name = "rtbResultados";
            this.rtbResultados.Size = new System.Drawing.Size(537, 222);
            this.rtbResultados.TabIndex = 1;
            this.rtbResultados.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbbuscarN);
            this.groupBox2.Controls.Add(this.btnBuscarN);
            this.groupBox2.Controls.Add(this.btnGenerarMatriz);
            this.groupBox2.Location = new System.Drawing.Point(608, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(469, 412);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Funciones";
            // 
            // btnGenerarMatriz
            // 
            this.btnGenerarMatriz.Location = new System.Drawing.Point(33, 41);
            this.btnGenerarMatriz.Name = "btnGenerarMatriz";
            this.btnGenerarMatriz.Size = new System.Drawing.Size(399, 38);
            this.btnGenerarMatriz.TabIndex = 0;
            this.btnGenerarMatriz.Text = "Generar matriz";
            this.btnGenerarMatriz.UseVisualStyleBackColor = true;
            this.btnGenerarMatriz.Click += new System.EventHandler(this.btnGenerarMatriz_Click);
            // 
            // btnBuscarN
            // 
            this.btnBuscarN.Location = new System.Drawing.Point(33, 227);
            this.btnBuscarN.Name = "btnBuscarN";
            this.btnBuscarN.Size = new System.Drawing.Size(399, 45);
            this.btnBuscarN.TabIndex = 2;
            this.btnBuscarN.Text = "Buscar número";
            this.btnBuscarN.UseVisualStyleBackColor = true;
            this.btnBuscarN.Click += new System.EventHandler(this.btnBuscarN_Click);
            // 
            // tbbuscarN
            // 
            this.tbbuscarN.Location = new System.Drawing.Point(22, 183);
            this.tbbuscarN.Name = "tbbuscarN";
            this.tbbuscarN.Size = new System.Drawing.Size(426, 26);
            this.tbbuscarN.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese un número a buscar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmMatriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMatriz";
            this.Text = "FrmMatriz";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbResultados;
        private System.Windows.Forms.DataGridView dgvMatriz;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbbuscarN;
        private System.Windows.Forms.Button btnBuscarN;
        private System.Windows.Forms.Button btnGenerarMatriz;
    }
}