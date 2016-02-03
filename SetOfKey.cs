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
            keyValue[0] = new TestKey("{ESC}","ESC");
            keyValue[1] = new TestKey("{F1}","F1");
            keyValue[2] = new TestKey("{F2}", "F2");
            keyValue[3] = new TestKey("{F3}", "F3");
            keyValue[4] = new TestKey("{F4}", "F4");
            keyValue[5] = new TestKey("{F5}", "F5");
            keyValue[6] = new TestKey("{F6}", "F6");
            keyValue[7] = new TestKey("{F7}", "F7");
            keyValue[8] = new TestKey("{F8}", "F8");
            keyValue[9] = new TestKey("{F9}", "F9");
            keyValue[10] = new TestKey("{F10}", "F10");
            keyValue[11] = new TestKey("{F11}", "F11");
            keyValue[12] = new TestKey("{F12}", "F12");
            keyValue[13] = new TestKey("-", "-");
            keyValue[14] = new TestKey("1", "1");
            keyValue[15] = new TestKey("2", "2");
            keyValue[16] = new TestKey("3", "3");
            keyValue[17] = new TestKey("4", "4");
            keyValue[18] = new TestKey("5", "5");
            keyValue[19] = new TestKey("6", "6");
            keyValue[20] = new TestKey("7", "7");
            keyValue[21] = new TestKey("8", "8");
            keyValue[22] = new TestKey("9", "9");
            keyValue[23] = new TestKey("0", "0");
            keyValue[24] = new TestKey("{PRTSC}", "PRINT");
            keyValue[25] = new TestKey("{BS}", "BACK");
            keyValue[26] = new TestKey("{HOME}", "HOME");
            keyValue[27] = new TestKey("Q", "Q");
            keyValue[28] = new TestKey("W", "W");
            keyValue[29] = new TestKey("E", "E");
            keyValue[30] = new TestKey("R", "R");
            keyValue[31] = new TestKey("T", "T");
            keyValue[32] = new TestKey("Y", "Y");
            keyValue[33] = new TestKey("U", "U");
            keyValue[34] = new TestKey("I", "I");
            keyValue[35] = new TestKey("O", "O");
            keyValue[36] = new TestKey("P", "P");
            keyValue[37] = new TestKey("{INS}", "INSERT");
            keyValue[38] = new TestKey("{TAB}", "TAB");
            keyValue[39] = new TestKey("{ENTER}", "ENTER");
            keyValue[40] = new TestKey("{PGUP}", "PGUP");
            keyValue[41] = new TestKey("A", "A");
            keyValue[42] = new TestKey("S", "S");
            keyValue[43] = new TestKey("D", "D");
            keyValue[44] = new TestKey("F", "F");
            keyValue[45] = new TestKey("G", "G");
            keyValue[46] = new TestKey("H", "H");
            keyValue[47] = new TestKey("J", "J");
            keyValue[48] = new TestKey("K", "K");
            keyValue[49] = new TestKey("L", "L");
            keyValue[50] = new TestKey("{UP}", "UP");
            keyValue[51] = new TestKey("{DEL}", "DEL");
            keyValue[52] = new TestKey("+", "SHIFT");
            keyValue[53] = new TestKey("{HELP}", "WIN");
            keyValue[54] = new TestKey("{PGDN}", "PGDN");
            keyValue[55] = new TestKey("Z", "Z");
            keyValue[56] = new TestKey("X", "X");
            keyValue[57] = new TestKey("C", "C");
            keyValue[58] = new TestKey("V", "V");
            keyValue[59] = new TestKey("B", "B");
            keyValue[60] = new TestKey("N", "N");
            keyValue[61] = new TestKey("M", "M");
            keyValue[62] = new TestKey("{SPACE}", "SPACE");
            keyValue[63] = new TestKey("{LEFT}", "LEFT");
            keyValue[64] = new TestKey("{DOWN}", "DOWN");
            keyValue[65] = new TestKey("{RIGHT}", "RIGHT");
            keyValue[66] = new TestKey("^", "CTRL");
            keyValue[67] = new TestKey("%", "ALT");
            keyValue[68] = new TestKey("END", "END");
            keyValue[69] = new TestKey("{F12}", "F12");
            
        }
    }
}
