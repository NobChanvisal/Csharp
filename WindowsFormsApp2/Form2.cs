using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        string S;
        public Form2(string st)
        {
            InitializeComponent();
            S = st;
        }
        //public Form2(string st) {
        //    S = st;
        //}

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text =S;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
