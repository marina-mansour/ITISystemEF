using ITISystemEF.Forms;

namespace ITISystemEF
{
    public partial class Start_Form : Form
    {
        public Start_Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            Main_Form mainForm = new Main_Form();
            this.Hide();
            mainForm.ShowDialog();
            this.Show();

        }

        private void Start_Form_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
