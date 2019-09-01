using System;
using System.IO;

namespace MyClasses
{
   public class FileProcess
   {
        public bool fileExisits(string fileName) {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException("FileName");
            }
            return File.Exists(fileName);
        }
   }
}
