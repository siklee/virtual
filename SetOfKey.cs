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


        public Keyinfo[] keyInformation= new Keyinfo[71];



        public bool isCkeyOpen = false;
        public Point cpoint = new Point();
        //컴퓨터 키

        public SetOfKey()
        {
            for(int i=0;i<71;i++)
            {
                keyInformation[i] = new Keyinfo();
            }
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
            for(int i=0;i<71;i++)
            {
                this.keyInformation = inKey.keyInformation;
            }
            this.isCkeyOpen = inKey.isCkeyOpen;
            this.cpoint = inKey.cpoint;
        }


    }

    public class Point
    {
        public int locationX;
        public int locationY;

        public void setPoint(int x,int y)
        {
            locationX = x;
            locationY = y;
        }

    }


    

    public class Keyinfo
    {
        public int locationX;
        public int locationY;

        public bool iskeyopen;

        
        public Keyinfo()
        {
            locationX = 100;
            locationY = 100;
            iskeyopen = false;
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
