using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchUpdate
{
    public partial class Form1 : Form
    {
        string st = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void bttInsert_Click(object sender, EventArgs e)
        {
            if(txtID.Text == "" || txtName.Text == "" || txtClass.Text == "" || txtShift.Text == "")
            {
                MessageBox.Show("Each Box Much Have An Input", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                st += txtID.Text + "\t" + txtName.Text + "\t" + txtClass.Text + "\t" + txtShift.Text + "\n";
                MessageBox.Show("INSERT SUCCESSFUL");
                txtID.Clear();
                txtName.Clear();    
                txtClass.Clear();
                txtShift.Clear();
                txtID.Focus();
            }
        }

        private void bttShow_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(st, "Data Entry", MessageBoxButtons.OK);
        }

        private void bttSearch_Click(object sender, EventArgs e)
        {
            string[] s = st.Split('\n');
            foreach(string s2 in s) {
                if(s2 != "") { 
                string[] ss = s2.Split('\t');
                if (ss[0] == txtID.Text)
                {
                    MessageBox.Show(s2);
                    return;
                }
            }
        }
            MessageBox.Show("Student Not Found");
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void bttUpdate_Click(object sender, EventArgs e)
        {
            
        }
    }
}
