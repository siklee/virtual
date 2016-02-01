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

        public bool isCkeyOpen = false;
        public Point cpoint = new Point();
        //컴퓨터 키

        
       

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
            this.isCkeyOpen = inKey.isCkeyOpen;
            this.cpoint = inKey.cpoint;
        }


    }

   


    public class Point
    {
        public int locationX;
        public int locationY;


        public void setPoint(int locationX, int locationY)
        {
            this.locationX = locationX;
            this.locationY = locationY;
        }
    }

}
