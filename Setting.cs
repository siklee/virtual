using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (isKeyBoardOpen==false)
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
    }
}
