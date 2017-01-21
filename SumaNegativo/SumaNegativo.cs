using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SumaNegativo
{
    public partial class SumaNegativo : Form
    {
        public SumaNegativo()
        {
            InitializeComponent();
        }

        private void Calcularbutton_Click(object sender, EventArgs e)
        {
            int num1, num2, Resultado;  
            num1 = Convert.ToInt32(PrimerNumerotextBox.Text);
            num2 = Convert.ToInt32(SegundoNumerotextBox.Text);
            Resultado = num1 + num2;
            if (Resultado > 0)
                ResultadotextBox.Text = Convert.ToString(Resultado);
            
            if (Resultado < 0)            
                ResultadotextBox.Text = '(' + Convert.ToString(Resultado) + ')';          
        }
    }
}
