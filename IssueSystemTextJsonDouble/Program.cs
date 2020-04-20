using System;
using System.Text.Json.Serialization;

namespace IssueSystemTextJsonDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            var rowVector = new RowVector { X = 1.0, Y = 213.9, Z = 112.0 };
            var serializedData = System.Text.Json.JsonSerializer.Serialize(rowVector);
            var newtonSoftSerializedData = Newtonsoft.Json.JsonConvert.SerializeObject(rowVector);
            Console.WriteLine($"SerializedData with System.Text.Json {serializedData} " +
                $"Here upon deserialization for example in Python webservice x & z are treated as int");
            Console.WriteLine($"SerializedData with Newtonsoft.Json {newtonSoftSerializedData} " +
                $"Here upon deserialization for example in Python webservice x & z are treated as double which is working as expected");
            Console.ReadKey();
        }
    }

    public class RowVector
    {
        [JsonPropertyName("x")]
        public double X { get; set; }

        [JsonPropertyName("y")]
        public double Y { get; set; }

        [JsonPropertyName("z")]
        public double Z { get; set; }
    }
}
