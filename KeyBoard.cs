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

       
        // 키보드 클릭 이벤트 

            

        private void ESC_Click(object sender, EventArgs e)
        {
            SetOfKey info = SetOfKey.Instance();
            if(info.keyInformation[0].isKeyOpen==true)
            {
                info.keyInformation[0].Key.Hide();
                this.ESC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                info.keyInformation[0].isKeyOpen = false;
            }
            else
            {
                info.keyInformation[0].Key.Show();
                this.ESC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
                info.keyInformation[0].isKeyOpen = true;
            }
        }
    }
}
