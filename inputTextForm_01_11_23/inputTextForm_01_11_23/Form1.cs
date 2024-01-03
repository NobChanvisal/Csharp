namespace inputTextForm_01_11_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void form2Button_Click(object sender, EventArgs e)
        {
            
            Form2 form = new Form2();
            form.data = textBox1.Text;
            form.ShowDialog();
            
        }
    }
}