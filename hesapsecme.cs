using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Box
{
    public partial class hesapsecme : Form
    {
        public hesapsecme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
                checkBox2.Visible = false;
                checkBox3.Visible = false;
            }
            else if (checkBox2.Checked == true)
            {
                checkBox1.Visible = false;
                checkBox3.Visible = false;

            }
            else if (checkBox3.Checked == true)
            {
                checkBox2.Visible = false;
                checkBox1.Visible = false;

            }
        }
    }
}
