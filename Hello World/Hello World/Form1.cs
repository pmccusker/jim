using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_World
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = int.Parse(textBox1.Text);
            TestLogic oLogic = new TestLogic();
            int iResult = oLogic.go(i);


            MessageBox.Show(iResult.ToString());
        }
    }
}
