using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dialog_Practice__MVC_
{
    public static class MyModel
    {
        public static string Read(Lazy<string> fileName)
        {
            string fileName_str = fileName.Value.ToString();
            string text = File.ReadAllText(fileName_str);

            return text;
        }

        public static void Write(string textbox, Lazy<string> fileName)
        {
            string fileName_str = fileName.Value.ToString();
            File.WriteAllText(fileName_str, textbox);
        }
    }
}
