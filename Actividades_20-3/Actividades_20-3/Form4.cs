using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividades_20_3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            int N1, N2, N3, NF;

            N1 = int.Parse(txtNota1.Text);
            N2= int.Parse(txtNota2.Text);
            N3 = int.Parse(txtNota3.Text);

            NF = (N1 + N2 + N3) / 3;

            lblPromedio.Text = NF.ToString();
        }
    }
}
