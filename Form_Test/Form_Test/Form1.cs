using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Form_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Test_Button test_Button = new Test_Button();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {

                    test_Button.Location = new Point(50 * i, 50 * j);
                    test_Button.Size = new Size(50, 50);
                    test_Button.Text = "あいうえお";
                    Controls.Add(test_Button);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("joe");
        }
    }
}
