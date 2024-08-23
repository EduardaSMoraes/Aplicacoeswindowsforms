namespace TrocaValores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtmClicar_Click(object sender, EventArgs e)
        {
            string x = TxtValor1.Text;
            TxtValor1.Text = TxtValor2.Text;
            TxtValor2.Text = x;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtValor2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtValor1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtmClicar_MouseHover(object sender, EventArgs e)
        {
            BtmClicar.BackColor = Color.LightPink;
        }
    }
}
