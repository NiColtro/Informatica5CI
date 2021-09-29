using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Porto {

    public static class XMLUtils {

        public static void WriteXML(Porto p) {

            try {
                StreamWriter sw = new StreamWriter(@"Z:\porto.xml", false);
                XmlSerializer xmls = new XmlSerializer(typeof(Porto), new Type[]{ typeof(List<Vela>), typeof(List<Motore>) });

                xmls.Serialize(sw, p);
                sw.Close();
            } catch (Exception e) {
                Console.WriteLine(e);
                throw;
            }
        }

        public static Porto ReadXML() {

            if (!File.Exists(@"Z:\porto.xml")) {
                return new Porto();
            }

            try {
                StreamReader sr = new StreamReader(@"Z:\porto.xml");
                XmlSerializer xmls = new XmlSerializer(typeof(Porto), new Type[]{ typeof(List<Vela>), typeof(List<Motore>) });
                
                Porto p = (Porto) xmls.Deserialize(sr);
                sr.Close();

                return p;
            } catch (Exception e) {
                return new Porto();
            }
        }
    }
}