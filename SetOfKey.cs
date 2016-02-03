using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using virtualKeyBoard.KeySet;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace virtualKeyBoard
{
    
    public class SetOfKey
    {
        private static SetOfKey instance;   
        // 싱글톤 

        public static int keyBoardMode = 0;   // off 0 on 1 setting 2
        public static bool isKeyBoardOpen = false;


        public Keyinfo[] keyInformation= new Keyinfo[71];
        public TestKey[] keyValue = new TestKey[71];
        

        public static SetOfKey Instance()
        {
            if (instance == null)
            {
                instance = new SetOfKey();
            }

            return instance;
        }

        //컴퓨터 키
        public SetOfKey()
        {
            keyValue[0] = new TestKey("{ESC}");
            keyValue[1] = new TestKey("{F1}");
            keyValue[2] = new TestKey("{F2}");
            keyValue[3] = new TestKey("{F3}");
            keyValue[4] = new TestKey("{F4}");
            keyValue[5] = new TestKey("{F5}");
            keyValue[6] = new TestKey("{F6}");
            keyValue[7] = new TestKey("{F7}");
            keyValue[8] = new TestKey("{F8}");
            keyValue[9] = new TestKey("{F9}");
            keyValue[10] = new TestKey("{F10}");
            keyValue[11] = new TestKey("{F11}");
            keyValue[12] = new TestKey("{F12}");
            keyValue[13] = new TestKey("-");
            keyValue[14] = new TestKey("1");
            keyValue[15] = new TestKey("2");
            keyValue[16] = new TestKey("3");
            keyValue[17] = new TestKey("4");
            keyValue[18] = new TestKey("5");
            keyValue[19] = new TestKey("6");
            keyValue[20] = new TestKey("7");
            keyValue[21] = new TestKey("8");
            keyValue[22] = new TestKey("9");
            keyValue[23] = new TestKey("0");
            keyValue[24] = new TestKey("{PRTSC}");
            keyValue[25] = new TestKey("{BS}");
            keyValue[26] = new TestKey("{HOME}");
            keyValue[27] = new TestKey("Q");
            keyValue[28] = new TestKey("W");
            keyValue[29] = new TestKey("E");
            keyValue[30] = new TestKey("R");
            keyValue[31] = new TestKey("T");
            keyValue[32] = new TestKey("Y");
            keyValue[33] = new TestKey("U");
            keyValue[34] = new TestKey("I");
            keyValue[35] = new TestKey("O");
            keyValue[36] = new TestKey("P");
            keyValue[37] = new TestKey("{INS}");
            keyValue[38] = new TestKey("{TAB}");
            keyValue[39] = new TestKey("{ENTER}");
            keyValue[40] = new TestKey("{PGUP}");
            keyValue[41] = new TestKey("A");
            keyValue[42] = new TestKey("S");
            keyValue[43] = new TestKey("D");
            keyValue[44] = new TestKey("F");
            keyValue[45] = new TestKey("G");
            keyValue[46] = new TestKey("H");
            keyValue[47] = new TestKey("J");
            keyValue[48] = new TestKey("K");
            keyValue[49] = new TestKey("L");
            keyValue[50] = new TestKey("{UP}");
            keyValue[51] = new TestKey("{DEL}");
            keyValue[52] = new TestKey("+");
            keyValue[53] = new TestKey("{HELP}");
            keyValue[54] = new TestKey("{PGDN}");
            keyValue[55] = new TestKey("Z");
            keyValue[56] = new TestKey("X");
            keyValue[57] = new TestKey("C");
            keyValue[58] = new TestKey("V");
            keyValue[59] = new TestKey("B");
            keyValue[60] = new TestKey("N");
            keyValue[61] = new TestKey("M");
            keyValue[62] = new TestKey("{SPACE}");
            keyValue[63] = new TestKey("{LEFT}");
            keyValue[64] = new TestKey("{DOWN}");
            keyValue[65] = new TestKey("{RIGHT}");
            keyValue[66] = new TestKey("^");
            keyValue[67] = new TestKey("%");
            keyValue[68] = new TestKey("END");
            keyValue[69] = new TestKey("{F12}");

            for (int i = 0; i < 70; i++)
            {
                keyInformation[i] = new Keyinfo();
            }

        }
    }


    [Serializable]
    public class Keyinfo
    {
        public bool isKeyOpen;
        public int locationX;
        public int locationY;
        public string keyValue;

   

        public Keyinfo()
        {
            isKeyOpen = false;
            locationX = 100;
            locationY = 100;
        }
      
    }
}
