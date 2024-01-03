using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        string data = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void bttSearch_Click(object sender, EventArgs e)
        {
            bttAdd.Text = "New";
        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
            if(bttAdd.Text == "New")
            {
                bttAdd.Text = "Add";
            }
            else
            {
                data +=  txtID.Text + "\t" + txtName.Text + "\t" + txtClass.Text + "\n";
                //string[] N = new string[data.Length + 1];
                //for(int i = 0; i < data.Length; i++)
                //{
                 //   N[i] = data[i];
                //}
               // data = N;
            }
            ListBviewData.Items.Add(data);
        }
    }
}
