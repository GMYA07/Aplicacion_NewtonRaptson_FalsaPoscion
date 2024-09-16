using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_Parcial
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Newton_Rapson newForm = new Newton_Rapson();
            newForm.FormClosed += (s, args) => this.Show(); // Mostrar Index cuando se cierre Newton_Rapson
            newForm.Show(); // Muestra Newton_Rapson
            this.Hide(); // Oculta Index
        }

        private void FalsaPosicion_Click(object sender, EventArgs e)
        {
            Falsa_Posicion newForm = new Falsa_Posicion();
            newForm.FormClosed += (s, args) => this.Show(); // Mostrar Index cuando se cierre Falsa_Posicion
            newForm.Show(); // Muestra Falsa_Posicion
            this.Hide(); // Oculta Index
        }
    }
}
