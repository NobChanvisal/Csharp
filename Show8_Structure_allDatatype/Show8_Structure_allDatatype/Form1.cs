using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Show8_Structure_allDatatype
{
    public partial class Form1 : Form
    {
        struct Book
        {
            public string id;
            public string title;
            public int qty;
            public byte[] photo;
        };
        Book[] store = new Book[1];
        int n = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            store[store.Length - 1].id = txtID.Text;
            store[store.Length - 1].title = txtTitle.Text;
            store[store.Length - 1].qty = int.Parse(txtQTY.Text);
            MemoryStream ms = new MemoryStream();
            //to save picture
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            store[store.Length - 1].photo = ms.GetBuffer();
            Array.Resize(ref store, store.Length + 1);

            ListView ListView1 = new ListView();
            ListViewItem T = ListView1.Items.Add(txtID.Text);
            T.SubItems.Add(txtTitle.Text);
            T.SubItems.Add(txtQTY.Text);
            txtID.Clear();
            txtQTY.Clear();
            txtTitle.Clear();
            pictureBox1.Image = null;
            txtID.Focus();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (n >= store.Length - 2) n--;
            n++;
            txtID.Text = store[n].id;
            txtTitle.Text = store[n].title;
            txtQTY.Text = store[n].qty.ToString();
            MemoryStream ms = new MemoryStream(store[n].photo);
            pictureBox1.Image = Image.FromStream(ms);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if(n<= 0) n++;
            n--;
            txtID.Text = store[n].id;
            txtTitle.Text= store[n].title;
            txtQTY.Text= store[n].qty.ToString();
            MemoryStream ms = new MemoryStream(store[n].photo);
            pictureBox1.Image= Image.FromStream(ms);
        }
    }
}

