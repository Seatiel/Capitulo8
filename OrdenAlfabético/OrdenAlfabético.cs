using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OrdenAlfabético
{
    public partial class OrdenAlfabético : Form
    {
        public OrdenAlfabético()
        {
            InitializeComponent();
        }

        private void Ordenarbutton_Click(object sender, EventArgs e)
        {
            String cadena;
            cadena = CadenatextBox.Text;
            Char[] Ordenar = cadena.ToCharArray();
            Array.Sort(Ordenar);
            cadena = new string(Ordenar);
            OrdenCadenatextBox.Text = cadena.ToString();
        }
    }
}
