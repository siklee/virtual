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
                this.ckey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
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
