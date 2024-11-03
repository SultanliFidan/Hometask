using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FileStream
{
    internal class FileStream
    {

        public string Path { get; }
        public FileStream(string path)
        {
            Path = path;
        }

        List<string> names = [];

        public void Add(string name)
        {

            
            names.Add(name);
            string result = JsonConvert.SerializeObject(names);
            using StreamWriter sw = new StreamWriter(Path);
            sw.WriteLine(result);
        }

        public bool Exist(string name)
        {
            bool isExist = false;
            using StreamReader sr = new StreamReader(Path);
            string result = sr.ReadToEnd();
            var objname = JsonConvert.DeserializeObject<List<string>>(result);
            if (objname.Contains(name))
            {
                isExist = true;
            }
            return isExist;

        }

        public void Update(int index, string name)
        {
            if (index >= 0 && index < names.Count)
            {
                
                    names[index] = name;
                
                string result = JsonConvert.SerializeObject(names);
                using StreamWriter sw = new StreamWriter(Path);
                sw.WriteLine(result);
            }

        }
        public void Delete(int index)
        {
            if (index >= 0 && index < names.Count)
            {
                
                    names.RemoveAt(index);
                
                string result = JsonConvert.SerializeObject(names);
                using StreamWriter sw = new StreamWriter(Path);
                sw.WriteLine(result);
            }
        }
    }
}
