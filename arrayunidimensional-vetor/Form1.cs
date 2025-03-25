using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arrayunidimensional_vetor
{
    public partial class frmVetor : Form
    {
        public frmVetor()
        {
            InitializeComponent();
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            //Matriz de uma dimensão, também chamado de vetor
            string[] pescasComputador = { "Mouse", "Teclado", "Monitor", "Gabinete", "Câmera" };

            // MessageBox.Show(pescasComputador[2]);

            foreach (string peca in pescasComputador)
                MessageBox.Show(peca);
        }
    }
}
