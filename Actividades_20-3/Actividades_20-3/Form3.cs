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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            float v, t, D;

            v = float.Parse(txtVel.Text);
            t = float.Parse(txtTime.Text);

            D = v * t;


            lblDistancia.Text = D.ToString();
        }
    }
}
