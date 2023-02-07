using System;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization
{
	public class BinarySerialization
	{
        public void Serialization()
        {
            Demo sample = new Demo();
            FileStream fileStream = new FileStream(@"/Users/piyushshaw/projects/fileio/Serialization/Example.txt", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, sample);
            Console.ReadKey();
        }
    }

    [Serializable]
    public class Demo
    {
        public string ApplicationName { get; set; } = "Binary Serialize";
        public int ApplicationId { get; set; } = 1001;
    }

}


