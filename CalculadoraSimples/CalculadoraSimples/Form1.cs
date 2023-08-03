namespace CalculadoraSimples
{
    public partial class oi : Form
    {
        public oi()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtDisplay.Text);

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
        txtDisplay: Clear();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }
        }

        private void btnzero_Click(object sender, EventArgs e)
        {

        }

        private void btnone_Click(object sender, EventArgs e)
        {

        }
    }
}