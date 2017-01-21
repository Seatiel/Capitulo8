using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Capitulo8
{
    public partial class Cadena : Form
    {
        public Cadena()
        {
            InitializeComponent();
        }

        private void Oracionbutton_Click(object sender, EventArgs e)
        {
            String oracion;
            String[] list;
            int x = 0;

            oracion = OraciontextBox.Text;
            char[] limitadores = { ' ', ' ', ' ', ' ' };

            list = oracion.Split(limitadores);

            for (x = 0; x < list.Length; x++)
            {

                listBox.Items.Add(list[x]);
            }
        }
    }
}
