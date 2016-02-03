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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace virtualKeyBoard
{
    public partial class Setting : Form
    {
        KeyBoard key = new KeyBoard();
        
        public Setting()
        {
            InitializeComponent();
        }
        // 키보드 추가 (키보드 판을 불러옴 )
        private void add_Click(object sender, EventArgs e)
        {
            if (SetOfKey.isKeyBoardOpen == false)
            {
                key.Show();
                SetOfKey.isKeyBoardOpen = true;
            }
            else
            {
                key.Hide();
                SetOfKey.isKeyBoardOpen = false;
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
            
            for (int i = 0; i < 70; i++)
            {
                IFormatter formatter = new BinaryFormatter();
                string fileName = "keySetting" + i + ".bin";
                Stream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, inKey.keyValue[i].infomation);
                stream.Close();
            }
        }


        //키보드 상태를 불러옴    저장된 키보드를 불러와야된다 위치 onoff여부 등
        private void button3_Click(object sender, EventArgs e)
        {
            SetOfKey outKey = SetOfKey.Instance();
            for (int i = 0; i < 70; i++)
            {
                IFormatter formatter = new BinaryFormatter();
                string fileName = "keySetting" + i + ".bin";
                Stream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                outKey.keyValue[i].infomation = (Keyinfo)formatter.Deserialize(stream);
                stream.Close();

                if (outKey.keyValue[i].infomation.isKeyOpen == true)
                {
                    outKey.keyValue[i].Show();
                    outKey.keyValue[i].SetDesktopLocation(outKey.keyValue[i].infomation.locationX, outKey.keyValue[i].infomation.locationY);
                }
            }
        }   
    }
}
