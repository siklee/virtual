using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using virtualKeyBoard.KeySet;

namespace virtualKeyBoard
{
    public partial class Setting : Form
    {

        KeyBoard key = new KeyBoard();

        bool isKeyBoardOpen = false;
        public Setting()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (isKeyBoardOpen == false)
            {
                key.Show();
                isKeyBoardOpen = true;
            }
            else
            {
                key.Hide();
                isKeyBoardOpen = false;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


     

        private void button2_Click(object sender, EventArgs e)
        {
            IOSetOfKey inkey = new IOSetOfKey();
            inkey.serializeKeySetting();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IOSetOfKey outkey = new IOSetOfKey();
            outkey.deSerializeKeySetting();

            if (SetOfKey.isCkeyOpen == true)
            {
                KeyC kc = new KeyC();
                kc.Show();
            }
        }   
    }
}
