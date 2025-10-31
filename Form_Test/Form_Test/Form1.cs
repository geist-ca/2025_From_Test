﻿using System;
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
        const int BUTTON_SIZE_X = 100;
        const int BUTTON_SIZE_Y = 100;

        const int BOARD_SIZE_X = 3;
        const int BOARD_SIZE_Y = 3;

        private Test_Button[,]_buttonArray;

        public Form1()
        {
            InitializeComponent();
            _buttonArray = new Test_Button[BOARD_SIZE_Y, BOARD_SIZE_X];
            for (int i = 0; i < BOARD_SIZE_X; i++)
            {
                for (int j = 0; j < BOARD_SIZE_Y; j++)
                {
                    Test_Button testButton = new Test_Button(new Point(BUTTON_SIZE_X * i, BUTTON_SIZE_Y * j),
                        new Size(BUTTON_SIZE_X, BUTTON_SIZE_Y),"");

                    _buttonArray[j,i]=testButton;

                    Controls.Add(testButton);


                  

                }
            }
            _buttonArray[1,0].SetEnable(true);
        }

      
    }
}
