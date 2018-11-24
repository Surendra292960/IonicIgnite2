using Apache.Ignite.Core.Binary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace IgniteDemo
{
        class Reflective
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

    public class Employee
    {
        static void Main(string[] args)
        {
            Binarizable a = new Binarizable();
        }
    }

        class Binarizable : IBinarizable
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public void WriteBinary(IBinaryWriter writer)
            {
                writer.WriteInt("Id", Id);
                writer.WriteString("Name", Name);
            }

            public void ReadBinary(IBinaryReader reader)
            {
                Id = reader.ReadInt("Id");
                Name = reader.ReadString("Name");
            }
        }

        class Serializable : ISerializable
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public Serializable() { }

            protected Serializable(SerializationInfo info, StreamingContext context)
            {
                Id = info.GetInt32("Id");
                Name = info.GetString("Name");
            }

            public void GetObjectData(SerializationInfo info, StreamingContext context)
            {
                info.AddValue("Id", Id);
                info.AddValue("Name", Name);
            }
        }

}
