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
    public partial class Form1 : Form
    {
        //Golbal
        string st = "";
        char ch = '\0';
        int a = 0;
        double b = 0.0;
        DateTime d = DateTime.Now;
        bool m = true; // true/false
        object obj = null;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {   //local
            //string st="";
            //a = ch;
            st = st + TxtInput.Text + "\n";
            d = DateTime.Parse( "01/02/2023");
            MessageBox.Show(st + d.ToLongDateString());
        }

        private void btnF2_Click(object sender, EventArgs e)
        {
            Form2 F = new Form2(st);
            F.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
