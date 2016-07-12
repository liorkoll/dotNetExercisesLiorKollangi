using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personnel
{
    public class Personnel
    {
        public List<string> ReadFile(string path)
        {
            StreamReader streamReader = new StreamReader(path);
            List<string> lines = new List<string>();
            string line;
            while ((line = streamReader.ReadLine()) != null)
            {
                lines.Add(line);
            }
            return lines;
        }
    }
}
