using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dialog_Practice__MVC_
{
    public class MyLogic
    {
        //Random r = new Random();
        public void Save_Logic(Lazy<SaveFileDialog> dialogSave, Lazy<string> pathFile, string textbox)
        {
            dialogSave = new Lazy<SaveFileDialog>();
            dialogSave.Value.Filter = "Text|*.txt";

            if (dialogSave.Value.ShowDialog() == DialogResult.OK)
            {
                pathFile = new Lazy<string>(new Func<string>(() => dialogSave.Value.FileName)); 
                MyModel.Write(textbox, pathFile);
            }
        }

        public void Open_Logic(Lazy<OpenFileDialog> dialogOpen, Lazy<string> pathFile, ref TextBox textbox)
        {
            dialogOpen = new Lazy<OpenFileDialog>();
            dialogOpen.Value.Filter = "Text|*.txt";

            if (dialogOpen.Value.ShowDialog() == DialogResult.OK)
            {
                pathFile = new Lazy<string>(new Func<string>(() => dialogOpen.Value.FileName));
                textbox.Text = MyModel.Read(pathFile);
            }
        }

        public void Color_Logic(Lazy<ColorDialog> dialogColor, ref TextBox textbox)
        {
            //textbox.ForeColor = Color.FromArgb(r.Next(0, 127), r.Next(0, 127), r.Next(0, 127));
            dialogColor = new Lazy<ColorDialog>();

            if (dialogColor.Value.ShowDialog() == DialogResult.OK)
            {
                textbox.BackColor = dialogColor.Value.Color;
            }
        }
    }
}
