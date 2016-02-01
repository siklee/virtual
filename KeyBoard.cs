using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using virtualKeyBoard.KeySet;


namespace virtualKeyBoard
{
    public partial class KeyBoard : Form
    {

        KeyC kc = new KeyC();
        public KeyBoard()
        {
            InitializeComponent();
        }

       

        private void ckey_Click(object sender, EventArgs e)
        {
            if (SetOfKey.isCkeyOpen == true )
            {
                kc.Hide();
                this.ckey.BackColor = System.Drawing.Color.White;
                SetOfKey.isCkeyOpen = false;
            }
            else
            {
                kc.Show();
                this.ckey.BackColor = System.Drawing.Color.Pink;
                SetOfKey.isCkeyOpen = true;
            }
        }
    }
}
