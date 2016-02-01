using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace virtualKeyBoard
{
    public static class SetOfKey
    {
        public static bool isCkeyOpen = false;
        
    }

    public class IOSetOfKey
    {
        public bool tempIsCkeyOpen;

        public IOSetOfKey()
        {
            this.tempIsCkeyOpen = SetOfKey.isCkeyOpen;
        }

        public IOSetOfKey(IOSetOfKey dat)
        {
            this.tempIsCkeyOpen = dat.tempIsCkeyOpen;
        }


        public void serializeKeySetting()
        {
            XmlSerializer xmlSetializer = new XmlSerializer(typeof(IOSetOfKey));
            using (StreamWriter writer = new StreamWriter("keySetting.xml"))
            {
                xmlSetializer.Serialize(writer, this);
            }

        }

        public void deSerializeKeySetting()
        {
            IOSetOfKey inKey = new IOSetOfKey();
            XmlSerializer xmlSetializer = new XmlSerializer(typeof(IOSetOfKey));
            using (StreamReader writer = new StreamReader("keySetting.xml"))
            {
                inKey = (IOSetOfKey)xmlSetializer.Deserialize(writer);
            }

            SetOfKey.isCkeyOpen = inKey.tempIsCkeyOpen;
        }
        
    }

}
