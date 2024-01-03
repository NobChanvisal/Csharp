namespace Show3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void txtQTY_Leave(object sender, EventArgs e)
        {

        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            txtAmount.Text = (int.Parse(txtQTY.Text) * double.Parse(txtPrice.Text)).ToString();
        }

        private void txtAmount_Leave(object sender, EventArgs e)
        {

        }

        private void bttSell_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.id = txtID.Text;
            f2.name = txtName.Text;
            f2.qty = txtQTY.Text;
            f2.price = txtPrice.Text;
            f2.amount = txtAmount.Text;
            f2.ShowDialog();
        }
    }
}