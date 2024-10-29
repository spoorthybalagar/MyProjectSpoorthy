using System;
using System.IO;

namespace batch7_Spoorthy
{
    internal class Serialize
    {
        public int ID { get; set; }
        public string Name { get; set; }

        static void Main(string[] args)
        {
            Serialize obj = new Serialize
            {
                ID = 1,
                Name = ".Net"
            };

            try
            {
                // Serialize to binary format manually
                using (FileStream fs = new FileStream("C:\\Example.bin", FileMode.Create, FileAccess.Write))
                using (BinaryWriter writer = new BinaryWriter(fs))
                {
                    writer.Write(obj.ID);
                    writer.Write(obj.Name);
                    Console.WriteLine("Object serialized to binary format successfully!");
                }

                // Deserialize from binary format manually
                using (FileStream fs = new FileStream("C:\\Example.bin", FileMode.Open, FileAccess.Read))
                using (BinaryReader reader = new BinaryReader(fs))
                {
                    Serialize objnew = new Serialize();
                    objnew.ID = reader.ReadInt32();
                    objnew.Name = reader.ReadString();

                    Console.WriteLine("Deserialized Object:");
                    Console.WriteLine($"ID: {objnew.ID}");
                    Console.WriteLine($"Name: {objnew.Name}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
