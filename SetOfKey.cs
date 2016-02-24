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
using System.Windows.Forms;

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
            keyValue[0] = new TestKey((byte)Keys.Escape, "ESC");
            keyValue[1] = new TestKey((byte)Keys.F1, "F1");
            keyValue[2] = new TestKey((byte)Keys.F2, "F2");
            keyValue[3] = new TestKey((byte)Keys.F3, "F3");
            keyValue[4] = new TestKey((byte)Keys.F4, "F4");
            keyValue[5] = new TestKey((byte)Keys.F5, "F5");
            keyValue[6] = new TestKey((byte)Keys.F6, "F6");
            keyValue[7] = new TestKey((byte)Keys.F7, "F7");
            keyValue[8] = new TestKey((byte)Keys.F8, "F8");
            keyValue[9] = new TestKey((byte)Keys.F9, "F9");
            keyValue[10] = new TestKey((byte)Keys.F10, "F10");
            keyValue[11] = new TestKey((byte)Keys.F11, "F11");
            keyValue[12] = new TestKey((byte)Keys.F12, "F12");
            keyValue[13] = new TestKey((byte)Keys.Subtract, "-");
            keyValue[14] = new TestKey((byte)Keys.D1, "1");
            keyValue[15] = new TestKey((byte)Keys.D2, "2");
            keyValue[16] = new TestKey((byte)Keys.D3, "3");
            keyValue[17] = new TestKey((byte)Keys.D4, "4");
            keyValue[18] = new TestKey((byte)Keys.D5, "5");
            keyValue[19] = new TestKey((byte)Keys.D6, "6");
            keyValue[20] = new TestKey((byte)Keys.D7, "7");
            keyValue[21] = new TestKey((byte)Keys.D8, "8");
            keyValue[22] = new TestKey((byte)Keys.D9, "9");
            keyValue[23] = new TestKey((byte)Keys.D0, "0");
            keyValue[24] = new TestKey((byte)Keys.PrintScreen, "PRINT");
            keyValue[25] = new TestKey((byte)Keys.Back, "BACK");
            keyValue[26] = new TestKey((byte)Keys.Home, "HOME");
            keyValue[27] = new TestKey((byte)Keys.Q, "Q");
            keyValue[28] = new TestKey((byte)Keys.W, "W");
            keyValue[29] = new TestKey((byte)Keys.E, "E");
            keyValue[30] = new TestKey((byte)Keys.R, "R");
            keyValue[31] = new TestKey((byte)Keys.T, "T");
            keyValue[32] = new TestKey((byte)Keys.Y, "Y");
            keyValue[33] = new TestKey((byte)Keys.U, "U");
            keyValue[34] = new TestKey((byte)Keys.I, "I");
            keyValue[35] = new TestKey((byte)Keys.O, "O");
            keyValue[36] = new TestKey((byte)Keys.P, "P");
            keyValue[37] = new TestKey((byte)Keys.Insert, "INSERT");
            keyValue[38] = new TestKey((byte)Keys.Tab, "TAB");
            keyValue[39] = new TestKey((byte)Keys.Enter, "ENTER");
            keyValue[40] = new TestKey((byte)Keys.PageUp, "PGUP");
            keyValue[41] = new TestKey((byte)Keys.A, "A");
            keyValue[42] = new TestKey((byte)Keys.S, "S");
            keyValue[43] = new TestKey((byte)Keys.D, "D");
            keyValue[44] = new TestKey((byte)Keys.F, "F");
            keyValue[45] = new TestKey((byte)Keys.G, "G");
            keyValue[46] = new TestKey((byte)Keys.H, "H");
            keyValue[47] = new TestKey((byte)Keys.J, "J");
            keyValue[48] = new TestKey((byte)Keys.K, "K");
            keyValue[49] = new TestKey((byte)Keys.L, "L");
            keyValue[50] = new TestKey((byte)Keys.Up, "UP");
            keyValue[51] = new TestKey((byte)Keys.Delete, "DEL");
            keyValue[52] = new TestKey((byte)Keys.ShiftKey, "SHIFT");
            keyValue[53] = new TestKey((byte)Keys.LWin, "WIN");
            keyValue[54] = new TestKey((byte)Keys.PageDown, "PGDN");
            keyValue[55] = new TestKey((byte)Keys.Z, "Z");
            keyValue[56] = new TestKey((byte)Keys.X, "X");
            keyValue[57] = new TestKey((byte)Keys.C, "C");
            keyValue[58] = new TestKey((byte)Keys.V, "V");
            keyValue[59] = new TestKey((byte)Keys.B, "B");
            keyValue[60] = new TestKey((byte)Keys.N, "N");
            keyValue[61] = new TestKey((byte)Keys.M, "M");
            keyValue[62] = new TestKey((byte)Keys.Space, "SPACE");
            keyValue[63] = new TestKey((byte)Keys.Left, "LEFT");
            keyValue[64] = new TestKey((byte)Keys.Down, "DOWN");
            keyValue[65] = new TestKey((byte)Keys.Right, "RIGHT");
            keyValue[66] = new TestKey((byte)Keys.ControlKey, "CTRL");
            keyValue[67] = new TestKey((byte)Keys.Menu, "ALT");
            keyValue[68] = new TestKey((byte)Keys.End, "END");
            keyValue[69] = new TestKey((byte)Keys.F12, "F12");
            
        }
    }
}
