using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace treino1
{
    public partial class frmMaiorMenor : Form
    {
        public frmMaiorMenor()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtMaiorMenor.Text, out int numero))
            {
                if (numero >= 10)
                {
                    MessageBox.Show("O número é maior ou igual a 10", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                }

                else if (numero < 10)
                {
                    MessageBox.Show("O número é menor que 10", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                

            }
            else
            {
                MessageBox.Show("Erro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
