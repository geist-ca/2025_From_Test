using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Test
{
    internal class Test_Button :Button
    {
        private Color _Oncolor=Color.White;
        private Color _Offcolor=Color.Red;

        public void SetEnable(bool on)
            {
            if (on)
            {
                BackColor = _Oncolor;

            }
            else
            {
                BackColor = _Offcolor;
            }
            }
        public Test_Button(Point position,Size size,string text) 
        {
        Location= position;
        Size = size;
        Text = text;


            Click += button1_Click;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("joe");
        }





    }
}
