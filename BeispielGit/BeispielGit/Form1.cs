using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeispielGit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            createTextBox();
        }

        private void createTextBox()
        {
            TextBox box = new TextBox();
            box.Width = 150;
            box.Height = 50;
            box.Top = 30;
            box.Left = 50;
            Controls.Add(box);
        }
    }
}
