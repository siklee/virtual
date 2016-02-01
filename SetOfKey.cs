using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace virtualKeyBoard
{
    public class SetOfKey
    {
        private static SetOfKey instance;
        public bool isCkeyOpen = false;

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
        }

    }
}
