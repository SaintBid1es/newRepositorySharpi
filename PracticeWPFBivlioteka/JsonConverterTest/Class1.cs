using System;
using System.IO;
using System.Xml.Serialization;
using System.IO;
using System.Text.Json;

namespace JsonConverterTest
{

    public class DataSerializer
    {
        public class Test
        {
            public string RandomTextOne { get; set; }
            public string RandomTextTwo { get; set; }
            public string RandomTextThree { get; set; }

        }

        public static void Serialize<T>(T data, string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            {
                serializer.Serialize(fileStream, data);
            }
        }

        public static T Deserialize<T>(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                return (T)serializer.Deserialize(fileStream);
            }
        }
    }
}


    
