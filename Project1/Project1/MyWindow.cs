using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    class MyWindow : Form
    {
        static void Main()
        {
            MyWindow form = new MyWindow();
            form.Text = "My First Form";

            Button button = new Button();
            button.Text = "Click me";
            form.Controls.Add(button);

            Application.Run(form);
            
        }
    }
}
