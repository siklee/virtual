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
    public partial class KeySpace : Form
    {
        private static KeySpace instance;
        public KeySpace()
        {
            InitializeComponent();
        }

        public static KeySpace GetForm
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new KeySpace();
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

        private void KeySpace_Click(object sender, EventArgs e)
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

        private void KeySpace_MouseUp(object sender, MouseEventArgs e)
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
