namespace Aplicacion_Parcial
{
    partial class Falsa_Posicion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Falsa_Posicion));
            this.tablaDatos = new System.Windows.Forms.DataGridView();
            this.iteracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fDeA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fDeB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fDeXr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fDeAporFdeB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inputError = new System.Windows.Forms.TextBox();
            this.inputB = new System.Windows.Forms.TextBox();
            this.inputA = new System.Windows.Forms.TextBox();
            this.inputPolinomio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.botonCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaDatos
            // 
            this.tablaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iteracion,
            this.a,
            this.b,
            this.fDeA,
            this.fDeB,
            this.Xr,
            this.fDeXr,
            this.fDeAporFdeB,
            this.error});
            this.tablaDatos.Location = new System.Drawing.Point(285, 304);
            this.tablaDatos.Name = "tablaDatos";
            this.tablaDatos.Size = new System.Drawing.Size(998, 199);
            this.tablaDatos.TabIndex = 27;
            // 
            // iteracion
            // 
            this.iteracion.HeaderText = "i";
            this.iteracion.Name = "iteracion";
            // 
            // a
            // 
            this.a.HeaderText = "a";
            this.a.Name = "a";
            // 
            // b
            // 
            this.b.HeaderText = "b";
            this.b.Name = "b";
            // 
            // fDeA
            // 
            this.fDeA.HeaderText = "F(A)";
            this.fDeA.Name = "fDeA";
            // 
            // fDeB
            // 
            this.fDeB.HeaderText = "f(b)";
            this.fDeB.Name = "fDeB";
            // 
            // Xr
            // 
            this.Xr.HeaderText = "xr";
            this.Xr.Name = "Xr";
            // 
            // fDeXr
            // 
            this.fDeXr.HeaderText = "f(xr)";
            this.fDeXr.Name = "fDeXr";
            // 
            // fDeAporFdeB
            // 
            this.fDeAporFdeB.HeaderText = "f(a) * f(xr)";
            this.fDeAporFdeB.Name = "fDeAporFdeB";
            // 
            // error
            // 
            this.error.HeaderText = "e";
            this.error.Name = "error";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(223, 413);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "e%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(148, 413);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "b";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "a";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Escribir";
            // 
            // inputError
            // 
            this.inputError.Location = new System.Drawing.Point(208, 429);
            this.inputError.Name = "inputError";
            this.inputError.Size = new System.Drawing.Size(53, 20);
            this.inputError.TabIndex = 22;
            // 
            // inputB
            // 
            this.inputB.Location = new System.Drawing.Point(113, 429);
            this.inputB.Name = "inputB";
            this.inputB.Size = new System.Drawing.Size(89, 20);
            this.inputB.TabIndex = 21;
            // 
            // inputA
            // 
            this.inputA.Location = new System.Drawing.Point(31, 429);
            this.inputA.Name = "inputA";
            this.inputA.Size = new System.Drawing.Size(76, 20);
            this.inputA.TabIndex = 20;
            // 
            // inputPolinomio
            // 
            this.inputPolinomio.Location = new System.Drawing.Point(71, 356);
            this.inputPolinomio.Name = "inputPolinomio";
            this.inputPolinomio.Size = new System.Drawing.Size(173, 20);
            this.inputPolinomio.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Escribir Polinomio a Usar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(426, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(531, 108);
            this.label3.TabIndex = 17;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(693, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "A continuación algunas de las reglas que hay que tener en cuenta para poder digit" +
    "ar el polinomio:\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(504, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "METODO FALSA POSICION";
            // 
            // botonCalcular
            // 
            this.botonCalcular.Location = new System.Drawing.Point(80, 502);
            this.botonCalcular.Name = "botonCalcular";
            this.botonCalcular.Size = new System.Drawing.Size(146, 44);
            this.botonCalcular.TabIndex = 14;
            this.botonCalcular.Text = "Calcular";
            this.botonCalcular.UseVisualStyleBackColor = true;
            this.botonCalcular.Click += new System.EventHandler(this.botonCalcular_Click);
            // 
            // Falsa_Posicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 574);
            this.Controls.Add(this.tablaDatos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inputError);
            this.Controls.Add(this.inputB);
            this.Controls.Add(this.inputA);
            this.Controls.Add(this.inputPolinomio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonCalcular);
            this.Name = "Falsa_Posicion";
            this.Text = "FalsaPosicion";
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn iteracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn a;
        private System.Windows.Forms.DataGridViewTextBoxColumn b;
        private System.Windows.Forms.DataGridViewTextBoxColumn fDeA;
        private System.Windows.Forms.DataGridViewTextBoxColumn fDeB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xr;
        private System.Windows.Forms.DataGridViewTextBoxColumn fDeXr;
        private System.Windows.Forms.DataGridViewTextBoxColumn fDeAporFdeB;
        private System.Windows.Forms.DataGridViewTextBoxColumn error;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputError;
        private System.Windows.Forms.TextBox inputB;
        private System.Windows.Forms.TextBox inputA;
        private System.Windows.Forms.TextBox inputPolinomio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonCalcular;
    }
}