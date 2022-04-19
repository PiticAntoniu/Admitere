using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admitere
{
    internal class Config
    {
        public  int numberOfSubjects=6;
        public  string defaultDocFolder="c:/temp/";

        public  void Load()
        {
            string json = File.ReadAllText(
                Properties.Resources.defaultConfigFile);
            Config t = new Config();
            t = JsonConvert.DeserializeObject<Config>(json);
            this.numberOfSubjects = t.numberOfSubjects;
            this.defaultDocFolder = t.defaultDocFolder;
        }

        public  void Save()
        {
            string json = 
                JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(Properties.Resources.defaultConfigFile, json);
        }

    }
}
