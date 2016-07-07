using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileFinder
{
    class FinderFilterdFiles
    {
        public void Searchfiles(List<string> filterdList, string path, string containsString)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);

            FileInfo[] filesArr = directoryInfo.GetFiles();
            DirectoryInfo[] directoryArr = directoryInfo.GetDirectories();
            foreach (FileInfo file in filesArr)
            {
                if (file.Name.Contains(containsString))
                {
                    filterdList.Add(string.Format("File Name : {0} size : {1} bytes.", file.Name, file.Length));
                }
            }
            foreach (DirectoryInfo directory in directoryArr)
            {
                Searchfiles(filterdList, directory.FullName, containsString);           
           }
        }
          }
}
