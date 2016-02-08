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
        public Keyinfo infomation = new Keyinfo();
        public string key;
        public string outputkey;


        public TestKey(string key,string outputkey)
        {
            this.key = key;
            this.outputkey = outputkey;
            InitializeComponent();
            this.label1.Text = outputkey;
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
                infomation.locationX = MousePosition.X;
                infomation.locationY = MousePosition.Y;
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
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

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            if (SetOfKey.keyBoardMode == 2)
            {
                this.SetDesktopLocation(MousePosition.X, MousePosition.Y);
                infomation.locationX = MousePosition.X;
                infomation.locationY = MousePosition.Y;

            }
        }
    }

    [Serializable]
    public class Keyinfo
    {
        public bool isKeyOpen;
        public int locationX;
        public int locationY;




        public Keyinfo()
        {
            isKeyOpen = false;
            locationX = 100;
            locationY = 100;
        }

    }
}
