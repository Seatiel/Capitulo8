using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormatoAMyFM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DateTime Hora = new DateTime();

        private void Formatobutton_Click(object sender, EventArgs e)
        {
            int hora;
            String formato;
            hora = int.Parse(HoratextBox.Text);
            Hora.AddHours(hora);            
            formato = String.Format("{0:hh}", hora);
            FormatotextBox.Text = formato;
        }
    }
}
