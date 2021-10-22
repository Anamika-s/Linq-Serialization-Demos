using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


using System.Xml.Serialization;

namespace BinaryFormatterDemo
{
    [Serializable]
    public class Emp
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class DataSerialize
    {
        public void JSONSerialize(object data, string filePath)
        {
            JsonSerializer formatter = new JsonSerializer();
            FileStream fs;

            if (File.Exists(filePath)) File.Delete(filePath);
            fs = File.Create(filePath);
            StreamWriter sw = new StreamWriter(fs);
            JsonWriter jsonwriter = new JsonTextWriter(sw);
            formatter.Serialize(jsonwriter, data);
            sw.Close();
            fs.Close();
            jsonwriter.Close();
        }
        public object JSONDeserialze(string filePath)
        {
            JsonSerializer formatter = new JsonSerializer();
            object obj = null;
            FileStream fs;
            //BinaryFormatter formatter = new BinaryFormatter();
            if (File.Exists(filePath))
            {
                fs = File.OpenRead(filePath);
                StreamReader sr = new StreamReader(fs);
                JsonReader reader = new JsonTextReader(sr);
                obj = formatter.Deserialize(reader);
                fs.Close();
            }
            return obj;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Emp e = new Emp() { FirstName = "Ajay", LastName = "Sood" };
            string filePath = @"D:\BinaryEmpJSON.txt";
            DataSerialize ds = new DataSerialize();
            ds.JSONSerialize(e, filePath);
            //    Emp e1 = null;
            //    e1 = ds.JSONDeserialze(filePath) as Emp;
            //    Console.WriteLine("First Name " + e1.FirstName);
            //    Console.WriteLine("Last Name " + e1.LastName);
            //}
        }
    }
}
