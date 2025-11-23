namespace PracticaRecorridoB.forms
{
    partial class FrmBusquedaB
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
            this.btnGenerarN = new System.Windows.Forms.Button();
            this.lbNumero = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbBuscarN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.rtbResultado = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbResultado);
            this.groupBox1.Controls.Add(this.btnGenerarN);
            this.groupBox1.Controls.Add(this.lbNumero);
            this.groupBox1.Location = new System.Drawing.Point(33, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 413);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generar lista de numeros aleatorios";
            // 
            // btnGenerarN
            // 
            this.btnGenerarN.Location = new System.Drawing.Point(23, 64);
            this.btnGenerarN.Name = "btnGenerarN";
            this.btnGenerarN.Size = new System.Drawing.Size(357, 32);
            this.btnGenerarN.TabIndex = 1;
            this.btnGenerarN.Text = "Generar numeros";
            this.btnGenerarN.UseVisualStyleBackColor = true;
            this.btnGenerarN.Click += new System.EventHandler(this.btnGenerarN_Click);
            // 
            // lbNumero
            // 
            this.lbNumero.FormattingEnabled = true;
            this.lbNumero.ItemHeight = 20;
            this.lbNumero.Location = new System.Drawing.Point(23, 114);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(357, 284);
            this.lbNumero.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbBuscarN);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.btnOrdenar);
            this.groupBox2.Location = new System.Drawing.Point(719, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 247);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Funcionalidades";
            // 
            // tbBuscarN
            // 
            this.tbBuscarN.Location = new System.Drawing.Point(55, 139);
            this.tbBuscarN.Name = "tbBuscarN";
            this.tbBuscarN.Size = new System.Drawing.Size(198, 26);
            this.tbBuscarN.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese el número a buscar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(70, 177);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(159, 28);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(70, 40);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(159, 28);
            this.btnOrdenar.TabIndex = 2;
            this.btnOrdenar.Text = "Ordenar ";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // rtbResultado
            // 
            this.rtbResultado.Location = new System.Drawing.Point(398, 114);
            this.rtbResultado.Name = "rtbResultado";
            this.rtbResultado.ReadOnly = true;
            this.rtbResultado.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbResultado.Size = new System.Drawing.Size(263, 284);
            this.rtbResultado.TabIndex = 2;
            this.rtbResultado.Text = "";
            // 
            // FrmBusquedaB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmBusquedaB";
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.Text = "Busqueda binaria";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenerarN;
        private System.Windows.Forms.ListBox lbNumero;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.TextBox tbBuscarN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbResultado;
    }
}