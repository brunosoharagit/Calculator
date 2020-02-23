using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculator : Form
    {
        Calcs c = new Calcs();

        public frmCalculator()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            double value1 = double.Parse(txbNum1.Text);
            double value2 = double.Parse(txbNum2.Text);

            double value3 = c.Sum(value1, value2);

            txbResult.Text = value3.ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            double value1 = double.Parse(txbNum1.Text);
            double value2 = double.Parse(txbNum2.Text);

            double value3 = c.Sub(value1, value2);

            txbResult.Text = value3.ToString();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            double value1 = double.Parse(txbNum1.Text);
            double value2 = double.Parse(txbNum2.Text);

            double value3 = c.Mul(value1, value2);

            txbResult.Text = txbResult.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double value1 = double.Parse(txbNum1.Text);
            double value2 = double.Parse(txbNum2.Text);

            double value3 = c.Div(value1, value2);

            txbResult.Text = value3.ToString();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txbNum1.Text = "";
            txbNum2.Text = "";
            txbResult.Text = "";
        }
    }
}
