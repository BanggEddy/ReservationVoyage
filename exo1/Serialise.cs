using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace exo1
{
    public class Serialise
    {
        public static void sauvegarde(List<Voyage> lV)
        {
            FileStream stream = new FileStream("data", FileMode.Create);
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(stream, lV);
            stream.Close();
        }
        public static List<Voyage> chargement()
        {
            List<Voyage> lstVoyages = null;
            if (File.Exists("data"))
            {
                BinaryFormatter deserializer = new BinaryFormatter();
                FileStream stream = new FileStream("data", FileMode.Open);
                lstVoyages = (List<Voyage>)deserializer.Deserialize(stream);
                stream.Close();
            }
            return (lstVoyages);
        }



        private void FormClient_Load(object sender, System.EventArgs e)
        {
        }

    }
}
