using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admitere
{
    internal static class MockData
    {
        public static void Save(Test test, string fileNme)
        {
            string json =
JsonConvert.SerializeObject(test, Formatting.Indented);
            File.WriteAllText(fileNme, json);

        }

        internal static Test Load(string mockDataFile)
        {
            string json = File.ReadAllText(
                Properties.Resources.mockDataFile);
            return JsonConvert.DeserializeObject<Test>(json);

        }
    }
}
