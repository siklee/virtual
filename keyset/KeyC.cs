using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace virtualKeyBoard.KeySet
{
    public partial class KeyC : Form
    {
        public KeyC()
        {
            InitializeComponent();
        }


        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                param.ExStyle |= 0x08000000;
                return param;
            }
        }
    
        private void KeyC_Click(object sender, EventArgs e)
        {
            SendKeys.Send("C");
        }

        private void KeyC_MouseUp(object sender, MouseEventArgs e)
        {
            this.SetDesktopLocation(MousePosition.X, MousePosition.Y);
        }
    }
}
