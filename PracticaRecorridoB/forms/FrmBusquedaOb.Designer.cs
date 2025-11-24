namespace PracticaRecorridoB.forms
{
    partial class FrmBusquedaOb
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
            this.btnBuscarN = new System.Windows.Forms.Button();
            this.tbIdEstudiante = new System.Windows.Forms.TextBox();
            this.tbNombreE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbListaEstudiantes = new System.Windows.Forms.ListBox();
            this.btnBuscarI = new System.Windows.Forms.Button();
            this.rtbMostrarR = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarI);
            this.groupBox1.Controls.Add(this.btnBuscarN);
            this.groupBox1.Controls.Add(this.tbIdEstudiante);
            this.groupBox1.Controls.Add(this.tbNombreE);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbListaEstudiantes);
            this.groupBox1.Location = new System.Drawing.Point(37, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 484);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funciones";
            // 
            // btnBuscarN
            // 
            this.btnBuscarN.Location = new System.Drawing.Point(46, 361);
            this.btnBuscarN.Name = "btnBuscarN";
            this.btnBuscarN.Size = new System.Drawing.Size(224, 35);
            this.btnBuscarN.TabIndex = 5;
            this.btnBuscarN.Text = "Buscar por nombre";
            this.btnBuscarN.UseVisualStyleBackColor = true;
            this.btnBuscarN.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tbIdEstudiante
            // 
            this.tbIdEstudiante.Location = new System.Drawing.Point(189, 264);
            this.tbIdEstudiante.Name = "tbIdEstudiante";
            this.tbIdEstudiante.Size = new System.Drawing.Size(388, 26);
            this.tbIdEstudiante.TabIndex = 4;
            // 
            // tbNombreE
            // 
            this.tbNombreE.Location = new System.Drawing.Point(189, 198);
            this.tbNombreE.Name = "tbNombreE";
            this.tbNombreE.Size = new System.Drawing.Size(388, 26);
            this.tbNombreE.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Buscar por ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar por nombre";
            // 
            // lbListaEstudiantes
            // 
            this.lbListaEstudiantes.FormattingEnabled = true;
            this.lbListaEstudiantes.ItemHeight = 20;
            this.lbListaEstudiantes.Location = new System.Drawing.Point(24, 39);
            this.lbListaEstudiantes.Name = "lbListaEstudiantes";
            this.lbListaEstudiantes.Size = new System.Drawing.Size(579, 124);
            this.lbListaEstudiantes.TabIndex = 0;
            // 
            // btnBuscarI
            // 
            this.btnBuscarI.Location = new System.Drawing.Point(353, 361);
            this.btnBuscarI.Name = "btnBuscarI";
            this.btnBuscarI.Size = new System.Drawing.Size(224, 35);
            this.btnBuscarI.TabIndex = 7;
            this.btnBuscarI.Text = "Buscar por ID";
            this.btnBuscarI.UseVisualStyleBackColor = true;
            this.btnBuscarI.Click += new System.EventHandler(this.btnBuscarI_Click);
            // 
            // rtbMostrarR
            // 
            this.rtbMostrarR.Location = new System.Drawing.Point(686, 52);
            this.rtbMostrarR.Name = "rtbMostrarR";
            this.rtbMostrarR.Size = new System.Drawing.Size(346, 475);
            this.rtbMostrarR.TabIndex = 1;
            this.rtbMostrarR.Text = "";
            // 
            // FrmBusquedaOb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 556);
            this.Controls.Add(this.rtbMostrarR);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmBusquedaOb";
            this.Text = "FrmBusquedaOb";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarN;
        private System.Windows.Forms.TextBox tbIdEstudiante;
        private System.Windows.Forms.TextBox tbNombreE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbListaEstudiantes;
        private System.Windows.Forms.Button btnBuscarI;
        private System.Windows.Forms.RichTextBox rtbMostrarR;
    }
}