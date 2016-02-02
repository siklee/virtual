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
        // 키보드 추가 (키보드 판을 불러옴 )
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

        // 프로그램을 종료 시킴 
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


     
        //키보드 상태를 저장함 
        private void button2_Click(object sender, EventArgs e)
        {
            SetOfKey inKey = SetOfKey.Instance();
            inKey.serializeKeySetting();
        }


        //키보드 상태를 불러옴    *****문제1 *****
        private void button3_Click(object sender, EventArgs e)
        {
            SetOfKey outKey = SetOfKey.Instance();
            outKey.deSerializeKeySetting();

            if (outKey.isCkeyOpen == true)
            {
                KeyC.GetForm.Show();
                KeyC.GetForm.SetDesktopLocation(outKey.cpoint.locationX, outKey.cpoint.locationY);
            }
        }   
    }
}
