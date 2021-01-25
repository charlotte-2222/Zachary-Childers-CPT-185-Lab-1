using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Zachary_Childers_CPT_185_Lab_1
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void extBt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void compBut_Click(object sender, EventArgs e)
        {
            //using (TextWriter txt = new StreamWriter("C:\\receipts\\CustomerReceipt.txt"))
            //{
            //    txt.Write(textBox1.Text);
            //    txt.Close();
            //}
            Close();

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
