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
            SetOfKey ck = SetOfKey.Instance();
            if (ck.isCkeyOpen == true )
            {
                KeyC.GetForm.Hide();
                this.ckey.BackColor = System.Drawing.Color.White;
                ck.isCkeyOpen = false;
            }
            else
            {
                KeyC.GetForm.Show();
                this.ckey.BackColor = System.Drawing.Color.Pink;
                ck.isCkeyOpen = true;
            }
        }
    }
}
