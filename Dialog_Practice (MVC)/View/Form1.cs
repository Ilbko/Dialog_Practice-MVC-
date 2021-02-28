using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dialog_Practice__MVC_
{
    public partial class Form1 : Form
    {
        MyLogic logic = new MyLogic();
        Lazy<OpenFileDialog> open_dialog;
        Lazy<SaveFileDialog> save_dialog;
        Lazy<ColorDialog> color_dialog;
        Lazy<string> pathFile;

        public Form1()
        {
            InitializeComponent();

            button_open.Location = new Point(20, 20);
            button_save.Location = new Point(120, 20);
            button_color.Location = new Point(220, 20);
            textbox.Location = new Point(20, 120);

            button_open.Text = "Открыть";
            button_save.Text = "Сохранить";
            button_color.Text = "Цвет";

            //textbox.Size = new Size(200, 200);
            textbox.Width = textbox.Height = 200;
            textbox.Multiline = true;

            button_open.Click += Button_open_Click;
            button_save.Click += Button_save_Click;
            button_color.Click += Button_color_Click;

            this.Controls.AddRange(new Control[] { button_open, button_save, button_color, textbox });
        }

        public void Button_color_Click(object sender, EventArgs e)
        {
            logic.Color_Logic(color_dialog, ref textbox);
        }

        public void Button_save_Click(object sender, EventArgs e)
        {
            //save_dialog = new Lazy<SaveFile>

            logic.Save_Logic(save_dialog, pathFile, textbox.Text);
        }

        public void Button_open_Click(object sender, EventArgs e)
        {
            logic.Open_Logic(open_dialog, pathFile, ref textbox);
        }
    }
}
