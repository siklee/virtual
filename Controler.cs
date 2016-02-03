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
    public partial class Controler : Form
    {

        Setting st = new Setting();
        SetOfKey sof = SetOfKey.Instance();

        public Controler()
        {
            InitializeComponent();
        }

        // 컨트롤 클릭시 조작  on / off 조작 
        private void Form1_Click(object sender, EventArgs e)
        {
     
            st.Hide();
            if (SetOfKey.keyBoardMode == 0)
            {
                this.BackgroundImage = global::virtualKeyBoard.Properties.Resources.greenkey;
                SetOfKey.keyBoardMode = 1;
                for (int i = 0; i < 70; i++)
                {
                    if (sof.keyValue[i].infomation.isKeyOpen == true)
                    {
                        sof.keyValue[i].Show();
                    }
                }

            }
            else
            {
                this.BackgroundImage = global::virtualKeyBoard.Properties.Resources.redkey;
                SetOfKey.keyBoardMode = 0;
                for (int i = 0; i < 70; i++)
                {
                    sof.keyValue[i].Hide();
                }
            }
        }


        //  컨트롤 더블 클릭시 조작 setting/ off 조작 
        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            st.Hide();
            if (SetOfKey.keyBoardMode == 2)
            {
                this.BackgroundImage = global::virtualKeyBoard.Properties.Resources.redkey;
                SetOfKey.keyBoardMode = 0;
            }
            else
            {
                this.BackgroundImage = global::virtualKeyBoard.Properties.Resources.settingkey;
                SetOfKey.keyBoardMode = 2;
                
                if (!st.IsAccessible)
                {
                    st.Show();         // 설정창 출력
                }
                for (int i = 0; i < 70; i++)
                {
                    if (sof.keyValue[i].infomation.isKeyOpen == true)
                    {
                        sof.keyValue[i].Show();
                    }
                }
            }
        }
    }
}
