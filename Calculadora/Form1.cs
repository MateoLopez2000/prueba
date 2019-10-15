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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private double raiz (  long val)
        {
            double result2 = 0;
            result2 = Math.Sqrt(val);
            return result2;
        }
        private long suma(long a , long b )
        {
            long result = 0;
            result = a + b;
            return result;
        }
    }
}
