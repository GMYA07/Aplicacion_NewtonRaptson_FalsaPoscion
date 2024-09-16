namespace Aplicacion_Parcial
{
    partial class Newton_Rapson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Newton_Rapson));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tablaDatos = new System.Windows.Forms.DataGridView();
            this.iteracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fxi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fxiD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputPolinomio = new System.Windows.Forms.TextBox();
            this.inputDerivada = new System.Windows.Forms.TextBox();
            this.inputX0 = new System.Windows.Forms.TextBox();
            this.inputError = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(719, 128);
            this.label3.TabIndex = 20;
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(693, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "A continuación algunas de las reglas que hay que tener en cuenta para poder digit" +
    "ar el polinomio:\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "METODO NEWTON RAPSON";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tablaDatos
            // 
            this.tablaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iteracion,
            this.x,
            this.fxi,
            this.fxiD,
            this.error});
            this.tablaDatos.Location = new System.Drawing.Point(337, 268);
            this.tablaDatos.Name = "tablaDatos";
            this.tablaDatos.Size = new System.Drawing.Size(575, 285);
            this.tablaDatos.TabIndex = 21;
            // 
            // iteracion
            // 
            this.iteracion.HeaderText = "i";
            this.iteracion.Name = "iteracion";
            // 
            // x
            // 
            this.x.HeaderText = "x";
            this.x.Name = "x";
            // 
            // fxi
            // 
            this.fxi.HeaderText = "f(xi)";
            this.fxi.Name = "fxi";
            // 
            // fxiD
            // 
            this.fxiD.HeaderText = "f(xi)\'";
            this.fxiD.Name = "fxiD";
            // 
            // error
            // 
            this.error.HeaderText = "e%";
            this.error.Name = "error";
            // 
            // inputPolinomio
            // 
            this.inputPolinomio.Location = new System.Drawing.Point(63, 321);
            this.inputPolinomio.Name = "inputPolinomio";
            this.inputPolinomio.Size = new System.Drawing.Size(200, 20);
            this.inputPolinomio.TabIndex = 22;
            // 
            // inputDerivada
            // 
            this.inputDerivada.Location = new System.Drawing.Point(63, 372);
            this.inputDerivada.Name = "inputDerivada";
            this.inputDerivada.Size = new System.Drawing.Size(196, 20);
            this.inputDerivada.TabIndex = 23;
            // 
            // inputX0
            // 
            this.inputX0.Location = new System.Drawing.Point(63, 425);
            this.inputX0.Name = "inputX0";
            this.inputX0.Size = new System.Drawing.Size(196, 20);
            this.inputX0.TabIndex = 24;
            // 
            // inputError
            // 
            this.inputError.Location = new System.Drawing.Point(63, 473);
            this.inputError.Name = "inputError";
            this.inputError.Size = new System.Drawing.Size(196, 20);
            this.inputError.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Digitar Polinomio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Digitar el polinomio en su forma derivada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Digitar X0 (x sub 0)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 457);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Digitar Margen de error";
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(77, 532);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(160, 31);
            this.buttonCalcular.TabIndex = 30;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // Newton_Rapson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 624);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputError);
            this.Controls.Add(this.inputX0);
            this.Controls.Add(this.inputDerivada);
            this.Controls.Add(this.inputPolinomio);
            this.Controls.Add(this.tablaDatos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Newton_Rapson";
            this.Text = "Newton_Rapson";
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tablaDatos;
        private System.Windows.Forms.TextBox inputPolinomio;
        private System.Windows.Forms.TextBox inputDerivada;
        private System.Windows.Forms.TextBox inputX0;
        private System.Windows.Forms.TextBox inputError;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.DataGridViewTextBoxColumn iteracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn fxi;
        private System.Windows.Forms.DataGridViewTextBoxColumn fxiD;
        private System.Windows.Forms.DataGridViewTextBoxColumn error;
    }
}