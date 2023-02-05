using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer4._4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 15;
            num = num + 10;
            num = 12 - (42 / 7);
            num++;
            num *= 3;

            int cont = 0;
            cont++;
            cont--;

            string result = "Hola";
            result += " otra vez" + result;
            MessageBox.Show(result);
            result = "The value is: " + cont;
            result = "";

            bool yesNo = false;
            bool anotherBool = true;
            yesNo = !anotherBool;
        }
    }
}
