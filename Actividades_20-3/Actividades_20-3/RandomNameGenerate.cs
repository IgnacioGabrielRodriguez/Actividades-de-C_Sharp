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
    public partial class RandomNameGenerate : Form
    {
        public RandomNameGenerate()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string[] priParte = { "For", "Mos", "Gir", "Ne" };
            string[] segParte = { "un", "a", "on" };
            string[] terParte = { "lan", "id", "th", "ed" };

            Random rnd = new Random();

            lblName.Text = priParte[rnd.Next(0, 4)] + segParte[rnd.Next(0, 3)] + terParte[rnd.Next(0, 4)];
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblName.Text);
        }
    }
}
