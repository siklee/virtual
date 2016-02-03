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
    
    public partial class TestKey : Form
    {
        public string key;
        public int locationX;
        public int locationY;
        

        public TestKey(string key)
        {
            this.key = key;
            InitializeComponent();
        }
        public TestKey()
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

        private void TestKey_Click(object sender, EventArgs e)
        {
            if (SetOfKey.keyBoardMode == 1)
            {
                SendKeys.Send(key);
                using (System.Media.SoundPlayer player = new System.Media.SoundPlayer(global::virtualKeyBoard.Properties.Resources.marine))
                {
                    player.Play();
                }
              
            }
        }

        private void TestKey_MouseUp(object sender, MouseEventArgs e)
        {
            if (SetOfKey.keyBoardMode == 2)
            {
                this.SetDesktopLocation(MousePosition.X, MousePosition.Y);
                locationX = MousePosition.X;
                locationY = MousePosition.Y;
            }
        }
    }
}
