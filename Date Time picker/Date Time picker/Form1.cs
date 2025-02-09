using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Date_Time_picker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = dt.Value.ToString();
            label2.Text = dt.Value.ToShortDateString();
            label3.Text = dt.Value.ToLongDateString();
            label4.Text = dt.Value.ToShortTimeString();
            label5.Text = dt.Value.ToLongTimeString();
        }
    }
}
