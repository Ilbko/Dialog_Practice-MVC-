using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dialog_Practice__MVC_
{
    public static class MyModel
    {
        public static string[] Read(string fileName)
        {
            string[] text = File.ReadAllLines(fileName);

            return text;
        }

        public static void Write(string[] text, string fileName)
        {

        }
    }
}
