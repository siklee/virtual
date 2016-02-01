﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace virtualKeyBoard
{
    public partial class Controler : Form
    {
        

        Setting st = new Setting();



        public Controler()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
           
            st.Hide();
            if (SetOfKey.keyBoardMode == 0)
            {
                this.BackgroundImage = global::virtualKeyBoard.Properties.Resources.greenkey;
                SetOfKey.keyBoardMode = 1;
           
            }
            else
            {
                this.BackgroundImage = global::virtualKeyBoard.Properties.Resources.redkey;
                SetOfKey.keyBoardMode = 0;
                
            }
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            st.Hide();
            if (SetOfKey.keyBoardMode == 2)
            {
                this.BackgroundImage = global::virtualKeyBoard.Properties.Resources.redkey;
                SetOfKey.keyBoardMode = 0;
            }
            else
            {
                this.BackgroundImage = global::virtualKeyBoard.Properties.Resources.settingkey;
                SetOfKey.keyBoardMode = 2;
                
                if (!st.IsAccessible)
                {
                    st.Show();
                }
            }
        }
    }
}
