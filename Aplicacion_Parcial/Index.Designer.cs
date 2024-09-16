namespace Aplicacion_Parcial
{
    partial class Index
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
            this.newtonRapson = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FalsaPosicion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newtonRapson
            // 
            this.newtonRapson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newtonRapson.Location = new System.Drawing.Point(158, 237);
            this.newtonRapson.Name = "newtonRapson";
            this.newtonRapson.Size = new System.Drawing.Size(210, 43);
            this.newtonRapson.TabIndex = 0;
            this.newtonRapson.Text = "Metodo Newton Rapson";
            this.newtonRapson.UseVisualStyleBackColor = true;
            this.newtonRapson.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "BIENVENIDO AL PROGRAMA";
            // 
            // FalsaPosicion
            // 
            this.FalsaPosicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FalsaPosicion.Location = new System.Drawing.Point(429, 237);
            this.FalsaPosicion.Name = "FalsaPosicion";
            this.FalsaPosicion.Size = new System.Drawing.Size(209, 43);
            this.FalsaPosicion.TabIndex = 2;
            this.FalsaPosicion.Text = "Metodo Falsa Posicion";
            this.FalsaPosicion.UseVisualStyleBackColor = true;
            this.FalsaPosicion.Click += new System.EventHandler(this.FalsaPosicion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yael Adonay Matamoros Guzman";
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 490);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FalsaPosicion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newtonRapson);
            this.Name = "Index";
            this.Text = "Bienvenido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newtonRapson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FalsaPosicion;
        private System.Windows.Forms.Label label2;
    }
}

