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
    }
}
