using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace SerializationTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("András", 25);
            Console.WriteLine(p1);
            Serialize(p1);
            Person p2 = Deserialize();
            Console.WriteLine(p2);
        }

        private static void Serialize(Person sp)
        {
            FileStream fs = new FileStream("Person.Dat", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, sp);
            fs.Close();
        }

        private static Person Deserialize()
        {
            Person dsp = new Person();
            FileStream fs = new FileStream("Person.Dat", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            dsp = (Person)bf.Deserialize(fs);
            fs.Close();
            return dsp;
        }
    }
}
