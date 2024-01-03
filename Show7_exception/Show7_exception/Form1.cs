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

namespace Show7_exception
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double[] Amout = new double[1];
        private void txtAmount_Enter(object sender, EventArgs e)
        {
            try
            {
                txtAmount.Text = (Convert.ToInt16(txtQty.Text) * Convert.ToDouble(txtPrice.Text)).ToString();
                Amout[Amout.Length - 1] = double.Parse(txtAmount.Text);
            }
            catch ( FormatException er)
            {
                MessageBox.Show(er.Message);
            }
            catch(IndexOutOfRangeException er)
            {
                MessageBox.Show("Please generate index array first");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + "email.....");
            }
            finally
            {
                MessageBox.Show("Bye Bye class");
            }
        }
        byte[][] store = new byte[1][];
        int n = 0;
        private void bttBrowe_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            //pictureBox1.ImageLocation = openFileDialog1.FileName;
            pictureBox1.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            store[store.Length-1] = ms.GetBuffer();
            Array.Resize(ref store, store.Length);
            n = store.Length - 1;
        }

        private void bttView_Click(object sender, EventArgs e)
        {
            if (n >= store.Length - 1) n = 0;
            MemoryStream ms = new MemoryStream(store[n++]);
            pictureBox1.Image = Image.FromStream(ms);   
        }
    }
}
