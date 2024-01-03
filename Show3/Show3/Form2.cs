using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Show3
{
    public partial class Form2 : Form
    {
        public string id { get;set; }
        public string name { get;set; }
        public string qty { get; set; }
        public string price { get; set; }
        public string amount { set; get; }  
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            la_ShowID.Text = id;
            la_ShowName.Text = name;
            la_ShowQTY.Text = qty;
            la_ShowPrice.Text = price;
            la_Sh_Amount.Text = amount;
        }
    }
}
