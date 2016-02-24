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
using System.Runtime.InteropServices;
using System.Threading;

namespace virtualKeyBoard.KeySet
{
    
    public partial class TestKey : Form
    {
        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

        public Keyinfo infomation = new Keyinfo();
        public byte key;
        public string outputkey;
        public bool keyOn;


        public TestKey(byte key,string outputkey)
        {
            this.key = key;
            this.outputkey = outputkey;
            InitializeComponent();
            this.label1.Text = outputkey;
            this.keyOn = false;
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
            /*
            if (SetOfKey.keyBoardMode == 1)
            {
                if(key == (byte)Keys.ShiftKey || key == (byte)Keys.Menu || key == (byte)Keys.ControlKey)
                {
                    if(keyOn == true)
                    {
                        keybd_event(key, 0, 0x02, 0);
                        keyOn = false;
                        this.BackColor= System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
                    }
                    else if(keyOn == false)
                    {
                        keybd_event(key, 0, 0, 0);
                        keyOn = true;
                        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
                    }
                }
                else
                {
                    keybd_event(key, 0, 0, 0);
                    Thread.Sleep(100);
                    keybd_event(key, 0, 0x02, 0);
                }
                
                using (System.Media.SoundPlayer player = new System.Media.SoundPlayer(global::virtualKeyBoard.Properties.Resources.marine))
                {
                    player.Play();
                }
              
            }
            */
        }

   
        private void label1_Click(object sender, EventArgs e)
        {
            /*
            if (SetOfKey.keyBoardMode == 1)
            {
                if (key == (byte)Keys.ShiftKey || key == (byte)Keys.Menu || key == (byte)Keys.ControlKey)
                {
                    if (keyOn == true)
                    {
                        keybd_event(key, 0, 0x02, 0);
                        keyOn = false;
                        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
                    }
                    else if (keyOn == false)
                    {
                        keybd_event(key, 0, 0, 0);
                        keyOn = true;
                        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
                    }
                }
                else
                {
                    keybd_event(key, 0, 0, 0);
                    Thread.Sleep(100);
                    keybd_event(key, 0, 0x02, 0);
                }
                using (System.Media.SoundPlayer player = new System.Media.SoundPlayer(global::virtualKeyBoard.Properties.Resources.marine))
                {
                    player.Play();
                }
                

            }
            */
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {

            if (SetOfKey.keyBoardMode == 1)
            {
                keybd_event(key, 0, 0x02, 0);
                this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            }
            else if (SetOfKey.keyBoardMode == 2)
            {
                this.SetDesktopLocation(MousePosition.X, MousePosition.Y);
                infomation.locationX = MousePosition.X;
                infomation.locationY = MousePosition.Y;

            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (SetOfKey.keyBoardMode == 1)
            {
                keybd_event(key, 0, 0, 0);
                this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            }
        }

        private void TestKey_MouseUp(object sender, MouseEventArgs e)
        {
            if (SetOfKey.keyBoardMode == 1)
            {
                keybd_event(key, 0, 0x02, 0);
                this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            }
            else if (SetOfKey.keyBoardMode == 2)
            {
                this.SetDesktopLocation(MousePosition.X, MousePosition.Y);
                infomation.locationX = MousePosition.X;
                infomation.locationY = MousePosition.Y;

            }
        }

        private void TestKey_MouseDown(object sender, MouseEventArgs e)
        {
            if (SetOfKey.keyBoardMode == 1)
            {
                keybd_event(key, 0, 0, 0);
                this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
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
