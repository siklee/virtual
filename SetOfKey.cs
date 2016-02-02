using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using virtualKeyBoard.KeySet;


namespace virtualKeyBoard
{
    public class SetOfKey
    {
        private static SetOfKey instance;   
        // 싱글톤 

        public static int keyBoardMode = 0;   // off 0 on 1 setting 2
        public static bool isKeyBoardOpen = false;


        public Keyinfo[] keyInformation= new Keyinfo[71];

        //컴퓨터 키

        public SetOfKey()
        {
            keyInformation[0] = new Keyinfo("A");
            keyInformation[1] = new Keyinfo("B");
            keyInformation[2] = new Keyinfo("C");
            keyInformation[3] = new Keyinfo("D");
        }
        
       

        public static SetOfKey Instance()
        {
            if (instance == null)
            {
                instance = new SetOfKey();
            }

            return instance;
        }
  
        public void serializeKeySetting()
        {
            XmlSerializer xmlSetializer = new XmlSerializer(typeof(SetOfKey));
            using (StreamWriter writer = new StreamWriter("keySetting.xml"))
            {
                xmlSetializer.Serialize(writer, this);
            }

        }
       
        public void deSerializeKeySetting()
        {
            SetOfKey inKey = SetOfKey.Instance();
            XmlSerializer xmlSetializer = new XmlSerializer(typeof(SetOfKey));
            using (StreamReader writer = new StreamReader("keySetting.xml"))
            {
                inKey = (SetOfKey)xmlSetializer.Deserialize(writer);
            }
            for(int i=0;i<1;i++)
            {
                this.keyInformation = inKey.keyInformation;
            }
        }


    }
    
    
    

    public class Keyinfo
    {
        public bool isKeyOpen;
        public TestKey Key;

        
        public Keyinfo(string keyValue)
        {
            isKeyOpen = false;
            Key = new TestKey(keyValue);
        }
        /*
        public bool getIskeyOpen()
        {
            return iskeyopen;
        }
        public int getxloc()
        {
            return locationX;
        }
        public int getyloc()
        {
            return locationY;
        }
        */
    }

    

}
