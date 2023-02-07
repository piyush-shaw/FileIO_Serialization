using System;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization
{
	public class BinaryDeSerialization
	{
        public void DeSerialization()
        {
            FileStream fileStream = new FileStream(@"/Users/piyushshaw/projects/fileio/Serialization/Example.txt", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            Demo deserializationdemo = (Demo)formatter.Deserialize(fileStream);
            Console.WriteLine($"Application name {deserializationdemo.ApplicationName} ---ApplicationId    {deserializationdemo.ApplicationId}");
            Console.ReadKey();
        }

    }
}

