using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Show9
{
    public partial class MainFrm : Form
    {
        public struct Book
        {
            public string id, title;
            public int qty;
        };
        public struct borrow
        {
            public string id, bid, rname;
            int qty;
        };
        Book[] sb = new Book[1];
        borrow[] br = new borrow[1];
        public MainFrm()
        {
            InitializeComponent();
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBook FB = new FrmBook();
            FB.MdiParent = this;
            FB.Show();
        }

        private void borrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBorrow FBr = new FrmBorrow();
            FBr.MdiParent = MainFrm.ActiveForm;
            FBr.Show();
        }
    }
}
