using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inputTextForm_01_11_23
{
    public partial class Form2 : Form
    {
        public string data { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            le_show_txtF1.Text = data;//show data at form2 on label
        }
    }
}
