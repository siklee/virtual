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
        private static KeyC instance;
        public KeyC()
        {
            InitializeComponent();
        }

        public static KeyC GetForm
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new KeyC();
                return instance;
            }
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
            if (SetOfKey.keyBoardMode == 1)
            {
                SendKeys.Send("C");
            }
            else
            {

            }
        }

        private void KeyC_MouseUp(object sender, MouseEventArgs e)
        {
            this.SetDesktopLocation(MousePosition.X, MousePosition.Y);
            SetOfKey sok = SetOfKey.Instance();
            sok.cpoint.setPoint(MousePosition.X, MousePosition.Y);
        }
    }
}
