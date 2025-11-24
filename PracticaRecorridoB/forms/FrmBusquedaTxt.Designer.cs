namespace PracticaRecorridoB.forms
{
    partial class FrmBusquedaTxt
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
            this.tbnTexto = new System.Windows.Forms.TextBox();
            this.btnContarL = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAgregarP = new System.Windows.Forms.Button();
            this.tbParrafo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbnTexto);
            this.groupBox1.Controls.Add(this.btnContarL);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 313);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Palabra";
            // 
            // tbnTexto
            // 
            this.tbnTexto.Location = new System.Drawing.Point(6, 119);
            this.tbnTexto.Name = "tbnTexto";
            this.tbnTexto.Size = new System.Drawing.Size(504, 26);
            this.tbnTexto.TabIndex = 2;
            // 
            // btnContarL
            // 
            this.btnContarL.Location = new System.Drawing.Point(195, 179);
            this.btnContarL.Name = "btnContarL";
            this.btnContarL.Size = new System.Drawing.Size(180, 42);
            this.btnContarL.TabIndex = 1;
            this.btnContarL.Text = "Buscar";
            this.btnContarL.UseVisualStyleBackColor = true;
            this.btnContarL.Click += new System.EventHandler(this.btnContarL_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escribe la palabra a buscar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnAgregarP);
            this.groupBox2.Controls.Add(this.tbParrafo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(556, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 313);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Párrafo";
            // 
            // btnAgregarP
            // 
            this.btnAgregarP.Location = new System.Drawing.Point(128, 179);
            this.btnAgregarP.Name = "btnAgregarP";
            this.btnAgregarP.Size = new System.Drawing.Size(180, 42);
            this.btnAgregarP.TabIndex = 2;
            this.btnAgregarP.Text = "Buscar";
            this.btnAgregarP.UseVisualStyleBackColor = true;
            // 
            // tbParrafo
            // 
            this.tbParrafo.Location = new System.Drawing.Point(6, 119);
            this.tbParrafo.MaxLength = 100;
            this.tbParrafo.Name = "tbParrafo";
            this.tbParrafo.Size = new System.Drawing.Size(442, 26);
            this.tbParrafo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Escribe un párrafo en donde se hara la busqueda";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(287, 361);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(465, 141);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "tiene un maximo de 100 palabras";
            // 
            // FrmBusquedaTxt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 566);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmBusquedaTxt";
            this.Text = "FrmBusquedaTxt";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnContarL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbnTexto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbParrafo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregarP;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
    }
}