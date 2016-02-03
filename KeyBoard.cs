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

        SetOfKey info = SetOfKey.Instance();

        public KeyBoard()
        {
            InitializeComponent();
        }

       
        // 키보드 클릭 이벤트 

            

        private void ESC_Click(object sender, EventArgs e)
        {
            if(info.keyInformation[0].isKeyOpen==true)
            {
                info.keyValue[0].Hide();
                this.ESC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                info.keyInformation[0].isKeyOpen = false;
            }
            else
            {
                info.keyValue[0].Show();
                this.ESC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
                info.keyInformation[0].isKeyOpen = true;
            }
        }

        private void f1key_Click(object sender, EventArgs e)
        {
            popUpKey(1,f1key);
        }

        private void f2key_Click(object sender, EventArgs e)
        {
            popUpKey(2, f2key);
        }

        private void f3key_Click(object sender, EventArgs e)
        {
            popUpKey(3,f3key);
        }

        private void f4key_Click(object sender, EventArgs e)
        {
            popUpKey(4,f4key);
        }
        private void f5key_Click(object sender, EventArgs e)
        {
            popUpKey(5, f5key);
        }

        private void f6key_Click(object sender, EventArgs e)
        {
            popUpKey(6, f6key);
        }
        private void f7key_Click(object sender, EventArgs e)
        {
            popUpKey(7,f7key);
        }

        private void f8key_Click(object sender, EventArgs e)
        {
            popUpKey(8,f8key);
        }

        private void f9key_Click(object sender, EventArgs e)
        {
            popUpKey(9,f9key);
        }

        private void f10key_Click(object sender, EventArgs e)
        {
            popUpKey(10,f10key);
        }

        private void f11key_Click(object sender, EventArgs e)
        {
            popUpKey(11,f11key);
        }

        private void f12key_Click(object sender, EventArgs e)
        {
            popUpKey(12,f12key);
        }

        private void button43_Click(object sender, EventArgs e)
        {
          
        }


        private void linekey_Click(object sender, EventArgs e)
        {
            popUpKey(13,linekey);
        }

        private void onekey_Click(object sender, EventArgs e)
        {
            popUpKey(14,onekey);
        }

        private void twokey_Click(object sender, EventArgs e)
        {
            popUpKey(15,twokey);
        }

        private void threekey_Click(object sender, EventArgs e)
        {
            popUpKey(16,threekey);
        }

        private void fourkey_Click(object sender, EventArgs e)
        {
            popUpKey(17,fourkey);
        }

        private void fivekey_Click(object sender, EventArgs e)
        {
            popUpKey(18,fivekey);
        }

        private void sixkey_Click(object sender, EventArgs e)
        {
            popUpKey(19,sixkey);
        }

        private void sevenkey_Click(object sender, EventArgs e)
        {
            popUpKey(20,sevenkey);
        }

        private void eightkey_Click(object sender, EventArgs e)
        {
            popUpKey(21,eightkey);
        }

        private void ninekey_Click(object sender, EventArgs e)
        {
            popUpKey(22,ninekey);
        }
        private void zerokey_Click(object sender, EventArgs e)
        {
            popUpKey(23, this.zerokey);
        }

        private void printkey_Click(object sender, EventArgs e)
        {
            popUpKey(24,printkey );
        }
    

        private void backkey_Click(object sender, EventArgs e)
        {
            popUpKey(25,backkey);
        }

        private void homekey_Click(object sender, EventArgs e)
        {
            popUpKey(26, homekey);
        }

        private void qkey_Click(object sender, EventArgs e)
        {
            popUpKey(27,qkey);
        }

        private void wkey_Click(object sender, EventArgs e)
        {
            popUpKey(28,wkey);
        }

        private void ekey_Click(object sender, EventArgs e)
        {
            popUpKey(29,ekey);
        }

        private void rkey_Click(object sender, EventArgs e)
        {
            popUpKey(30,rkey);
        }

        private void tkey_Click(object sender, EventArgs e)
        {
            popUpKey(31,tkey);
        }

        private void ykey_Click(object sender, EventArgs e)
        {
            popUpKey(32,ykey );
        }

        private void ukey_Click(object sender, EventArgs e)
        {
            popUpKey(33, ukey);
        }

        private void ikey_Click(object sender, EventArgs e)
        {
            popUpKey(34, ikey);
        }

        private void okey_Click(object sender, EventArgs e)
        {
            popUpKey(35, okey);
        }

        private void pkey_Click(object sender, EventArgs e)
        {
            popUpKey(36, pkey);
        }
        private void insertkey_Click(object sender, EventArgs e)
        {
            popUpKey(37,insertkey );
        }
        private void tabkey_Click(object sender, EventArgs e)
        {
            popUpKey(38,tabkey);
        }

        private void enterkey_Click(object sender, EventArgs e)
        {
            popUpKey(39,enterkey);
        }
        private void pgupkey_Click(object sender, EventArgs e)
        {
            popUpKey(40, pgupkey);
        }

        private void akey_Click(object sender, EventArgs e)
        {
            popUpKey(41,akey );
        }

        private void skey_Click(object sender, EventArgs e)
        {
            popUpKey(42,skey );
        }

        private void dkey_Click(object sender, EventArgs e)
        {
            popUpKey(43, dkey);
        }

        private void fkey_Click(object sender, EventArgs e)
        {
            popUpKey(44,fkey );
        }

        private void gkey_Click(object sender, EventArgs e)
        {
            popUpKey(45, gkey);
        }

        private void hkey_Click(object sender, EventArgs e)
        {
            popUpKey(46,hkey);
        }

        private void jkey_Click(object sender, EventArgs e)
        {
            popUpKey(47,jkey);
        }

        private void kkey_Click(object sender, EventArgs e)
        {
            popUpKey(48,kkey);
        }

        private void lkey_Click(object sender, EventArgs e)
        {
            popUpKey(49 ,lkey);
        }

        private void upkey_Click(object sender, EventArgs e)
        {
            popUpKey(50,upkey );
        }

        private void deletekey_Click(object sender, EventArgs e)
        {
            popUpKey(51,deletekey);
        }

        private void shiftkey_Click(object sender, EventArgs e)
        {
            popUpKey(52,shiftkey );
        }
        private void winkey_Click(object sender, EventArgs e)
        {
            popUpKey(53,winkey );
        }

        private void pgdnkey_Click(object sender, EventArgs e)
        {
            popUpKey(54,pgdnkey);
        }

        private void zkey_Click(object sender, EventArgs e)
        {
            popUpKey(55,zkey );
        }

        private void xkey_Click(object sender, EventArgs e)
        {
            popUpKey(56,xkey );
        }

        private void ckey_Click(object sender, EventArgs e)
        {
            popUpKey(57,ckey);
        }

        private void vkey_Click(object sender, EventArgs e)
        {
            popUpKey(58,vkey);
        }

        private void bkey_Click(object sender, EventArgs e)
        {
            popUpKey(59,bkey);
        }

        private void nkey_Click(object sender, EventArgs e)
        {
            popUpKey(60,nkey);
        }
        private void mkey_Click(object sender, EventArgs e)
        {
            popUpKey(61,mkey );
        }
      
        private void spacekey_Click(object sender, EventArgs e)
        {
            popUpKey(62,spacekey );
        }
        private void leftkey_Click(object sender, EventArgs e)
        {
            popUpKey(63,leftkey );
        }

        private void downkey_Click(object sender, EventArgs e)
        {
            popUpKey(64,downkey);
        }
        private void rightkey_Click(object sender, EventArgs e)
        {
            popUpKey(65,rightkey);
        }
          
        private void ctrlkey_Click(object sender, EventArgs e)
        {
            popUpKey(66,ctrlkey );
        }
        private void altkey_Click(object sender, EventArgs e)
        {
            popUpKey(67,altkey );
        }
        private void endkey_Click(object sender, EventArgs e)
        {
            popUpKey(68,endkey );
        }


        public void popUpKey(int number,Button sender)
        {
            if (info.keyInformation[number].isKeyOpen == true)
            {
                info.keyValue[number].Hide();
                sender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                info.keyInformation[number].isKeyOpen = false;
            }
            else
            {
                info.keyValue[number].Show();
                sender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
                info.keyInformation[number].isKeyOpen = true;
            }
        }
    }

    
}
