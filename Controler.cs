using System;
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

        int format=0; // 0 off 1 on 2 setting
        public Controler()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (format == 0)
            {
                this.BackgroundImage = global::virtualKeyBoard.Properties.Resources.greenkey;
                format = 1;
           
            }
            else
            {
                this.BackgroundImage = global::virtualKeyBoard.Properties.Resources.redkey;
                format = 0;
            }
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            if (format == 2)
            {
                this.BackgroundImage = global::virtualKeyBoard.Properties.Resources.redkey;
                format = 0;
            }
            else
            {
                this.BackgroundImage = global::virtualKeyBoard.Properties.Resources.settingkey;
                format = 2;
            }
        }
    }
}
