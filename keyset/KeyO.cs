using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace virtualKeyBoard.KeySet
{
    public partial class KeyO : Form
    {
        private static KeyO instance;
        public KeyO()
        {
            InitializeComponent();
        }

        public static KeyO GetForm
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new KeyO();
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

        private void KeyO_Click(object sender, EventArgs e)
        {
            if (SetOfKey.keyBoardMode == 1)
            {
                SendKeys.Send("C");
                using (System.Media.SoundPlayer player = new System.Media.SoundPlayer(global::virtualKeyBoard.Properties.Resources.marine))
                {
                    player.Play();
                }
              
            }
        }

        private void KeyO_MouseUp(object sender, MouseEventArgs e)
        {
            if (SetOfKey.keyBoardMode == 2)
            {
                this.SetDesktopLocation(MousePosition.X, MousePosition.Y);
                SetOfKey sok = SetOfKey.Instance();
                sok.cpoint.setPoint(MousePosition.X, MousePosition.Y);
            }
        }
    }
}
