using System.Xml.Serialization;
using System.IO;
using System.Text;

namespace Teacher.Modules
{
    class XMLAccesser<T>
    {
        public T Object { get; set; }

        public XMLAccesser(T obj)
        {
            Object = obj;
        }

        private XMLAccesser() { }

        public static XMLAccesser<T> ReadXML(string fileName)
        {
            XMLAccesser<T> xmlAccesser = new XMLAccesser<T>();
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            if (File.Exists(fileName))
            {
                StreamReader sr = new StreamReader(fileName, new UTF8Encoding(false));
                xmlAccesser.Object = (T)serializer.Deserialize(sr);
                sr.Close();
            }
            return xmlAccesser;
        }

        public void save(string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            StreamWriter sw = new StreamWriter(fileName, false, new UTF8Encoding(false));
            serializer.Serialize(sw, Object);
            sw.Close();
        }
    }
}
